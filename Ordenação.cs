using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPraticoAED.Classes
{
    internal class Ordenação
    {
        static public void QuicksortDecresc(List<Candidato> candidatos, int esq, int dir)
        {
            int i = esq, j = dir;
            double pivo = candidatos[(esq + dir) / 2].NotaMedia;

            while (i <= j)
            {
                while (candidatos[i].NotaMedia > pivo) { i++; }
                while (candidatos[j].NotaMedia < pivo) { j--; }
                if (i <= j)
                {
                    Candidato temp = candidatos[i];
                    candidatos[i] = candidatos[j];
                    candidatos[j] = temp;
                    i++; j--;
                }
            }

            if (esq < j) QuicksortDecresc(candidatos, esq, j);
            if (i < dir) QuicksortDecresc(candidatos, i, dir);
        }
    }
}