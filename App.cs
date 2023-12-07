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
            Dictionary<int, String> dicionarioCursos = new Dictionary<int, String>();

            ManipularArquivo.LerArquivo(@"..\..\..\ArquivoDeTexto\Arquivo.txt", cursos, candidatos, dicionarioCursos);
            Ordenação.QuicksortDecresc(candidatos, 0, candidatos.Count - 1);

            SelecionarAprovados(candidatos, cursos, dicionarioCursos);




            Console.ReadKey();
        }

        static void MostraNoConsole(List<Curso> cursos)
        {
            foreach (var curso in cursos)
            {
                Console.WriteLine("\n*-CURSO-*");
                // Console.WriteLine($"\nCod: {curso.Codigo}, Nome: {curso.Nome}, Vagas: {curso.QtdVagas}, Nota corte: {curso.NotaCorte}");
                Console.WriteLine("\nSelecionados:");
                /* foreach (Candidato candidatoSelecionado in curso.CandidatosSelecionados)
                 {
                     Console.WriteLine($"\nNome: {candidatoSelecionado.Nome}, Media :{candidatoSelecionado.NotaMedia}");
                 }
                 Console.WriteLine("0--------------------------------------------------------------------0");
                 Console.WriteLine("\nFila de Espera:");
                 foreach (Candidato candidatoNaFila in curso.FilaEspera)
                 {
                     Console.WriteLine($"\nNome: {candidatoNaFila.Nome}, Media :{candidatoNaFila.NotaMedia}");
                 }*/

                Console.WriteLine("  ");
            }
        }

        static void SelecionarAprovados(List<Candidato> candidatos, List<Curso> cursos, Dictionary<int, String> dicionarioCursos)
        {










        }
    }
}