using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinhu
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }
        public int Pontos { get; set; }

        public Pessoa(string nome)
        {

            Nome = nome;
            Vida = 100;
            Forca = 10;
            Pontos = 38;
            
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
        }
    }
}
    

