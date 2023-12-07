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

        public string Nome { get => nome;  set => nome = value; }

        public int QtdVagas{ get => qtdVagas;  set => qtdVagas = value; }

        public double NotaCorte{ get => notaCorte; set => notaCorte = value; }

        public Fila CandidatosSelecionados { get => candidatosSelecionados; }

        public Fila FilaEspera { get => filaEspera; }

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

        public bool InserirCandidato(Candidato candidato)
        {
            bool aprovado;
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

    }
}
