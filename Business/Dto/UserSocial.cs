namespace Business.Dto;

public class UserSocial
{
    public string? Uid { set; get; } = null;
    public string? Email { set; get; } = null;
    public string Network { set; get; } = string.Empty;
    public string First_name { set; get; } = string.Empty;
    public string Last_name { set; get; } = string.Empty;
}