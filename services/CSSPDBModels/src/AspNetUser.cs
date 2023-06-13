namespace CSSPDBModels;

public partial class AspNetUser
{
    [Key]
    [CSSPMaxLength(450)]
    public string Id { get; set; } = string.Empty;
    [CSSPMaxLength(256)]
    [CSSPAllowNull]
    public string Email { get; set; } = string.Empty;
    public bool EmailConfirmed { get; set; }
    [CSSPAllowNull]
    public string PasswordHash { get; set; } = string.Empty;
    [CSSPAllowNull]
    public string SecurityStamp { get; set; } = string.Empty;
    [CSSPAllowNull]
    public string PhoneNumber { get; set; } = string.Empty;
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    [CSSPAfter(Year = 1980)]
    public DateTime? LockoutEndDateUtc { get; set; }
    public bool LockoutEnabled { get; set; }
    [CSSPRange(0, 10000)]
    public int AccessFailedCount { get; set; }
    [CSSPMaxLength(256)]
    public string UserName { get; set; } = string.Empty;
    [CSSPMaxLength(256)]
    [CSSPAllowNull]
    public string NormalizedUserName { get; set; } = string.Empty;
    [CSSPMaxLength(256)]
    [CSSPAllowNull]
    public string NormalizedEmail { get; set; } = string.Empty;
    [CSSPMaxLength(256)]
    [CSSPAllowNull]
    public string ConcurrencyStamp { get; set; } = string.Empty;
    [CSSPAfter(Year = 1980)]
    public DateTime? LockoutEnd { get; set; }

    public AspNetUser()
    {
    }
}

