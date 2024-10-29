using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinhu
{
    class Pergaminhos
    {

        private List<string> conteudos;

        public Pergaminhos()
        {
            conteudos = new List<string> {
                //1
                "Pedro Álvares Cabral (Belmonte, 1467 ou 1468 – Santarém, 1520) foi um fidalgo, comandante militar, navegador e explorador português, creditado como o descobridor do Brasil.",
                
                //2
                "Descoberta ou descobrimento do Brasil refere-se à chegada dos portugueses ao território atualmente conhecido como Brasil. Este momento é muitas vezes entendido como sendo o do avistamento da terra que então denominaram por Ilha de Vera Cruz, nas imediações do Monte Pascoal, pela armada comandada por Pedro Álvares Cabral, ocorrida no dia 22 de abril de 1500. Esta descoberta inscreve-se nos chamados descobrimentos portugueses.",
               
                //3
                "Descobrimento do Brasil: os bastidores da viagem de 44 dias que levou Pedro Álvares Cabral ao país."
            };
        }

        public string LerPergaminho(int indice)
        {
            return conteudos[indice];
        }
    }
}
