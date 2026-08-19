using arkanbank.Models;

namespace arkanbank.Data;

public static class StoreTable {

    public static readonly IReadOnlyDictionary<string, StoreItem> Items =
        new Dictionary<string, StoreItem>(StringComparer.OrdinalIgnoreCase) {
            // ======================================================
            // DICAS
            // ======================================================

            ["hint"] = new() {
                Id = "hint",
                Name = "Comprar Dica",
                Description = "Receba 1 dica exclusiva que pode ajudar você a descobrir o caminho para resolver um nível do ARG Desafio JXVII.\n\nA dica foi criada para orientar você sem entregar imediatamente a solução, mantendo parte do desafio e da diversão.",
                Category = StoreCategory.Hint,
                Price = 30,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF"
            },

            // ======================================================
            // EXPERIÊNCIAS
            // ======================================================

            ["bombom"] = new() {
                Id = "bombom",
                Name = "Caixa de Bombons",
                Description = "Receba 1 caixa de bombons para adoçar a sua experiência.\nA caixa poderá ser de marcas como Bis, KitKat, Garoto, Hershey's ou similares, de acordo com a disponibilidades.\n\nA marca e os sabores podem variar. Caso uma das opções mencionadas não esteja disponível, será enviada uma alternativa de qualidade semelhante.",
                Category = StoreCategory.Experience,
                Price = 50,
                Emoji = "🍫",
                IconBackground = "#FFF2F4"
            },

            ["pizza"] = new() {
                Id = "pizza",
                Name = "Pizza",
                Description = "Receba 1 pizza.\nNada melhor do que uma boa pizza para deixar o dia ainda melhor! Ao adquirir este produto, você receberá uma pizza deliciosa, com sabor e opções definidos de acordo com à disponibilidade.",
                Category = StoreCategory.Experience,
                Price = 70,
                Emoji = "🍕",
                IconBackground = "#FFF5E5"
            },

            ["nightgame"] = new() {
                Id = "nightgame",
                Name = "Noite de Jogos",
                Description = "Receba uma experiência de noite de jogos para reunir pessoas e aproveitar uma seleção de jogos de tabuleiro, puzzles e card games.\n\nA experiência inclui uma noite de diversão com diferentes opções de jogos para escolher e jogar ao longo do encontro.",
                Category = StoreCategory.Experience,
                Price = 70,
                Emoji = "🎲",
                IconBackground = "#EEF8FF"
            },

            ["cinema"] = new() {
                Id = "cinema",
                Name = "Cinema",
                Description = "Receba ingressos para assistir a 1 filme no cinema local.\n\nO filme pode ser da sua escolha, de acordo com os filmes disponíveis em cartaz.",
                Category = StoreCategory.Experience,
                Price = 90,
                Emoji = "🍿",
                IconBackground = "#EEF8FF"
            },

            ["kart"] = new() {
                Id = "kart",
                Name = "Corrida de Kart",
                Description = "Receba 1 bateria de kart para você aproveitar a pista e sentir a adrenalina de pilotar.\n\nA experiência inclui uma sessão para andar de kart em um kartódromo, com tempo de pista conforme as regras e condições do local.",
                Category = StoreCategory.Experience,
                Price = 100,
                Emoji = "🏎️",
                IconBackground = "#EEF8FF"
            },

            ["picnic"] = new() {
                Id = "picnic",
                Name = "Picnic",
                Description = "Receba uma experiência de picnic para aproveitar um momento ao ar livre em um dos locais disponíveis, como o Parque do Rangedor ou Viveiro Tracoá.\n\nA experiência inclui uma estrutura preparada para o picnic, com tempo de permanência conforme as regras e condições do local.",
                Category = StoreCategory.Experience,
                Price = 90,
                Emoji = "🧺",
                IconBackground = "#EEF8FF"
            },

            ["ciclismo"] = new() {
                Id = "ciclismo",
                Name = "Passeio Ciclístico",
                Description = "Receba uma experiência de ciclismo para você aproveitar um passeio de bicicleta ao ar livre em um dos locais disponíveis, como a orla de São Luís, o Parque do Rangedor ou o Parque Itapiracó.\n\nA experiÊncia inclui um passeio ciclístico pelo local escolhido, com duração conforme as regras e condições do local.",
                Category = StoreCategory.Experience,
                Price = 70,
                Emoji = "🚴🏻",
                IconBackground = "#EEF8FF"
            },

            ["patinete"] = new() {
                Id = "patinete",
                Name = "Passeio de Patinete Elétrica",
                Description = "Receba uma experiência de patinete elétrica (e afins) para você percorrer o Espigão de São Luís e aproveitar o passeio ao ar livre.\n\nA experiência proporciona um percurso de patinete pela região, com duração definida de acordo com a atividade.",
                Category = StoreCategory.Experience,
                Price = 70,
                Emoji = "🛴",
                IconBackground = "#EEF8FF"
            },

            ["trip"] = new() {
                Id = "trip",
                Name = "Passeio Antiestresse",
                Description = "Tá precisando esquecer os problemas por um momento? Então esse é o passeio certo para você!\n\nO passeio Antiestresse é uma experiência pensada para sair da rotina, respirar um pouco de ar fresco e ir para um lugar tranquilo, longe da correria e das preocupações do dia a dia. Um momento para relaxar a cabeça, aliviar o estresse. recarregar as energias e simplismente aproveitar a paz.",
                Category = StoreCategory.Experience,
                Price = 80,
                Emoji = "🧘🏻‍",
                IconBackground = "#EEF8FF"
            },

            ["museu"] = new() {
                Id = "museu",
                Name = "Passeio no Museu",
                Description = "Receba uma experiência cultural para você conhecer um dos museus disponíveis em São Luís.\n\nA experiÊncia inclui a entrada e a visita ao espaço escolhido, com acesso às exposições e acervo disponíveis no local, conforme as regras e condições de visitação.",
                Category = StoreCategory.Experience,
                Price = 70,
                Emoji = "🖼️",
                IconBackground = "#EEF8FF"
            },

            ["coringa"] = new() {
                Id = "coringa",
                Name = "Um Pedido Seu...",
                Description = "Receba um pedido coringa para escolher uma experiência diferente das opções disponíveis.\n\nVocê poderá definir o que deseja pedir, desde que seja uma experiência viável de realizar e combinada previamente.",
                Category = StoreCategory.Experience,
                Price = 500,
                Emoji = "❓",
                IconBackground = "#EEF8FF"
            },

            // ======================================================
            // FUNCIONALIDADES
            // ======================================================

            ["spinner"] = new() {
                Id = "spinner",
                Name = "Fidget Spinner",
                Description = "Desbloquear um minigame antiestresse permanentemente.",
                Category = StoreCategory.Feature,
                Price = 40,
                Icon = "\uf863",
                IconBackground = "#EEF8FF"
            }
        };
}