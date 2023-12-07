using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{

    public class ManipularArquivo
    {

        public static void LerArquivo(string caminho, List<Curso> cursos, List<Candidato> candidatos, Dictionary<int, String> DicionarioCursos)
        {
            try
            {
                StreamReader arquivo = new StreamReader(caminho, Encoding.UTF8);
                string[] dadosCursos = arquivo.ReadLine().Split(';');
                int qtdCursos = int.Parse(dadosCursos[0]);

                for (int i = 0; i < qtdCursos; i++)
                {
                    string[] dadosCurso = arquivo.ReadLine().Split(';');
                    DicionarioCursos.Add(int.Parse(dadosCurso[0]), dadosCurso[1]);
                    Curso curso = new Curso(dadosCurso[1], int.Parse(dadosCurso[2]));
                    cursos.Add(curso);
                }

                int qtdCandidatos = int.Parse(dadosCursos[1]);
                for (int i = 0; i < qtdCandidatos; i++)
                {
                    string[] dadosCandidato = arquivo.ReadLine().Split(';');
                    Candidato candidato = new Candidato(dadosCandidato[0], double.Parse(dadosCandidato[1]), double.Parse(dadosCandidato[2]),
                                                    double.Parse(dadosCandidato[3]), int.Parse(dadosCandidato[4]), int.Parse(dadosCandidato[5]));
                    candidatos.Add(candidato);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um erro ao ler arquivo de texto: {erro.Message}");
            }
        }
    }
}