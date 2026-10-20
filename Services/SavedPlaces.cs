namespace Template.Services;

/// <summary>
/// The visitor's shortlist. Registered as scoped, so it lives for the browser session (the Blazor circuit)
/// and is shared by the header, Home, Discover and Plan. Changed lets the header badge update live.
/// </summary>
public sealed class SavedPlaces
{
    private readonly HashSet<int> _ids = new();

    public event Action? Changed;

    public int Count => _ids.Count;
    public IReadOnlyCollection<int> Ids => _ids;

    public bool Contains(int id) => _ids.Contains(id);

    public void Toggle(int id)
    {
        if (!_ids.Remove(id)) _ids.Add(id);
        Changed?.Invoke();
    }
}
