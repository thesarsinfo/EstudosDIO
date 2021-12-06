using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleExemploLinQ.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            foreach (var estado in lista)
            {
                System.Console.WriteLine(estado);
            }
        }
        public void DeletarListaString(List<string> lista)
        {
            lista.Remove("Acre");
        }
        public  void AdicionandoColecoesDiferentes(ref List<string> lista, string[] arrayLista)
        {
            lista.AddRange(arrayLista);
        }
        public void AdicionandoPeloIndice(ref List<string> lista, int indice, string estado)
        {
            lista.Insert(indice,estado);
        }
    }
}