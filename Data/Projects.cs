namespace portfolio.igormagno.com.Data;

public class Projects
{
    public static readonly Project[] List =
    {
        new()
        {
            Name = "Sistema de Gestão Financeira",
            Description = "Case técnico de uma plataforma financeira corporativa, com foco em organização de domínio, arquitetura bem definida e escalabilidade.",
            Link = "https://github.com/igor-magno/financial-management-system-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        },
        new()
        {
            Name = "Aplicação Mobile Corporativa",
            Description = "Case técnico de aplicativo mobile corporativo voltado à operação interna, priorizando integração com APIs e estabilidade em produção.",
            Link = "https://github.com/igor-magno/corporate-mobile-app-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        },
        new()
        {
            Name = "BRANDT Brasil",
            Description = "Aplicativo corporativo voltado ao setor agrícola, oferecendo conteúdos técnicos e ferramentas para apoiar decisões no manejo e produtividade no campo.",
            Link = "https://agro.brandtbrasil.com/app-brandt-brasil",
            LogoLink = "https://play-lh.googleusercontent.com/ZjTrqNiTWffaAWaBTvHjCUPOMQYsOGv4YYOO8Oh44LVfCqFfmkGzibBKqo1u6XcuRu4=w240-h480-rw",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "BRANDT Brasil"
        },
        new()
        {
            Name = "EXAMIN",
            Description = "Aplicativo para organização e compartilhamento de exames médicos, centralizando histórico de saúde e facilitando o acompanhamento periódico.",
            Link = "https://examin.com.br/",
            LogoLink = "https://play-lh.googleusercontent.com/q-ZJhV6dLA0LFuhWgWXLjRd2hOmrgcLKzTDQ_ywz3GqKi1POjOvAjm77D74wFbcPWo4=w240-h480-rw",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "EXAMIN"
        }
    };
}
