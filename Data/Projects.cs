namespace portfolio.igormagno.com.Data;

public class Projects
{
    public static readonly Project[] List =
    {
        new()
        {
            Name = "Sistema de Gestão Financeira",
            Description = "Case técnico representativo de uma plataforma financeira corporativa, focada em organização de domínio, performance e escalabilidade.",
            Link = "https://github.com/igor-magno/financial-management-system-case",
            IsCase = true
        },
        new()
        {
            Name = "Aplicação Mobile Corporativa",
            Description = "Case técnico representativo de um aplicativo mobile corporativo para operação interna, com foco em integração e estabilidade.",
            Link = "https://github.com/igor-magno/corporate-mobile-app-case",
            IsCase = true
        }
    };
}