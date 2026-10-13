namespace MyBlazorApp.Services;

public class UserSessionState
{
    public string? CurrentUserName { get; private set; }

    public string? CurrentUserEmail { get; private set; }

    public event Action? OnChange;

    public void SetCurrentUser(string name, string email)
    {
        CurrentUserName = name;
        CurrentUserEmail = email;
        NotifyStateChanged();
    }

    public void ClearSession()
    {
        CurrentUserName = null;
        CurrentUserEmail = null;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
