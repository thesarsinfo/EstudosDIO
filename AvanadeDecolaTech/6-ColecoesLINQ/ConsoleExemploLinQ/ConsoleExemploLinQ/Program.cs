//See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleExemploLinQ.Helper;

namespace ConsoleExemploLinQ
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {10 , 10 , 35 , 35 , -15 , 88, 45 ,65,59,87};
            // mobo verboso // poderiamos usar o var mais eu quis trabalhar com objetos para treinar
            IOrderedEnumerable<int> numeropares =          
                from num in numeros
                where num % 2 == 0
                orderby num
                select num;
            foreach (var item in numeropares)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Modo inline");
            //Modo inline
            List<int> numerosPareados = new List<int>();
            
            numerosPareados.AddRange(numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList());
            foreach (var item in numerosPareados)
            {
                System.Console.WriteLine(item);
            }
            //Maximo , minimo e Media com Linq vamos usar var para facilitar
            var minimo = numeros.Min();
            var maximo = numeros.Max();
            var media = numeros.Average();
            var soma = numeros.Sum();
            System.Console.WriteLine($"Minimo -: {minimo} - " +
                                     $"Maximo -: {maximo} - " +
                                     $"Average -: {media} - " +
                                     $"Soma -: {soma}");
            int[] ArrayUnico = numeros.Distinct().ToArray();
            System.Console.WriteLine("Valores unicos: " + string.Join(", ",ArrayUnico));


            /*

            Dictionary<string,string> estados = new Dictionary<string, string>();

            estados.Add("SP","São Paulo");
            estados.Add("MG","Minas Gerais");
            estados.Add("PA","Para");
            //percorre o dicioanrio
            foreach (KeyValuePair<string,string> estado in estados) 
            {
                System.Console.WriteLine($"A chave {estado.Key} e o nome do estado de {estado.Value}");
            }
            // retorna o valor PARA
            string valorProcurado = "PA";
            System.Console.WriteLine(estados[valorProcurado]);
            // atualiza valoe
            System.Console.WriteLine($"valor oririnal = {estados["PA"]}");
            estados[valorProcurado] = "BA - Bahia atualizado";
            System.Console.WriteLine("Valor atualizado");
            System.Console.WriteLine(estados.Values + " = " + estados[valorProcurado]);
            //Removendo
            estados.Remove("PA");
            //Acessar de forma segura pelo metodo trygetvalue
            string mensagem = (estados.TryGetValue("SP", out string estadoEncontrado))
                                ? estadoEncontrado : "Chave inexistente" ;
            System.Console.WriteLine(mensagem);
            /*
            Stack<string> pilhaLivros = new Stack<string>();

            pilhaLivros.Push("LoL");
            pilhaLivros.Push(".Net");
            pilhaLivros.Push("Codigo Limpo");
            System.Console.WriteLine($"O numero de livros nas filas é {pilhaLivros.Count}");

            while (pilhaLivros.Count > 0)
            {
                System.Console.WriteLine($"O Proximo livro para leitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"O livro: {pilhaLivros.Pop()} lido com sucesso");
            }
            System.Console.WriteLine($"O numero de livros nas filas é {pilhaLivros.Count}");

            /*
            Queue<string> fila = new Queue<string>();
            //incluir elementos na fila
            fila.Enqueue("Thiago");
            fila.Enqueue("Jorge");
            fila.Enqueue("Saraiva");
            System.Console.WriteLine($"O numero de pessoas nas filas é {fila.Count}");
            while (fila.Count > 0)
            {
            System.Console.WriteLine($"O numero de pessoas nas filas é {fila.Count}");

                System.Console.WriteLine($"A vez de: {fila.Peek()}");
                System.Console.WriteLine($"{fila.Dequeue()} atendido");                
            }
            System.Console.WriteLine($"O numero de pessoas nas filas é {fila.Count}");

            /*
            List<string> estados = new List<string>();
            string[] estadosArray = new string[3] {"Santa Catarina","Mato Grosso","Acre"};
            OperacoesLista opl = new OperacoesLista();
            estados.Add("Acre");
            estados.Add("Amapa");
            estados.Add("Sao Paulo");

            System.Console.WriteLine($"A quantidade de elementos na lista é {estados.Count}");
            //Imprimindo todos elementos
            opl.ImprimirListaString(estados);
            //Removendo item da lista
            System.Console.WriteLine("Removendo elemento");
            opl.DeletarListaString(estados);
            opl.ImprimirListaString(estados);
            System.Console.WriteLine("\n");

            //Adicinando elementos da lista existente
            opl.AdicionandoColecoesDiferentes(ref estados, estadosArray);
            opl.ImprimirListaString(estados);
            //Adicionado valores pelo indice requerido
            string estado = "Rio de Janairo";
            opl.AdicionandoPeloIndice(ref estados,1,estado);
            System.Console.WriteLine("\n");
            opl.ImprimirListaString(estados);

            /*
            OperacoesArray opa = new OperacoesArray();
            int[] array = new int[5] {-1,3,0,1,5};//Aula 3 Manipulando array etapa 1
            int[] arrayDois = new int[5] {5,9,45,8,3};
            int[] arrayCopia = new int [10]; //Manipulando array etapa 6
            int valorProcurado = 0;//Aula 3 etapa 7 e 8
            bool existe = opa.ExisteItem(array, valorProcurado); // Aula 3 etapa 7
            bool maior = opa.VerificarTodosMaiorQue(array,valorProcurado); //aula 3 etapa 8
            int retorno; //aula 3 etapa 9


            System.Console.WriteLine("Array original");
            opa.ImprimirArray(array);
            opa.ImprimirArray(arrayDois);
            System.Console.WriteLine("Array ordenado");
            opa.OrdernarbubbleSort(ref array);            
            opa.ImprimirArray(array);
            opa.Ordernar(ref arrayDois);
            opa.ImprimirArray(arrayDois);
            //copia de Array
            System.Console.WriteLine("Array antes da copia");
            opa.ImprimirArray(arrayCopia);
            opa.CopiarArray(ref array, ref arrayCopia);
            System.Console.WriteLine("Imprimindo a copia");
            opa.ImprimirArray(arrayCopia);

            //verificando se existe um item no array          
            System.Console.WriteLine( (existe)?"Encontrei o valor" :"Não encontrei o valor");
            
            // Verificando se todos elementos são verificado com valor especificado
            System.Console.WriteLine( (maior)?"Todos os valores são maior que 0" :"Há valores menores que 0");

            int valorProcuradoFind = 1; //aula 3 etapa 9
            //Veriiicando se existe um elemento e retornar seu valou ou indice
            retorno = opa.ObterValor(array, valorProcuradoFind);
            System.Console.WriteLine(retorno);
            System.Console.WriteLine(
                (retorno != 0) ? $"O valor procurado é {retorno}": "Valor não encontrado");

            //retornando o indice com IndexOf
            int indice = opa.ObterIndice(array,valorProcuradoFind);
            System.Console.WriteLine(
                (indice == -1)  ? $"O indice do valor procurado não exite e retornou {indice}"
                                :$"O indice do valor procurado {valorProcuradoFind} é indice {indice}");
            
            //Redimentcionando um Array
            System.Console.WriteLine($"Capacidade Atual do Array é {array.Length}");
            int novoTamanho = array.Length / 2;
            opa.RedimencionarArray(ref array,novoTamanho);
            System.Console.WriteLine($"Capacidade depois de redimencionar do Array é {array.Length}");
            //Convertendo um Array
            string[] arrayString = opa.ConverterArrayString(array);
            System.Console.WriteLine(arrayString);

            // Console.WriteLine("Arrrrrrrray");
            // int[] listaNumeros = new int[3];
            // listaNumeros[0] = 10;
            // listaNumeros[1] = 20;
            // listaNumeros[2] = int.Parse("30");
            // // erro abaixo
            // listaNumeros[3] = 40;

            // int i = 0;

            // foreach (int num in listaNumeros)
            // {                
            //     listaNumeros[i] = i + 1;
            //     i += 1;
            //     Console.WriteLine(listaNumeros[num]);
            // }      
            // System.Console.WriteLine(listaNumeros[0]);      
            // System.Console.WriteLine(listaNumeros[1]);      
            // System.Console.WriteLine(listaNumeros[2]);      
            */
        }
    }
}