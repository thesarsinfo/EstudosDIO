using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleExemploLinQ.Helper
{
    public class OperacoesArray
    {
        int temp = 0;
        public void OrdernarbubbleSort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j +1])
                    {
                        temp = array[j +1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }            
        }
        public void Ordernar(ref int[] arrayDois)
        {
            Array.Sort(arrayDois);
        }
        public void ImprimirArray(int[] array)
        {
            string linha = string.Join(", ", array);            
            System.Console.WriteLine(linha);            
        }
        public void CopiarArray(ref int[] array, ref int[] arrayCopia)
        {
            Array.Copy(array,arrayCopia,array.Length);
        }
        public bool ExisteItem(int[] array, int valor)
        {
            //lembra uma função map do javascript
            return Array.Exists(array, elemento => elemento == valor);
        }
        public bool VerificarTodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array,elemento => elemento >= valor);
        }
        public int ObterValor(int[] array,int valor)
        {
            //retorna o primeiro valor que encontra na codição
            // FindAll retorna um Array de valores definidos na condição
            //FindIndex entra o indice e FindFisrt retorna a primeira ocorrencia e 
            //findlast retorna o ultimo valor encontrado

            return Array.Find(array, elemento => elemento == valor);
        }
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array,valor);
        }
        public void RedimencionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array,novoTamanho);
        }
        public string[] ConverterArrayString(int[] array)
        {
            return Array.ConvertAll(array,elemento => elemento.ToString());
        } 

    }
}