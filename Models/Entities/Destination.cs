namespace Template.Models.Entities;

public sealed class Destination
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public string Province { get; init; } = "";
    public IslandGroup IslandGroup { get; init; }
    public TravelMood Mood { get; init; }
    public string ImagePath { get; init; } = "";
    public string ImageAlt { get; init; } = "";
    public string Tagline { get; init; } = "";
    public string Description { get; init; } = "";
    public string SignatureExperience { get; init; } = "";
    public string BestTime { get; init; } = "";
    public string InsiderTip { get; init; } = "";
    public int SuggestedDays { get; init; }
    public decimal DailyBudgetPerPerson { get; init; }
    public bool Featured { get; init; }
    public double Latitude { get; init; }
    public double Longitude { get; init; }
    public IReadOnlyList<string> Highlights { get; init; } = Array.Empty<string>();

    public string LocationLabel => $"{Province} / {IslandGroup}";
    public string MoodLabel => TravelLabels.Label(Mood);

    /// <summary>e.g. "11.20°N 119.41°E"</summary>
    public string CoordinateLabel =>
        $"{Math.Abs(Latitude):0.00}°{(Latitude >= 0 ? "N" : "S")} {Math.Abs(Longitude):0.00}°{(Longitude >= 0 ? "E" : "W")}";

    public decimal EstimateBudget(int days, int travelers) =>
        DailyBudgetPerPerson * Math.Max(1, days) * Math.Max(1, travelers);

    /// <summary>Case-insensitive search across the fields a traveller would type.</summary>
    public bool Matches(string? term)
    {
        if (string.IsNullOrWhiteSpace(term)) return true;
        var t = term.Trim();
        return Name.Contains(t, StringComparison.OrdinalIgnoreCase)
            || Province.Contains(t, StringComparison.OrdinalIgnoreCase)
            || Description.Contains(t, StringComparison.OrdinalIgnoreCase)
            || SignatureExperience.Contains(t, StringComparison.OrdinalIgnoreCase)
            || Highlights.Any(h => h.Contains(t, StringComparison.OrdinalIgnoreCase));
    }
}
