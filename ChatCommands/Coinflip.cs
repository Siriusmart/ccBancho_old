using MCGalaxy;

public class Coinflip : ChatCommand {
    static Random rng = new Random();

    public static bool Public() {
        return true;
    }

    public static string Format() { return ""; }

    public static string? Run(Player p, string[] args) {
        string result;

        switch (rng.Next(0, 2)) {
        case 0:
            result = "heads";
            break;
        case 1:
            result = "tails";
            break;
        default:
            throw new Exception("unreachable");
        }

        return $"{p.DisplayName}&f landed on {result}.";
    }
}
