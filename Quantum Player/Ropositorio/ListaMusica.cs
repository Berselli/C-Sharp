using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ropositorio
{
    [Serializable]
    public class ListaMusica : List<Musica>
    {
        #region Método de Ordenação Insertion Sort

        private static ListaMusica InsertionSort(ListaMusica inputArray)
        {
            var stopwatch = new Stopwatch();
            int length = inputArray.Count;
            stopwatch.Start();
            for (int i = 1; i < length; i++)
            {
                int j = i;
                while ((j > 0) && (inputArray.ElementAt(j).Titulo.CompareTo(inputArray.ElementAt(j - 1).Titulo) < 0))
                {
                    int k = j - 1;
                    Musica temp = inputArray.ElementAt(k);
                    inputArray[k] = inputArray.ElementAt(j);
                    inputArray[j] = temp;
                    j--;
                }
            }
            stopwatch.Stop();
            Log.salvarLog(stopwatch.Elapsed.ToString().Remove(0, 6), "Ordenar");
            stopwatch.Reset();
            return inputArray;
        }


           
        #endregion
    
    
        #region Chamada dos Métodos de Ordenação

        public static ListaMusica SortTitle(ListaMusica lista)
        {
            return InsertionSort(lista);
        }
        #endregion

        #region Pesquisar

        public static Object Pesquisar(string pesquisa, ListaMusica lista)
        {     
            try
            {
                return lista.FindAll(stringToCheck => stringToCheck.Titulo.ToLower().Contains(pesquisa));
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }
        #endregion
    }
}
