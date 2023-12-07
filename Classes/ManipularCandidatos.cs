using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPraticoAED.Classes;

namespace TrabAED.Classes
{
    public class ManipularCandidatos
    {
        private static List<Candidato> candidatos;
        private static List<Curso> cursos;
        private static Dictionary<int, Curso> dicionarioCursos;

        public ManipularCandidatos()
        {
            candidatos = App.Candidatos;
            cursos = App.Cursos;
            dicionarioCursos = App.DicionarioCursos;
        }

        public void SelecionarAprovados()
        {
            foreach (Candidato candidato in candidatos)
            {
                Curso curso = ObterCodCurso(candidato.CodOpcao1);
                if (!curso.InserirCandidato(candidato))
                {
                    curso = ObterCodCurso(candidato.CodOpcao2);
                    curso.InserirCandidato(candidato);
                }
            }
        }

        private Curso ObterCodCurso(int codigo)
        {
            if (dicionarioCursos.ContainsKey(codigo))
            {
                return dicionarioCursos[codigo];
            }

            return null;
        }

        public void CalcularNotaCorte()
        {
            foreach (Curso curso in cursos) { curso.CalcularNotaCorte(); }
        }

    }
}