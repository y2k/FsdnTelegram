module Telegram

open System
open Telegram.Bot
open Telegram.Bot.Types

let private token =
    Environment.GetEnvironmentVariable "TELEGRAM_TOKEN"

type Message = { text: string; user: string }

type TelegramResponse =
    | SuccessResponse
    | BotBlockedResponse
    | UnknownErrorResponse

let setProgress (user: string) =
    async {
        let bot = TelegramBotClient(token)

        do! bot.SendChatActionAsync(user |> ChatId, Types.Enums.ChatAction.Typing)
            |> Async.AwaitTask
    }

let listenForMessages (token: string) =
    let bot = TelegramBotClient(token)

    let result =
        bot.OnUpdate
        |> Observable.map
            (fun x ->
                { text = x.Update.Message.Text
                  user = string x.Update.Message.From.Id })

    bot.StartReceiving()
    result

let send (user: string) message =
    async {
        try
            let bot = TelegramBotClient(token)

            do! bot.SendTextMessageAsync(user |> ChatId, message, parseMode = Types.Enums.ParseMode.Default)
                |> Async.AwaitTask
                |> Async.Ignore

            return SuccessResponse
        with
        | :? AggregateException as ae ->
            match ae.InnerException with
            | :? Exceptions.ApiRequestException -> return BotBlockedResponse
            | _ -> return failwith "ERROR"
        | _ -> return UnknownErrorResponse
    }
