using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    internal class Celula
    {
        private Candidato candidato;
        private Celula prox;

        public Celula(Candidato candidato)
        {
            this.candidato = candidato;
            this.prox = null;
        }

        public Celula()
        {
            this.candidato = null;
            this.prox = null;
        }

        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }

        public Candidato Candidato
        {
            get { return candidato; }
            set { candidato = value; }
        }
    }
}
