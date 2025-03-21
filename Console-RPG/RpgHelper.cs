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
            do 
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
                
            } while (op != 1 && op != 2);
            return null;
        }
        public static void Intro(Personagem p)
        {
            Console.WriteLine("Você é um jovem aventureiro em um reino ameaçado pelas forças das trevas. Seu objetivo é encontrar a lendária Espada da Verdade, a única capaz de derrotar o mal que se aproxima. Nesta jornada, suas escolhas determinarão seu destino.\r\n\r\n");
            Ato1(p);
        }
        public static void Ato1(Personagem p)
        {
            int op;
            Console.WriteLine($"{p.NomePersonagem} chega em uma encruzilhada em uma estrada antiga. Dois caminhos se apresentam diante de você:\n 1- Caminho da Floresta Sombria: Rumores dizem que criaturas mágicas e perigos ocultos habitam esse local \n 2 - Caminho para a Cidade Abandonada: Uma antiga cidade que guarda segredos do passado e pistas sobre a espada. \n Digite o número correspondente as opções 1 ou 2");
            op = int.Parse(Console.ReadLine());
            do 
            {
                switch (op)
                {
                    case 1:
                        Caminho1(p);
                        break;
                    case 2:
                        Caminho2(p);
                        break;
                    default:
                        Console.WriteLine("Resposta inválida");
                        break;
                }
                
            } while (op != 1 && op != 2);

        }
        public static void Caminho1(Personagem p)
        {
            Console.WriteLine("Você escolheu o Caminho da Floresta Sombria. Ao adentrar a floresta, você se depara com um grupo de goblins que bloqueiam seu caminho. O que você fará?\n 1 - Lutar contra os goblins \n 2 - Tentar negociar com eles");
            int op = int.Parse(Console.ReadLine());
            do 
            { 
                switch(op)
                {
                    case 1:
                        LutarGoblins(p);
                        break;
                    case 2:
                        NegociarGoblins(p);
                        break;
                    default:
                        Console.WriteLine("Resposta inválida");
                        break;
                }
            } while (op != 1 && op != 2);

        }
        public static void LutarGoblins(Personagem p)
        {
            Console.WriteLine("Os goblins avançam para cima de você e você não recua com toda sua coragem você saca sua espada e parte pra cima deles");
            Console.WriteLine("Você luta bravamente contra os goblins, mas eles são muitos e você é forçado a recuar. Você consegue escapar da Floresta Sombria, mas não sem ferimentos. Você perdeu 1 ponto de vida.");
            PerdeVida(p, 1);

        }
        public static void NegociarGoblins(Personagem p)
        {
            Console.WriteLine("Você tenta negociar com os goblins e para a sua surpresa eles estão dispostos a negociar e logo apos alguns minutos eles lhe deixam passar. Você sobe de nivel!");
            p.Level++;

        }
        public static void Caminho2(Personagem p)
        {
            Console.WriteLine("Você escolheu o Caminho para a Cidade Abandonada. Ao chegar na cidade, você encontra um antigo templo em ruínas. Dentro do templo, você encontra um pergaminho antigo que contém um feitiço poderoso. O que você fará?\n 1 - Estudar o feitiço \n 2 - Ignorar o pergaminho e continuar sua jornada");
            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        EstudarFeitiço(p);
                        break;
                    case 2:
                        IgnorarFeitiço(p);
                        break;
                    default:
                        Console.WriteLine("Resposta inválida");
                        break;
                }
            } while (op != 1 && op != 2);
        }
        public static void EstudarFeitiço(Personagem p)
        {
            Console.WriteLine("Você estuda o feitiço e descobre que ele é uma poderosa magia de cura. Você aprende o feitiço e ganha 1 ponto de vida.");
            p.Vida++;
        }
        public static void IgnorarFeitiço(Personagem p)
        {
            Console.WriteLine("Você ignora o pergaminho e continua sua jornada. Você encontra um baú escondido com uma poção de cura. Você ganha 1 ponto de vida.");
            p.Vida++;
        }
        public static void LevelUp(Personagem p)
        {
            Console.WriteLine("Parabéns! Você subiu de nível e ganhou novos poderes e habilidades.");
            p.Level++;
            p.Caracteristicas.SubirAtributos();
        }
        public static void PerdeVida(Personagem p, int perda) 
        {
            p.Vida -= perda;
            p.MostrarVida();
        }
    }
}
