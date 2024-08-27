using MCGalaxy;

public class ChatHelp : ChatCommand {
    static Random rng = new Random();

    public static string Format() { return "<command>"; }

    public static string? Run(Player p, string[] args) {
        if (args.Length == 0) {
            return $"Available commands are: help, roll, coinflip.";
        } else {
            Type? command = ChatCommand.Get(args[0]);
            if (command == null) {
                return $"Invalid command `{args[0]}'. {Run(p, new string[0])}";
            }

            string format =
                (string)command.GetMethod("Format").Invoke(null, null);
            if (format.Length != 0) {
                format = $" {format}";
            }
            return $"Command usage: `!{args[0]}{format}'";
        }
    }
}
