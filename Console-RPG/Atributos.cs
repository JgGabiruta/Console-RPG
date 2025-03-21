using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    public class Atributos
    {
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Inteligence { get; set; }
        public Atributos() 
        {
            Str = 1;
            Dex = 1;
            Inteligence = 1;
            MostrarAtributos(Str, Dex, Inteligence);
        }
        public void MostrarAtributos(int str, int dex, int intel)
        {
            Console.WriteLine($"Força: {str} \nDestreza: {dex} \nInteligência: {intel}");
        }
    }
}
