using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class ManipularArquivo
    {

        public void LerArquivo(string caminho)
        {
            try
            {
                StreamReader arquivoLeitura = new StreamReader(caminho, Encoding.UTF8);
                string[] dadoslinha1 = arquivoLeitura.ReadLine().Split(';');

                int qtdCursos = int.Parse(dadoslinha1[0]);

                for (int i = 0; i < qtdCursos; i++)
                {
                    string[] dadosCurso = arquivoLeitura.ReadLine().Split(';');

                    int codigoCurso = int.Parse(dadosCurso[0]);
                    string nomeCurso = dadosCurso[1];
                    int qtdVagas = int.Parse(dadosCurso[2]);

                    CriarCurso(codigoCurso, nomeCurso, qtdVagas);
                    
                }

                int qtdCandidatos = int.Parse(dadoslinha1[1]);
                for (int i = 0; i < qtdCandidatos; i++)
                {
                    string[] dadosCandidato = arquivoLeitura.ReadLine().Split(';');

                    string nomeCandidato = dadosCandidato[0];
                    double notaRedacao = double.Parse(dadosCandidato[1]);
                    double notaMatematica = double.Parse(dadosCandidato[2]);
                    double notaLinguagens = double.Parse(dadosCandidato[3]);
                    int opcaoCurso1 = int.Parse(dadosCandidato[4]);
                    int opcaoCurso2 = int.Parse(dadosCandidato[5]);
                    CriarCandidato(nomeCandidato, notaRedacao, notaMatematica, notaLinguagens, opcaoCurso1, opcaoCurso2);
                    
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Ocorreu um erro ao ler arquivo de texto: {erro.Message}");
            }
        }

        public void CriarCurso(int codigoCurso, string nomeCurso, int qtdVagas)
        {
            Curso curso = new Curso(nomeCurso, qtdVagas);

            App.DicionarioCursos.Add(codigoCurso, curso);
            App.Cursos.Add(curso);

        }

        public void CriarCandidato(string nomeCandidato, double notaRedacao, double notaMatematica,
                                    double notaLinguagens, int opcaoCurso1, int opcaoCurso2)
        {
            Candidato candidato = new Candidato(nomeCandidato, notaRedacao, notaMatematica, notaLinguagens, opcaoCurso1, opcaoCurso2);
                                         
            App.Candidatos.Add(candidato);

        }


        public void OrdenarListaGeral()
        {
            Ordenação.QuicksortDecresc(App.Candidatos, 0, App.Candidatos.Count - 1);
        }
    }
}
