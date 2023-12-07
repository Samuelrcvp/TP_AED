using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class Curso
    {
        /*  Atributos  */
        private string nome;
        private int qtdVagas;
        private double notaCorte;
        private Fila candidatosSelecionados = new Fila();
        private Fila filaEspera = new Fila();

        /*  Propriedades  */

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

        /*  Construtor  */

        public Curso(String nome, int qtdVagas)
        {
            this.nome = nome;
            this.qtdVagas = qtdVagas;
            this.candidatosSelecionados = null;
            this.filaEspera = null;
        }

        /*       public static void CalcularNotaCorte(List<Curso> cursos)
               {

                   foreach (Curso curso in cursos)
                   {
                       double somaMedia = 0.0;
                       int qtdCandidatosNoCurso = 0;

                       foreach (Candidato candidato in curso.CandidatosDoCurso)
                       {
                           somaMedia += candidato.NotaMedia;
                           qtdCandidatosNoCurso++;
                       }
                       if (qtdCandidatosNoCurso > 0)
                       {
                           curso.NotaCorte = Math.Round(somaMedia / qtdCandidatosNoCurso, 2);
                       }
                       else
                       {
                           curso.NotaCorte = 0.0;
                       }
                   }
               }

               public static void Selecionar(List<Curso> cursos)
               {
                   foreach (Curso curso in cursos)
                   {
                       foreach (Candidato candidato in curso.CandidatosDoCurso)
                       {
                           if (candidato.NotaMedia >= curso.NotaCorte)
                           {
                               if (candidato.CodOpcao1 == curso.Codigo)
                               {
                                   curso.CandidatosSelecionados.Enqueue(candidato);
                               }
                               else if (candidato.CodOpcao2 == curso.Codigo)
                               {
                                   curso.FilaEspera.Enqueue(candidato);
                               }
                               else
                               {
                                   curso.FilaEspera.Enqueue(candidato);
                               }
                           }
                           else
                           {
                               curso.FilaEspera.Enqueue(candidato);
                           }
                       }
                   }
               }*/

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    public class Curso
    {
        /*  Atributos  */
        private string nome;
        private int qtdVagas;
        private double notaCorte;
        private Fila candidatosSelecionados = new Fila();
        private Fila filaEspera = new Fila();

        /*  Propriedades  */

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

        /*  Construtor  */

        public Curso(String nome, int qtdVagas)
        {
            this.nome = nome;
            this.qtdVagas = qtdVagas;
            this.candidatosSelecionados = null;
            this.filaEspera = null;
        }

        /*       public static void CalcularNotaCorte(List<Curso> cursos)
               {

                   foreach (Curso curso in cursos)
                   {
                       double somaMedia = 0.0;
                       int qtdCandidatosNoCurso = 0;

                       foreach (Candidato candidato in curso.CandidatosDoCurso)
                       {
                           somaMedia += candidato.NotaMedia;
                           qtdCandidatosNoCurso++;
                       }
                       if (qtdCandidatosNoCurso > 0)
                       {
                           curso.NotaCorte = Math.Round(somaMedia / qtdCandidatosNoCurso, 2);
                       }
                       else
                       {
                           curso.NotaCorte = 0.0;
                       }
                   }
               }

               public static void Selecionar(List<Curso> cursos)
               {
                   foreach (Curso curso in cursos)
                   {
                       foreach (Candidato candidato in curso.CandidatosDoCurso)
                       {
                           if (candidato.NotaMedia >= curso.NotaCorte)
                           {
                               if (candidato.CodOpcao1 == curso.Codigo)
                               {
                                   curso.CandidatosSelecionados.Enqueue(candidato);
                               }
                               else if (candidato.CodOpcao2 == curso.Codigo)
                               {
                                   curso.FilaEspera.Enqueue(candidato);
                               }
                               else
                               {
                                   curso.FilaEspera.Enqueue(candidato);
                               }
                           }
                           else
                           {
                               curso.FilaEspera.Enqueue(candidato);
                           }
                       }
                   }
               }*/

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