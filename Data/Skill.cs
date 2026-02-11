using portfolio.igormagno.com.Data.Enums;

namespace portfolio.igormagno.com.Data;

public class Skill
{
    public string Name { get; set; }
    public SkillType Type { get; set; }
    public string Color { get; set; }
    public string Link { get; set; }
    public bool IsTechnology { get; set; }
    public bool UseInProduction { get; set; }
}