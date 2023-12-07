﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class Candidato
    {
        /*  Atributos  */
        private string nome;
        private double notaRedacao;
        private double notaMatematica;
        private double notaLinguagens;
        private double notaMedia;
        private int codOpcao1;
        private int codOpcao2;

        /*  Propriedades  */

        public string Nome
        {
            get { return nome; }
        }
        public double NotaRedacao
        {
            get { return notaRedacao; }
        }
        public double NotaMatematica
        {
            get { return notaMatematica; }
        }
        public double NotaLinguagens
        {
            get { return notaLinguagens; }
        }
        public double NotaMedia
        {
            get { return notaMedia; }
        }
        public int CodOpcao1
        {
            get { return codOpcao1; }
        }
        public int CodOpcao2
        {
            get { return codOpcao2; }
        }

        /*  Construtor  */

        public Candidato(string nome, double notaRedacao, double notaMatematica, double notaLinguagens,
                         int codOpcao1, int codOpcao2)
        {
            this.nome = nome;
            this.notaRedacao = notaRedacao;
            this.notaMatematica = notaMatematica;
            this.notaLinguagens = notaLinguagens;
            this.codOpcao1 = codOpcao1;
            this.codOpcao2 = codOpcao2;
            notaMedia = Math.Round((notaMatematica + notaLinguagens + notaRedacao) / 3, 2);
        }

        public override string ToString()
        {
            return $"Nome: {nome}\n" +
                   $"Nota Redação: {notaRedacao}\n" +
                   $"Nota Matemática: {notaMatematica}\n" +
                   $"Nota Linguagens: {notaLinguagens}\n" +
                   $"Nota Média: {notaMedia}\n" +
                   $"Código Curso primeira Opção: {codOpcao1}\n" +
                   $"Código Curso segunda Opção: {codOpcao2}";
        }
    }
}