using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabAED.Classes;
using TrabalhoPraticoAED.Classes;

namespace TrabalhoPraticoAED.Classes
{
    public class App
    {
        private static List<Candidato> candidatos;
        private static List<Curso> cursos;
        private static Dictionary<int, Curso> dicionarioCursos;

        public App()
        {
            candidatos = new List<Candidato>();
            cursos = new List<Curso>();
            dicionarioCursos = new Dictionary<int, Curso>();
        }

        public static List<Candidato> Candidatos { get => candidatos; set => candidatos = value; }
        public static List<Curso> Cursos { get => cursos; set => cursos = value; }
        public static Dictionary<int, Curso> DicionarioCursos { get => dicionarioCursos; set => dicionarioCursos = value; }

        static void Main(string[] args)
        {
            App app = new App();
            ManipularArquivo manipularArquivo = new ManipularArquivo();
            ManipularCandidatos manipularCandidatos = new ManipularCandidatos();
            
            manipularArquivo.LerArquivo(@"..\..\..\ArquivoDeTexto\Arquivo.txt");
            manipularArquivo.OrdenarListaGeral();

            manipularCandidatos.SelecionarAprovados();
            manipularCandidatos.CalcularNotaCorte();
                      
            CriarArquivoSaida();

            Console.ReadKey();
        }

        private static void CriarArquivoSaida()
        {
            string arquivoSaida = (@"..\..\..\ArquivoDeTexto\saida.txt");

            try
            {
                StreamWriter arqEscrita = new StreamWriter(arquivoSaida, false, Encoding.UTF8);

                foreach (Curso curso in cursos)
                {
                    arqEscrita.WriteLine($"{curso.Nome} {curso.NotaCorte}");
                    arqEscrita.WriteLine($"Selecionados {curso.CandidatosSelecionados.Mostrar()} ");
                    arqEscrita.WriteLine($"Fila de Espera {curso.FilaEspera.Mostrar()}\n");
                }
                
                arqEscrita.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um erro ao escrever arquivo de texto saída: {erro.Message}");
                throw;
            }
        }
    }
}
