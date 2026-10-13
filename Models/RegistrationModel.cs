using System.ComponentModel.DataAnnotations;

namespace MyBlazorApp.Models;

public class RegistrationModel
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}
