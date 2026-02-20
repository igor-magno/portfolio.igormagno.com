namespace portfolio.igormagno.com.Data;

public class Projects
{
    public static readonly Project[] ResumeList =
    {
        new()
        {
            Name = "Sistema de Gestão Financeira",
            Description =
                "Case técnico de uma plataforma financeira corporativa, com foco em organização de domínio, arquitetura bem definida e escalabilidade.",
            CodeLink = "https://github.com/igor-magno/financial-management-system-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        },
        new()
        {
            Name = "Aplicação Mobile Corporativa",
            Description =
                "Case técnico de aplicativo mobile corporativo voltado à operação interna, priorizando integração com APIs e estabilidade em produção.",
            CodeLink = "https://github.com/igor-magno/corporate-mobile-app-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        }
    };

    public static readonly Project[] List =
    {
        new()
        {
            Name = "Sistema de Gestão Financeira",
            Description =
                "Plataforma financeira corporativa focada em organização de domínio, arquitetura escalável e boas práticas de desenvolvimento.",
            CodeLink = "https://github.com/igor-magno/financial-management-system-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        },
        new()
        {
            Name = "Aplicação Mobile Corporativa",
            Description =
                "Aplicativo corporativo com integração a APIs, arquitetura estável e foco em operação interna.",
            CodeLink = "https://github.com/igor-magno/corporate-mobile-app-case",
            IsCase = true,
            IsOwner = true,
            IsOpenCode = true,
            Client = null
        },
        new()
        {
            Name = "BRANDT Brasil",
            Description =
                "Aplicativo corporativo para o setor agrícola com conteúdos técnicos e ferramentas de apoio ao produtor rural.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.brandt&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/us/app/brandt-brasil-ordem-de-mistura/id6446657525?l=pt-BR",
            LogoLink = "/projects/logos/BRANDT Brasil.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "BRANDT Brasil"
        },
        new()
        {
            Name = "EXAMIN",
            Description =
                "Aplicativo para gestão e acompanhamento de exames médicos, centralizando o histórico do paciente.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.examin",
            AppStoreLink = "https://apps.apple.com/br/app/examin/id1641738047",
            LogoLink = "/projects/logos/EXAMIN.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "EXAMIN"
        },
        new()
        {
            Name = "Agropecuária Sucuri",
            Description =
                "Aplicativo para consulta e aquisição de animais com dados técnicos, exames e informações completas.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=com.sucuri&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/br/app/agropecu%C3%A1ria-sucuri/id6449043901",
            LogoLink = "/projects/logos/Agropecuária Sucuri.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "Agropecuária Sucuri"
        },
        new()
        {
            Name = "UNIPAX",
            Description =
                "Aplicativo de rede de benefícios com acesso a serviços, parceiros, pagamentos e cartão digital.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.unipax&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/es/app/unipax/id1537328740",
            LogoLink = "/projects/logos/UNIPAX.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "UNIPAX"
        },
        new()
        {
            Name = "Piquet Realty",
            Description =
                "Plataforma para indicação de compradores de imóveis com gestão de comissões e oportunidades.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=com.piquetrealty.piquetrealty&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/br/app/piquet-realty/id6471441658",
            LogoLink = "/projects/logos/Piquet Realty.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "Piquet Realty"
        },
        new()
        {
            Name = "Wemovi Rastreamento",
            Description =
                "Aplicativo de rastreamento veicular com monitoramento em tempo real e gestão de uso de veículos.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.weso&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/br/app/wemovi-rastreamento/id1643768122",
            LogoLink = "/projects/logos/Wemovi Rastreamento.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "Wemovi Rastreamento"
        },
        new()
        {
            Name = "appegada - Aplicativo dos Pets",
            Description =
                "Aplicativo para tutores de pets com rede social, localização de serviços e suporte a pets perdidos.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=com.appegada&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/br/app/appegada-aplicativo-dos-pets/id1438672766",
            LogoLink = "/projects/logos/appegada - Aplicativo dos Pets.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "appegada - Aplicativo dos Pets"
        },
        new()
        {
            Name = "Visual Mundo",
            Description =
                "Aplicativo de monitoramento com localização em tempo real, câmera remota e botão de pânico.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.visualmundo",
            AppStoreLink = "https://apps.apple.com/br/app/visual-mundo/id6448198200?l=en-GB",
            LogoLink = "/projects/logos/Visual Mundo.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "Visual Mundo"
        },
        new()
        {
            Name = "Sócio SRP",
            Description =
                "Aplicativo para associados com acesso a eventos, notícias e serviços da entidade.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=app.sociedaderural.com&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/us/app/s%C3%B3cio-srp/id6475786782",
            LogoLink = "/projects/logos/Sócio SRP.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "Sócio SRP"
        },
        new()
        {
            Name = "SyncJet",
            Description =
                "Aplicativo para gestão de aeronaves com agendamentos, relatórios e acompanhamento de voos.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=aero.sync&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/us/app/syncjet/id1532277655",
            LogoLink = "/projects/logos/SyncJet.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "SyncJet"
        },
        new()
        {
            Name = "ABCZ Mobile",
            Description =
                "Aplicativo oficial da ABCZ para consulta de animais, dados genéticos e informações do criador.",
            PlayStoreLink = "https://play.google.com/store/apps/details?id=br.com.abczmobile&hl=pt_BR",
            AppStoreLink = "https://apps.apple.com/us/app/novo-abcz-mobile/id1375811037",
            LogoLink = "/projects/logos/ABCZ Mobile.webp",
            IsCase = false,
            IsOwner = false,
            IsOpenCode = false,
            Client = "ABCZ Mobile"
        },
        // new()
        // {
        //     Name = "XXXXXXXXXXXX",
        //     Description = "ccccccccccc",
        //     PlayStoreLink = "aaaaaaaaa",
        //     AppStoreLink = "bbbbbbbbbb",
        //     LogoLink = "/projects/logos/XXXXXXXXXXXX.webp",
        //     IsCase = false,
        //     IsOwner = false,
        //     IsOpenCode = false,
        //     Client = "XXXXXXXXXXXX"
        // },
    };
}