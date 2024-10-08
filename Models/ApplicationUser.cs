using Microsoft.AspNetCore.Identity;

namespace Demo_Asp_DotNetCoreWebAPI;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
}
