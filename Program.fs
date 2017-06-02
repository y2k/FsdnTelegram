open System

module RX  = Observable
module Bot = Telegram
module A   = FsdnApi

module Domain =
    let parseMessage (message: string) =
        match message.Trim() with
        | "/start" -> Error "Введите сигнатуру функции.\nК примеру: string -> int"
        | x        -> Ok x

    let resultToMessage (x: Result<A.Response list, string>) =
        match x with
        | Error e -> e + "\nОшибка, возможно у вас неправильная сигнатура функции.\nПример правильной: string -> int"
        | Ok []   -> "Не найденно ни одной сигнатуры функции :\\"
        | Ok xs   -> xs |> List.map (fun x -> sprintf "%O :: %O \n%O\n\n" x.clazz x.method x.url) 
                        |> List.reduce (+)

[<EntryPoint>]
let main argv =
    Bot.listerForMessages argv.[0]
        |> RX.add (fun x -> 
            async {
                let pm = Domain.parseMessage x.text
                let! a = match pm with
                         | Error e -> async.Return e
                         | Ok i    -> async {
                                          let! results = A.execute { signature = i }
                                          return Domain.resultToMessage results
                                      }
                Bot.sendToTelegramSingle argv.[0] x.user a |> ignore
            } |> Async.Start)

    printfn "Listening for updates..."
    Threading.Thread.Sleep(-1);
    0