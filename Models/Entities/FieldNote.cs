namespace Template.Models.Entities;

public sealed class FieldNote
{
    public int Id { get; init; }
    public int DestinationId { get; init; }
    public NoteCategory Category { get; init; }
    public string Title { get; init; } = "";
    public string Excerpt { get; init; } = "";
    public string Story { get; init; } = "";
    public string ImagePath { get; init; } = "";
    public string ImageAlt { get; init; } = "";
    public int ReadMinutes { get; init; }

    public string CategoryLabel => TravelLabels.Label(Category);
}
