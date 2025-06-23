internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- Noite de Terror ---");

        int dia, mes;

        Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");

        while (!int.TryParse(Console.ReadLine(), out dia) || dia <= 0 || dia > 31)
        {
            Console.Write("Número Inválido. Tente um número entre 1 e 31: ");
        }

        Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");

        while (!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12)
        {
            Console.Write("Número Inválido. Tente um número entre 1 e 12: ");
        }

        string[] mesMonstros = {
            "", "O Zumbi", "O Assassino", "O Psicopata", "O Alienígena",
            "O Carniceiro","O Matador", "O Vampiro", "O Maluco",
            "O Vingador", "O Monstro","O Bruxo", "O Demônio"
        };

        string[] diaSobrenome =
        {
             "", "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído",
             "Macabro", "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente",
             "Oculto", "Esquecido", "Lúgubre", "Invocado", "Caído", "Costurado",
             "Amaldiçoado", "Anormal", "Perturbado", "Sanguinário", "Tenebroso",
             "Imortal", "Ressuscitado", "do Pântano", "da Encruzilhada", "do Porão",
             "do Velho Poço", "sem Perdão", "do Cemitério", "da Meia-Noite", "da Lua Cheia"
        };


        string nomeMonstro = mesMonstros[mes];
        string sobrenome = diaSobrenome[dia];
        Console.WriteLine($"\nFuja! Lá vem {nomeMonstro} {sobrenome}!");
    }
}