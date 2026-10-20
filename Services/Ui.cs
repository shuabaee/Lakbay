using System.Globalization;

namespace Template.Services;

/// <summary>Tiny display helpers shared by the components.</summary>
public static class Ui
{
    /// <summary>
    /// aria-pressed / aria-expanded need the literal strings "true"/"false".
    /// Passing a C# bool makes Blazor drop the attribute when false.
    /// </summary>
    public static string Bool(bool value) => value ? "true" : "false";

    /// <summary>Percentage (0-100) of value within min..max, formatted for CSS.</summary>
    public static string Percent(double value, double min, double max)
    {
        var pct = max <= min ? 0 : Math.Clamp((value - min) / (max - min) * 100, 0, 100);
        return pct.ToString("0.##", CultureInfo.InvariantCulture) + "%";
    }

    public static string Pad(int number) => number.ToString("00", CultureInfo.InvariantCulture);
}
