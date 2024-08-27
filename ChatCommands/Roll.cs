using MCGalaxy;

public class Roll : ChatCommand {
    static Random rng = new Random();

    public static bool Public() {
        return true;
    }

    public static string Format() { return "<min=1> <max=100>"; }

    public static string? Run(Player p, string[] args) {
        int rolled;
        switch (args.Length) {
        case 0:
            rolled = rng.Next(1, 101);
            break;
        case 1:
            try {
                rolled = rng.Next(1, Convert.ToInt32(args[0]) + 1);
#pragma warning disable 0168
            } catch (Exception _) {
#pragma warning restore 0168
                return null;
            }
            break;
        case 2:
            try {
                rolled = rng.Next(Convert.ToInt32(args[0]),
                                  Convert.ToInt32(args[1]) + 1);
#pragma warning disable 0168
            } catch (Exception _) {
#pragma warning restore 0168
                return null;
            }
            break;
        default:
            return null;
        }

        return $"{p.DisplayName}&f rolled a {rolled}.";
    }
}
