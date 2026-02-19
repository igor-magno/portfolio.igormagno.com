using portfolio.igormagno.com.Data.Enums;

namespace portfolio.igormagno.com.Data;

public class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Skill[] Skills { get; set; }
    public string? Link { get; set; }
    public string? CodeLink { get; set; }
    public string? LogoLink { get; set; }
    public bool IsCase { get; set; }
    public bool IsOwner { get; set; }
    public bool IsOpenCode { get; set; }
    public string? Client { get; set; }
}