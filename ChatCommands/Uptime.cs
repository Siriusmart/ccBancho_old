using MCGalaxy;

public class Uptime : ChatCommand {
    public static bool Public() {
        return false;
    }

    public static string Format() { return ""; }

    public static string? Run(Player p, string[] args) {
        return $"I have been online for {Formatter.Duration(DateTimeOffset.UtcNow.ToUnixTimeSeconds() - ((DateTimeOffset) Server.StartTime).ToUnixTimeSeconds(), 3)}";
    }
}
