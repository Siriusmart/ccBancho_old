using System.Collections.Generic;

public class Formatter {
    static (string, long)[] units = { ("week", 604800), ("day", 86400),
                                      ("hour", 3600), ("minute", 60),
                                      ("second", 1) };

    public static string Duration(long seconds, int precesion) {

        List<string> output = new List<string>();

        foreach (var entry in units) {
            long amount = seconds / entry.Item2;
            seconds %= entry.Item2;

            switch (amount) {
            case 0:
                continue;
            case 1:
                output.Add($"{amount} {entry.Item1}");
                break;
            default:
                output.Add($"{amount} {entry.Item1}s");
                break;
            }
        }

        output = output.Slice(0, Math.Min(precesion, output.Count));

        string outputString = string.Empty;

        for (int i = 0; i < output.Count; i++) {
            if (i == 0) {
                outputString += output[i];
                continue;
            }

            if (i == output.Count - 1) {
                outputString += $" and {output[i]}";
                continue;
            }

            outputString += $", {output[i]}";
        }

        return outputString;
    }
}
