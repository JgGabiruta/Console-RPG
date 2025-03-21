using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    public class Personagem
    {
        public int Level { get; set; }
        public string NomePersonagem { get; set; }
        public string NomeJogador { get; set; }
        public int Idade { get; set; }
        public Atributos Caracteristicas { get; set; }
        public Personagem(string nomeP, int idade, string nomeJ)
        {
            Level = 1;
            NomePersonagem = nomeP;
            NomeJogador = nomeJ;
            Idade = idade;
            MostrarPersonagem();
            Caracteristicas = new Atributos();
        }
        public void MostrarPersonagem()
        {
            Console.WriteLine($"Nome do personagem: {NomePersonagem} \nNome do jogador: {NomeJogador} \nIdade: {Idade} anos");
        }
        
    }
}
