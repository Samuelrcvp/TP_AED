using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    internal class Fila
    {
        private Celula primeiro, ultimo;
        public Fila()
        {
            primeiro = new Celula(); //nó cabeça
            ultimo = primeiro;
        }
        public void Inserir(Candidato candidato)
        {
            ultimo.Prox = new Celula(candidato);
            ultimo = ultimo.Prox;
        }
        public Candidato Remover()
        {
            if (primeiro == ultimo)
                throw new Exception("Pilha vazia");
            Celula tmp = primeiro;
            primeiro = primeiro.Prox;
            Candidato candidato = primeiro.Candidato;
            tmp.Prox = null;
            tmp = null;
            return candidato;
        }
    }
}