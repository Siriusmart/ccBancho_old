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
        case "uptime":
            return typeof(Uptime);
        default:
            return null;
        }
    }

    public abstract static bool Public();
    public abstract static string Format();
    public abstract static string? Run(Player p, string[] args);
}
