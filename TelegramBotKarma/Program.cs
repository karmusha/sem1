// using Telegram.Bot;
// using Telegram.Bot.Types;
// var botClient = new TelegragBotClient("5403058309483:AGDBFGsdflknsGSkfngllskmlkdfmglknxffv");

// var me = await botClient.GetMeAsync();

// while (true)
// {
//     var updates = await botClient.GetUpdatesAsync();
//     for (int i = 0; i < updates.Count(); i++)
//     {
//         switch(updates[i].Type)
//         {
//             case Telegram.Bot.Types.Enums.UpdateType.Message: {
//                 HandleMessage(updates[i].Message);

//                 updates = await botClient.GetUpdatesAsync(updates[^1].Id +1);
//                 break;
//             }
//         }
//     }
// }

// async void HandleMessage(Message message)
// {
//     Console.WriteLine(message.Text);

//     await botClient.SendTextMessageAsync(message.From.Id, "Halo Sir");
// }


// ----- ДЗ -----
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int GetAkkeman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    {
        if (n != 0 && m == 0)
        return GetAkkeman(n - 1, 1);
        else return GetAkkeman (n -1, GetAkkeman(n, m - 1));
    }
}

int GetAkkeman2(int number, int argument) {
    if (number == 0)
        return argument + 1;

    int result = argument;
    for (int i = 0; i < argument + 2; i++) {
        result = GetAkkeman2(number - 1, result);
    }

    return result;
}


int GetAkkeman3(int m, int n) {
    if (m == 0)
        return n + 1;

    if (n == 0)
        return GetAkkeman3(m - 1, 1);
    
    return GetAkkeman3(m - 1, GetAkkeman3(m, n - 1));
}

int akker = GetAkkeman2(first, last);
Console.WriteLine(akker);