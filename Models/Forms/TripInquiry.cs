using System.ComponentModel.DataAnnotations;

namespace Template.Models.Forms;

public sealed class TripInquiry : IValidatableObject
{
    [Required(ErrorMessage = "Tell us what to call you.")]
    [StringLength(70, MinimumLength = 2, ErrorMessage = "Use between 2 and 70 characters.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Your email is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [Range(1, 999, ErrorMessage = "Choose a destination.")]
    public int DestinationId { get; set; } = 1;

    [Required(ErrorMessage = "Choose an arrival date.")]
    public DateTime Arrival { get; set; } = DateTime.Today.AddDays(30);

    [Required(ErrorMessage = "Choose a departure date.")]
    public DateTime Departure { get; set; } = DateTime.Today.AddDays(34);

    [Range(1, 12, ErrorMessage = "Choose between 1 and 12 travelers.")]
    public int Travelers { get; set; } = 2;

    public TravelPace Pace { get; set; } = TravelPace.Balanced;

    [StringLength(400, ErrorMessage = "Keep your notes under 400 characters.")]
    public string Notes { get; set; } = "";

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Arrival.Date < DateTime.Today)
            yield return new ValidationResult("Arrival cannot be in the past.", [nameof(Arrival)]);
        if (Departure.Date <= Arrival.Date)
            yield return new ValidationResult("Departure must be after arrival.", [nameof(Departure)]);
    }
}
