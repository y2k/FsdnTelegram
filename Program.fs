open System

module T  = Telegram
module A  = FsdnApi

module Domain =
    let parseMessage (message: string) =
        match message with
        | null | "/start" -> Error "Enter function signature.\nFor example: string -> int"
        | x               -> Ok <| x.Trim().Replace('‘', '\'')

    let resultToMessage (x: Result<A.Response list, string>) =
        match x with
        | Error e -> e + "\nОшибка, возможно у вас неправильная сигнатура функции.\nПример правильной: string -> int"
        | Ok []   -> "0 results.\nНе найденно ни одной сигнатуры функции :\\"
        | Ok xs   -> xs |> List.map (fun x -> sprintf "%O :: %O \n%O\n\n" x.clazz x.method x.url) 
                        |> List.reduce (+)

[<EntryPoint>]
let main _ =
    let token = Environment.GetEnvironmentVariable "TELEGRAM_TOKEN"

    T.listenForMessages token
    |> Observable.add (fun x -> 
        async {
            let pm = Domain.parseMessage x.text
            let! a = match pm with
                     | Error e -> async.Return e
                     | Ok i    -> async {
                                      do! T.setProgress x.user
                                      let! results = A.execute { signature = i }
                                      return Domain.resultToMessage results
                                  }
            do! T.send x.user a |> Async.Ignore
        } |> Async.Start)

    printfn "Listening for updates..."
    Threading.Thread.Sleep -1
    0