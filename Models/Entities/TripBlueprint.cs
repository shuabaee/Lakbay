namespace Template.Models.Entities;

/// <summary>An immutable trip sketch built from a validated inquiry. All figures are computed, never stored.</summary>
public sealed class TripBlueprint
{
    public Destination Destination { get; }
    public DateTime Arrival { get; }
    public DateTime Departure { get; }
    public int Travelers { get; }
    public TravelPace Pace { get; }

    public TripBlueprint(Destination destination, DateTime arrival, DateTime departure, int travelers,
        TravelPace pace = TravelPace.Balanced)
    {
        Destination = destination;
        Arrival = arrival;
        Departure = departure;
        Travelers = travelers;
        Pace = pace;
    }

    public int Nights => Math.Max(1, (Departure.Date - Arrival.Date).Days);
    public decimal EstimatedLow => Math.Round(Destination.EstimateBudget(Nights, Travelers) * .80m, 0);
    public decimal EstimatedHigh => Math.Round(Destination.EstimateBudget(Nights, Travelers) * 1.25m, 0);

    /// <summary>A friendly reference such as LKB-1119-0102 (arrival date, place, crew size).</summary>
    public string Reference => $"LKB-{Arrival:MMdd}-{Destination.Id:00}{Travelers:00}";
}
