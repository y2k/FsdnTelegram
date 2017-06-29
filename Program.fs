open System

module RX = Observable
module T  = Telegram
module A  = FsdnApi

module Domain =
    let parseMessage (message: string) =
        match message.Trim().Replace('‘', '\'') with
        | "/start" -> Error "Enter function signature.\nFor example: string -> int"
        | x        -> Ok x

    let resultToMessage (x: Result<A.Response list, string>) =
        match x with
        | Error e -> e + "\nОшибка, возможно у вас неправильная сигнатура функции.\nПример правильной: string -> int"
        | Ok []   -> "0 results.\nНе найденно ни одной сигнатуры функции :\\"
        | Ok xs   -> xs |> List.map (fun x -> sprintf "%O :: %O \n%O\n\n" x.clazz x.method x.url) 
                        |> List.reduce (+)

[<EntryPoint>]
let main argv =
    let token = argv.[0]
    T.listenForMessages token
        |> RX.add (fun x -> 
            async {
                let pm = Domain.parseMessage x.text
                let! a = match pm with
                         | Error e -> async.Return e
                         | Ok i    -> async {
                                          do! T.setProgress token x.user
                                          let! results = A.execute { signature = i }
                                          return Domain.resultToMessage results
                                      }
                T.send token x.user a |> ignore
            } |> Async.Start)

    printfn "Listening for updates..."
    Threading.Thread.Sleep(-1);
    0