﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class Fila
    {
        private Celula primeiro, ultimo;
        public Fila()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }
        public void Inserir(Candidato candidato)
        {
            ultimo.Prox = new Celula(candidato);
            ultimo = ultimo.Prox;
        }
        public Candidato Remover()
        {
            if (primeiro == ultimo) throw new Exception("Filha vazia");
            Celula tmp = primeiro;
            primeiro = primeiro.Prox;
            Candidato candidato = primeiro.Candidato;
            tmp.Prox = null;
            tmp = null;
            return candidato;
        }

        public Boolean VerificaFilaCheia(int maximo)
        {
            Boolean cheia = false;
            int tamanho = 0;
            for (Celula i = primeiro.Prox; i != null; i = i.Prox) tamanho++;
            if(tamanho >= maximo) { cheia = true; }
            return cheia;
        }

        public Candidato UltimoCandidato() { return ultimo.Candidato; }

        public string Mostrar()
        {      
            StringBuilder stringCandidatos = new StringBuilder();
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                stringCandidatos.Append ($"\n{i.Candidato.Nome} {i.Candidato.NotaMedia.ToString("F2")}");
            }
            return stringCandidatos.ToString();
        }
    }
}
