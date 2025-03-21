namespace Console_RPG
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Olá seja bem vindo! Esse é um jogo de rpg deseja criar seu personagem agora?\n digite 1 - sim e 2 - não");
            int op = int.Parse(Console.ReadLine());
            Personagem p = RpgHelper.CriarPersonagem(op);
            RpgHelper.Intro();
            RpgHelper.Ato1(p);
        }
    }
}
