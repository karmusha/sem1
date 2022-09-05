using Telegram.Bot;
using Telegram.Bot.Types;
var botClient = new TelegragBotClient("5403058309483:AGDBFGsdflknsGSkfngllskmlkdfmglknxffv");

var me = await botClient.GetMeAsync();

while (true)
{
    var updates = await botClient.GetUpdatesAsync();
    for (int i = 0; i < updates.Count(); i++)
    {
        switch(updates[i].Type)
        {
            case Telegram.Bot.Types.Enums.UpdateType.Message: {
                HandleMessage(updates[i].Message);

                updates = await botClient.GetUpdatesAsync(updates[^1].Id +1);
                break;
            }
        }
    }
}

async void HandleMessage(Message message)
{
    Console.WriteLine(message.Text);

    await botClient.SendTextMessageAsync(message.From.Id, "Halo Sir");
}