using MyBlazorApp.Models;

namespace MyBlazorApp.Services;

public class EventService
{
    private readonly List<Event> _events =
    [
        new Event
        {
            Id = 1,
            Name = "Community Tech Meetup",
            DateTime = DateTime.Today.AddDays(7).AddHours(18),
            Venue = "Innovation Hub",
            Description = "Meet local developers and share ideas."
        },
        new Event
        {
            Id = 2,
            Name = "Creative Arts Festival",
            DateTime = DateTime.Today.AddDays(14).AddHours(10),
            Venue = "Riverside Park",
            Description = "A day of art, music, and community."
        },
        new Event
        {
            Id = 3,
            Name = "Small Business Workshop",
            DateTime = DateTime.Today.AddDays(21).AddHours(9),
            Venue = "Town Hall",
            Description = "Practical sessions for aspiring business owners."
        }
    ];

    public event Action? OnChange;

    public IReadOnlyList<Event> GetAllEvents() => _events;

    public bool RegisterAttendee(int eventId, string attendeeName)
    {
        var selectedEvent = _events.Find(item => item.Id == eventId);
        if (selectedEvent is null || string.IsNullOrWhiteSpace(attendeeName))
        {
            return false;
        }

        var normalizedName = attendeeName.Trim();
        if (selectedEvent.RegisteredAttendees.Contains(normalizedName, StringComparer.OrdinalIgnoreCase))
        {
            return false;
        }

        selectedEvent.RegisteredAttendees.Add(normalizedName);
        OnChange?.Invoke();
        return true;
    }
}
