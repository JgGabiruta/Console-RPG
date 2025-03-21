using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    public static class RpgHelper
    {
        public static Personagem CriarPersonagem(int op)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine("Digite o nome do seu personagem:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Quantos anos ele tem?");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por fim qual seu nome?");
                    string nomej = Console.ReadLine();
                    Personagem p = new Personagem(nome, idade, nomej);
                    return p;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Adeus");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Resposta inválida");
                    break;
            }
            return null;
        }
        public static void Intro()
        {
            Console.WriteLine("Você é um jovem aventureiro em um reino ameaçado pelas forças das trevas. Seu objetivo é encontrar a lendária Espada da Verdade, a única capaz de derrotar o mal que se aproxima. Nesta jornada, suas escolhas determinarão seu destino.\r\n\r\n");
        }
        public static void Ato1(Personagem p)
        {
            int op;
            Console.WriteLine($"{p.NomePersonagem} chega em uma encruzilhada em uma estrada antiga. Dois caminhos se apresentam diante de você:\n 1- Caminho da Floresta Sombria: Rumores dizem que criaturas mágicas e perigos ocultos habitam esse local \n 2 - Caminho para a Cidade Abandonada: Uma antiga cidade que guarda segredos do passado e pistas sobre a espada. \n Digite o número correspondente as opções 1 ou 2");
            op = int.Parse(Console.ReadLine());
            

        }
        public static void Ato2()
        {

        }
        public static void Conclusão()
        {

        }
    }
}
