using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class Curso
    {

        private string nome;
        private int qtdVagas;
        private double notaCorte;
        private Fila candidatosSelecionados;
        private Fila filaEspera;

        public string Nome { get { return nome; } set { nome = value; } }
        public int QtdVagas
        {
            get { return qtdVagas; }
            set { qtdVagas = value; }
        }
        public double NotaCorte
        {
            get { return notaCorte; }
            set { notaCorte = value; }
        }

        public Curso(String nome, int qtdVagas)
        {
            this.nome = nome;
            this.qtdVagas = qtdVagas;
            this.candidatosSelecionados = new Fila();
            this.filaEspera = new Fila();
        }

        public Curso()
        {
            this.nome = "";
            this.qtdVagas = 0;
            this.candidatosSelecionados = new Fila();
            this.filaEspera = new Fila();
        }

        public Boolean InserirCandidato(Candidato candidato)
        {
            Boolean aprovado;
            if (!candidatosSelecionados.VerificaFilaCheia(QtdVagas))
            {
                candidatosSelecionados.Inserir(candidato);
                aprovado = true;
            }
            else
            {
                filaEspera.Inserir(candidato);
                aprovado = false;
            }
            return aprovado;
        }

        public void CalcularNotaCorte() { NotaCorte = candidatosSelecionados.UltimoCandidato().NotaMedia; }



        /*
                public override string ToString()
                {
                    string result = $"{_nome} {_mediaCurso:F2}\nSelecionados\n";

                    foreach (var candidato in _candidatosSelecionados)
                    {
                        result += $"{candidato.Nome} {candidato.NotaMedia:F2}\n";
                    }

                    result += "Fila de Espera\n";

                    foreach (var candidato in FilaEspera)
                    {
                        result += $"{candidato.Nome} {candidato.NotaMedia:F2}\n";
                    }

                    return result;
                }*/
    }
}
