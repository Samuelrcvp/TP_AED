using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPraticoAED.Classes;

namespace TrabalhoPraticoAED.Classes
{
    public class App
    {
        static void Main(string[] args)
        {
            List<Candidato> candidatos = new List<Candidato>();
            List<Curso> cursos = new List<Curso>();
            Dictionary<int, Curso> dicionarioCursos = new Dictionary<int, Curso>();

            ManipularArquivo.LerArquivo(@"..\..\..\ArquivoDeTexto\Arquivo.txt", cursos, candidatos, dicionarioCursos);
            Ordenação.QuicksortDecresc(candidatos, 0, candidatos.Count - 1);

            SelecionarAprovados(candidatos, dicionarioCursos);
            CalcularNotaCorte(cursos);

            Console.ReadKey();
        }

        static void SelecionarAprovados(List<Candidato> candidatos, Dictionary<int, Curso> dicionarioCursos)
        {
            Curso curso = new Curso();

            foreach (Candidato candidato in candidatos)
            {
                curso = dicionarioCursos[candidato.CodOpcao1];
                if (!curso.InserirCandidato(candidato))
                {
                    curso = dicionarioCursos[candidato.CodOpcao2];
                    curso.InserirCandidato(candidato);
                }
            }
        }

        private static void CalcularNotaCorte(List<Curso> cursos)
        {
            foreach(Curso curso in cursos) { curso.CalcularNotaCorte(); }
        }
    }
}
