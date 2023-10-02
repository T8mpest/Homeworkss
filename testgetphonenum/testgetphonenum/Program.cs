using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineQueryResults;
using System.Threading;
using System;
namespace testgetphonenum
{
    public static class Program
    {
        private static TelegramBotClient? bot;

        public static async Task Main()
        {
           bot = new TelegramBotClient("6510753628:AAFqlKSsN3mAh2KWvNiOumhtyQsTkPa8164");

        User me = await bot.GetMeAsync();
            Console.Title = me.Username ?? "My awesome bot";

            using var cts = new CancellationTokenSource();

            ReceiverOptions receiverOptions = new() { AllowedUpdates = { } };
            bot.StartReceiving(Handlers.HandleUpdateAsync,
                Handlers.HandleErrorAsync,
                receiverOptions,
                cts.Token);

            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();

            cts.Cancel();
        }
    }
}