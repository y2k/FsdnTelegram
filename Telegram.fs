module Telegram

open Telegram.Bot
open System
module RX = Observable

type Message = { text: string; user: string }

let listerForMessages (token: string) =
    let bot = TelegramBotClient(token)
    let result = bot.OnUpdate 
                 |> RX.map (fun x -> x.Update)
                 |> RX.map (fun x -> { text = x.Message.Text; user = string x.Message.From.Id })
    bot.StartReceiving()
    result

type TelegramResponse = | SuccessResponse | BotBlockedResponse | UnknownErrorResponse
let sendToTelegramSingle (token: string) (user: string) message =
    try
        let bot = TelegramBotClient(token)
        bot.SendTextMessageAsync(user, message, parseMode = Types.Enums.ParseMode.Html).Result |> ignore
        SuccessResponse
    with
    | :? AggregateException as ae -> 
        match ae.InnerException with
        | :? Exceptions.ApiRequestException -> BotBlockedResponse
        | _                                 -> reraise()
    | _ -> UnknownErrorResponse