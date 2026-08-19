using arkanbank.Models;

namespace arkanbank.Data;

public static class InventoryTable {

    public static readonly IReadOnlyDictionary<string, InventoryItem> Items =
        new Dictionary<string, InventoryItem>(StringComparer.OrdinalIgnoreCase) {
            // ======================================================
            // DICAS
            // ======================================================

            ["JXVII-IVTY-0001"] = new() {
                Id = "JXVII-IVTY-0001",
                Reference = "41821",
                Name = "Dica do Nível 1",
                Description = "Uma dica para o nível 1",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Você acabou de gastar dinheiro para descobrir algo que provavelmente já sabia.\nMas tudo bem. Acho que o ARKAN Bank agradece a sua movimentação financeira. 💰\n\nAgora a dica de verdade:\n\nOs primeiros passos existem para ensinar o caminho. Não procure mensagens ocultas ainda. Leia novamente o título, a página e tudo o que foi apresentado desde o início."
            },

            ["JXVII-IVTY-0002"] = new() {
                Id = "JXVII-IVTY-0002",
                Reference = "73994",
                Name = "Dica do Nível 2",
                Description = "Uma dica para o nível 2",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Esta dica não possui reembolso. 💰\n\nAgora, falando sério:\n\nAumente o brilho da tela e examine a página inteira com calma. Algumas coisas nunca estiveram escondidas. Você só precisava enxergá-las."
            },

            ["JXVII-IVTY-0003"] = new() {
                Id = "JXVII-IVTY-0003",
                Reference = "12603",
                Name = "Dica do Nível 3",
                Description = "Uma dica para o nível 3",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Parabéns. Você acaba de financiar mais uma etapa deste projeto. 💰\n\nEm troca, receba esta informação confidencial:\n\nQuando uma mensagem parece escrita em um idioma estranho, talvez o problema não seja a mensagem... talvez seja apenas o alfabeto que você está usando."
            },

            ["JXVII-IVTY-0004"] = new() {
                Id = "JXVII-IVTY-0004",
                Reference = "83742",
                Name = "Dica do Nível 4",
                Description = "Uma dica para o nível 4",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Parabéns!\n\nVocê pagou para descobrir que alguém bagunçou algumas letras. 💰\n\nNem sempre é preciso procurar mais. Às vezes basta reorganizar o que você já encontrou."
            },

            ["JXVII-IVTY-0005"] = new() {
                Id = "JXVII-IVTY-0005",
                Reference = "51486",
                Name = "Dica do Nível 5",
                Description = "Uma dica para o nível 5",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Obrigado por confiar novamente no ARKAN Bank. Seu saldo diminuiu, mas seu conhecimento aumentou (provavelmente).\n\nAgora a dica:\n\nNem todo caminho leva a um lugar físico.\nNa internet, uma URI funciona como um endereço para encontrar algo.\nTalvez a próxima descoberta esteja no caminho certo."
            },

            ["JXVII-IVTY-0006"] = new() {
                Id = "JXVII-IVTY-0006",
                Reference = "26591",
                Name = "Dica do Nível 6",
                Description = "Uma dica para o nível 6",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Parabéns. Você decidiu gastar um pouco. 💰\n\nJá que chegou até aqui, vou facilitar sua vida:\npode usar a Cifra de César.\n\nAgora falta descobrir o deslocamento."
            },

            ["JXVII-IVTY-0007"] = new() {
                Id = "JXVII-IVTY-0007",
                Reference = "90347",
                Name = "Dica do Nível 7",
                Description = "Uma dica para o nível 7",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Dica comprada com seu suado dinheirinho. 💰\n\nAgora, a dica de verdade:\nProcure na Bíblia um livro que tenha exatamente essa quantidade de capítulos.\n\nDepois, siga o restante do código na ordem indicada pela instrução escondida na tela da fase."
            },

            ["JXVII-IVTY-0008"] = new() {
                Id = "JXVII-IVTY-0008",
                Reference = "18735",
                Name = "Dica do Nível 8",
                Description = "Uma dica para o nível 8",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Uma dica comprada! 💰\n\nAgora presta atenção na pergunta:\n\"Quem é você?\"\n\nTalvez a resposta não seja tão complicada assim. 😉"
            },

            ["JXVII-IVTY-0009"] = new() {
                Id = "JXVII-IVTY-0009",
                Reference = "64812",
                Name = "Dica do Nível 9",
                Description = "Uma dica para o nível 9",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Tá bom, tá bom... vou te dar uma ajudinha. 💰\n\nIsso aí não é uma senha aleatória.\nÉ uma sequência codificada em Base 64.\n\nDecodifique e descubra o que tem escondido..."
            },

            ["JXVII-IVTY-0010"] = new() {
                Id = "JXVII-IVTY-0010",
                Reference = "45193",
                Name = "Dica do Nível 10",
                Description = "Uma dica para o nível 10",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Essas datas estão tentando te contar alguma coisa. 🔎\n\nEscolha uma delas e pesquise.\nDepois faça o mesmo com as outras.\n\nTalvez você encontre algo acontecendo no céu."
            },

            ["JXVII-IVTY-0011"] = new() {
                Id = "JXVII-IVTY-0011",
                Reference = "23064",
                Name = "Dica do Nível 11",
                Description = "Uma dica para o nível 11",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "O som não é apenas um som.\n\nTalvez você já tenha encontrado esse código antes.\n\nDescubra o que está sendo transmitido antes de tentar descobrir por que essa palavra foi escolhida."
            },

            ["JXVII-IVTY-0012"] = new() {
                Id = "JXVII-IVTY-0012",
                Reference = "97518",
                Name = "Dica do Nível 12",
                Description = "Uma dica para o nível 12",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Os números não precisam ser calculados.\n\nProcure por eles em uma tabela onde cada número representa um elemento.\n\nDepois, observe os símbolos."
            },

            ["JXVII-IVTY-0013"] = new() {
                Id = "JXVII-IVTY-0013",
                Reference = "36470",
                Name = "Dica do Nível 13",
                Description = "Uma dica para o nível 13",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Dessa vez você recebeu dois números.\n\nEles representam um lugar no mundo.\nDescubra onde essas coordenadas levam você.\n\nDepois procure o que existe lá."
            },

            ["JXVII-IVTY-0014"] = new() {
                Id = "JXVII-IVTY-0014",
                Reference = "52814",
                Name = "Dica do Nível 14",
                Description = "Uma dica para o nível 14",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0015"] = new() {
                Id = "JXVII-IVTY-0015",
                Reference = "81467",
                Name = "Dica do Nível 15",
                Description = "Uma dica para o nível 15",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0016"] = new() {
                Id = "JXVII-IVTY-0016",
                Reference = "19326",
                Name = "Dica do Nível 16",
                Description = "Uma dica para o nível 16",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "As palavras estão mais embaralhadas do que deveriam. 🔀\n\nExperimente reorganizar as letras.\n\nTalvez cada linha esteja escondendo uma palavra diferente."
            },

            ["JXVII-IVTY-0017"] = new() {
                Id = "JXVII-IVTY-0017",
                Reference = "67205",
                Name = "Dica do Nível 17",
                Description = "Uma dica para o nível 17",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0018"] = new() {
                Id = "JXVII-IVTY-0018",
                Reference = "34158",
                Name = "Dica do Nível 18",
                Description = "Uma dica para o nível 18",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0019"] = new() {
                Id = "JXVII-IVTY-0019",
                Reference = "78243",
                Name = "Dica do Nível 19",
                Description = "Uma dica para o nível 19",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0020"] = new() {
                Id = "JXVII-IVTY-0020",
                Reference = "15609",
                Name = "Dica do Nível 20",
                Description = "Uma dica para o nível 20",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0021"] = new() {
                Id = "JXVII-IVTY-0021",
                Reference = "89572",
                Name = "Dica do Nível 21",
                Description = "Uma dica para o nível 21",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0022"] = new() {
                Id = "JXVII-IVTY-0022",
                Reference = "27431",
                Name = "Dica do Nível 22",
                Description = "Uma dica para o nível 22",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0023"] = new() {
                Id = "JXVII-IVTY-0023",
                Reference = "63895",
                Name = "Dica do Nível 23",
                Description = "Uma dica para o nível 23",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0024"] = new() {
                Id = "JXVII-IVTY-0024",
                Reference = "42073",
                Name = "Dica do Nível 24",
                Description = "Uma dica para o nível 24",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0025"] = new() {
                Id = "JXVII-IVTY-0025",
                Reference = "91754",
                Name = "Dica do Nível 25",
                Description = "Uma dica para o nível 25",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0026"] = new() {
                Id = "JXVII-IVTY-0026",
                Reference = "18562",
                Name = "Dica do Nível 26",
                Description = "Uma dica para o nível 26",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0027"] = new() {
                Id = "JXVII-IVTY-0027",
                Reference = "70381",
                Name = "Dica do Nível 27",
                Description = "Uma dica para o nível 27",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "Você já tem a ferramenta necessária.\n\nProcure entre os aplicativos que já conhece.\n\nE lembre-se: sete vezes não é uma sugestão. 😉"
            },

            ["JXVII-IVTY-0028"] = new() {
                Id = "JXVII-IVTY-0028",
                Reference = "26947",
                Name = "Dica do Nível 28",
                Description = "Uma dica para o nível 28",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0029"] = new() {
                Id = "JXVII-IVTY-0029",
                Reference = "54893",
                Name = "Dica do Nível 29",
                Description = "Uma dica para o nível 29",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0030"] = new() {
                Id = "JXVII-IVTY-0030",
                Reference = "81235",
                Name = "Dica do Nível 30",
                Description = "Uma dica para o nível 30",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0031"] = new() {
                Id = "JXVII-IVTY-0031",
                Reference = "13748",
                Name = "Dica do Nível 31",
                Description = "Uma dica para o nível 31",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0032"] = new() {
                Id = "JXVII-IVTY-0032",
                Reference = "96420",
                Name = "Dica do Nível 32",
                Description = "Uma dica para o nível 32",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0033"] = new() {
                Id = "JXVII-IVTY-0033",
                Reference = "38615",
                Name = "Dica do Nível 33",
                Description = "Uma dica para o nível 33",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = "As notas já estão na ordem certa.\n\nAgora pense em como essas mesmas notas são escritas em notação musical internacional.\n\nDepois, leia o que elas formam."
            },

            ["JXVII-IVTY-0034"] = new() {
                Id = "JXVII-IVTY-0034",
                Reference = "57091",
                Name = "Dica do Nível 34",
                Description = "Uma dica para o nível 34",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0035"] = new() {
                Id = "JXVII-IVTY-0035",
                Reference = "24968",
                Name = "Dica do Nível 35",
                Description = "Uma dica para o nível 35",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0036"] = new() {
                Id = "JXVII-IVTY-0036",
                Reference = "61843",
                Name = "Dica do Nível 36",
                Description = "Uma dica para o nível 36",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0037"] = new() {
                Id = "JXVII-IVTY-0037",
                Reference = "79451",
                Name = "Dica do Nível 37",
                Description = "Uma dica para o nível 37",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0038"] = new() {
                Id = "JXVII-IVTY-0038",
                Reference = "32584",
                Name = "Dica do Nível 38",
                Description = "Uma dica para o nível 38",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0039"] = new() {
                Id = "JXVII-IVTY-0039",
                Reference = "48370",
                Name = "Dica do Nível 39",
                Description = "Uma dica para o nível 39",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0040"] = new() {
                Id = "JXVII-IVTY-0040",
                Reference = "15826",
                Name = "Dica do Nível 40",
                Description = "Uma dica para o nível 40",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0041"] = new() {
                Id = "JXVII-IVTY-0041",
                Reference = "64195",
                Name = "Dica do Nível 41",
                Description = "Uma dica para o nível 41",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0042"] = new() {
                Id = "JXVII-IVTY-0042",
                Reference = "82713",
                Name = "Dica do Nível 42",
                Description = "Uma dica para o nível 42",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            ["JXVII-IVTY-0043"] = new() {
                Id = "JXVII-IVTY-0043",
                Reference = "39264",
                Name = "Dica do Nível 43",
                Description = "Uma dica para o nível 43",
                Category = InventoryCategory.Hint,
                Icon = "\uf0eb",
                IconBackground = "#E8FAFF",
                Value = ""
            },

            // ======================================================
            // FUNCIONALIDADES
            // ======================================================

            ["spinner"] = new() {
                Id = "spinner",
                Name = "Fidget Spinner",
                Description = "Um minigame desestressante desbloqueado permanentemente.",
                Category = InventoryCategory.Feature,
                Icon = "\uf863",
                IconBackground = "#EEF8FF"
            },

            // ======================================================
            // EXPERIÊNCIAS
            // ======================================================

            ["bombom"] = new() {
                Id = "bombom",
                Name = "Caixa de Bombons",
                Description = "Uma caixa de bombons recebida.",
                Category = InventoryCategory.Experience,
                Emoji = "🍫",
                IconBackground = "#FFF2F4"
            },

            ["pizza"] = new() {
                Id = "pizza",
                Name = "Pizza",
                Description = "Uma pizza recebida.",
                Category = InventoryCategory.Experience,
                Emoji = "🍕",
                IconBackground = "#FFF5E5"
            },

            ["cinema"] = new() {
                Id = "cinema",
                Name = "Cinema",
                Description = "Uma sessão de um filme no cinema recebida.",
                Category = InventoryCategory.Experience,
                Emoji = "🍿",
                IconBackground = "#EEF8FF"
            },

            ["kart"] = new() {
                Id = "kart",
                Name = "Corrida de Kart",
                Description = "Uma corrida de kart realizada.",
                Category = InventoryCategory.Experience,
                Emoji = "🏎️",
                IconBackground = "#EEF8FF"
            },

            ["picnic"] = new() {
                Id = "picnic",
                Name = "Picnic",
                Description = "Uma experiência de picnic ao ar livre realizada.",
                Category = InventoryCategory.Experience,
                Emoji = "🧺",
                IconBackground = "#EEF8FF"
            },

            ["ciclismo"] = new() {
                Id = "ciclismo",
                Name = "Passeio Ciclístico",
                Description = "Um passeio ciclístico ao ar livre realizado.",
                Category = InventoryCategory.Experience,
                Emoji = "🚴🏻",
                IconBackground = "#EEF8FF"
            },

            ["trip"] = new() {
                Id = "trip",
                Name = "Passeio Antiestresse",
                Description = "Um passeio antiestresse realizado.",
                Category = InventoryCategory.Experience,
                Emoji = "🧘🏻‍",
                IconBackground = "#EEF8FF"
            },

            ["museu"] = new() {
                Id = "museu",
                Name = "Passeio no Museu",
                Description = "Um passeio no museu realizado.",
                Category = InventoryCategory.Experience,
                Emoji = "🖼️",
                IconBackground = "#EEF8FF"
            },

            ["patinete"] = new() {
                Id = "patinete",
                Name = "Passeio de Patinete elétrica",
                Description = "Um passeio de patinete elétrica realizado.",
                Category = InventoryCategory.Experience,
                Emoji = "🛴",
                IconBackground = "#EEF8FF"
            },

            ["nightgame"] = new() {
                Id = "nightgame",
                Name = "Noite de Jogos",
                Description = "Uma noite de jogos realizada.",
                Category = InventoryCategory.Experience,
                Emoji = "🎲",
                IconBackground = "#EEF8FF"
            },

            ["coringa"] = new() {
                Id = "coringa",
                Name = "Um pedido seu...",
                Description = "Uma pedido especial realizado.",
                Category = InventoryCategory.Experience,
                Emoji = "❓",
                IconBackground = "#EEF8FF"
            }
        };
}