using MCGalaxy;

public interface ChatCommand {
    public static Type? Get(string command) {
        switch (command) {
        case "roll":
            return typeof(Roll);
        case "coinflip":
            return typeof(Coinflip);
        case "help":
            return typeof(ChatHelp);
        default:
            return null;
        }
    }

    public abstract static string Format();
    public abstract static string? Run(Player p, string[] args);
}
