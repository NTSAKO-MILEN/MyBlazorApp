namespace MyBlazorApp.Models;

public class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime DateTime { get; set; }

    public string Venue { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<string> RegisteredAttendees { get; set; } = [];
}
