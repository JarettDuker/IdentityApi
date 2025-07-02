using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; init; }
    public string? Password { get; set; }
}