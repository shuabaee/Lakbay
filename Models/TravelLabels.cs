using System.Globalization;

namespace Template.Models;

/// <summary>Human-friendly text for the enums, kept in one place so every page words things the same way.</summary>
public static class TravelLabels
{
    public static string Label(TravelMood mood) => mood switch
    {
        TravelMood.Coast => "Sea & salt",
        TravelMood.Nature => "Wild places",
        TravelMood.Culture => "Culture & history",
        _ => "Slow days"
    };

    public static string Label(NoteCategory category) => category switch
    {
        NoteCategory.LocalLife => "Local life",
        NoteCategory.Outdoors => "Outdoors",
        _ => category.ToString()
    };

    public static string Label(TravelPace pace) => pace switch
    {
        TravelPace.Easy => "Easy does it",
        TravelPace.Balanced => "A little of everything",
        _ => "Pack the days"
    };

    public static string Blurb(TravelPace pace) => pace switch
    {
        TravelPace.Easy => "Late starts, long lunches, one plan a day.",
        TravelPace.Balanced => "Mornings out, afternoons left free.",
        _ => "Sunrise starts and full itineraries."
    };

    public static string Dots(TravelPace pace) => pace switch
    {
        TravelPace.Easy => "●○○",
        TravelPace.Balanced => "●●○",
        _ => "●●●"
    };

    /// <summary>Philippine peso with no decimals, independent of the server's culture: ₱3,800</summary>
    public static string Peso(decimal amount) => "₱" + amount.ToString("N0", CultureInfo.InvariantCulture);
}
