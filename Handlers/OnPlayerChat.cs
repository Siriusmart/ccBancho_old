using MCGalaxy;
using System.Reflection;

public class OnPlayerChat {
    public static void Command(Player p, string message) {
        if (!message.StartsWith('!'))
            return;

        string[] args = message.Substring(1).SplitSpaces();
        Type? command = ChatCommand.Get(args[0]);

        if (command == null)
            return;

        p.cancelchat = true;

        object[] parameters = { p, args[1..] };
        object? res = command.GetMethod("Run").Invoke(null, parameters);

        if (args[0] == "help" && res != null) {
            p.Message($"&e<Local>{p.ColoredName}: &f{message}");
            p.Message($"&e<Local>&8BanchoBot: &f{res}");
            return;
        }

        if (res == null) {
            string format =
                (string)command.GetMethod("Format").Invoke(null, null);

            if (format.Length != 0) {
                format = $" {format}";
            }

            p.Message($"&e<Local>{p.ColoredName}: &f{message}");
            p.Message(
                $"&e<Local>&8BanchoBot: &f{ChatHelp.Run(p, new string[1]{args[1]})}'.");
        } else {
            Chat.MessageFrom(p, $"{p.ColoredName}: &f{message}");
            Chat.MessageFrom(p, $"&8BanchoBot: &f{res}");
        }
    }
}
