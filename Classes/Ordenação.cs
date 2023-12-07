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
            double pivoMedia = candidatos[(esq + dir) / 2].NotaMedia;
            double pivoRedacao = candidatos[(esq + dir) / 2].NotaRedacao;

            while (i <= j)
            {
                while (candidatos[i].NotaMedia > pivoMedia || (candidatos[i].NotaMedia == pivoMedia && candidatos[i].NotaRedacao > pivoRedacao)) { i++; }
                while (candidatos[j].NotaMedia < pivoMedia || (candidatos[j].NotaMedia == pivoMedia && candidatos[j].NotaRedacao < pivoRedacao)) { j--; }
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
