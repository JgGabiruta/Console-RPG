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
        public int Charisma { get; set; }
        public Atributos(int level) 
        {
            Str = level;
            Dex = level;
            Inteligence = level;
            Charisma = level;
            MostrarAtributos(Str, Dex, Inteligence, Charisma);
        }
        public void SubirAtributos()
        {
            Str++;
            Dex++;
            Inteligence++;
            Charisma++;
        }
        public void MostrarAtributos(int str, int dex, int intel, int charism)
        {
            Console.WriteLine($"Força: {str} \nDestreza: {dex} \nInteligência: {intel} \nCharisma: {charism}");
        }
    }
}
