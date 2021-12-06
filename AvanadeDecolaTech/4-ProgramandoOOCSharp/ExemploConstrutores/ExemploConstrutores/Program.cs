// See https://aka.ms/new-console-template for more information
using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Operacao op = new Operacao(Calculadora.Somar);
            // a operação += não funciona como operador de atribuiçã e somatoria e sim
            //como uma referencia a não ser perdida no metodo  anterios
            //Metodo abaixo de chama multicasting delegate
            op += Calculadora.Subtrair;
            op.Invoke(10, 15);
            const double pi = 3.14; // nesse caso essa variavel nunca pode ser mudade
            // podemos apenas a sua leitura e somo obrigatoriamente declarados
            Console.WriteLine( "o valor de pi é : " + pi);

           // Pessoa pesUm = new Pessoa();
            Pessoa pesDois = new Pessoa("Thiago", "Saraiva");
            // Log se trata do padrão de projeto chamado de singletown
            Log log = Log.GetInstance();
            log.propriedadeLog = "Teste instancia";
            Log logDois = Log.GetInstance();
            Console.WriteLine(logDois.propriedadeLog);
           // pesUm.Apresentar();
            pesDois.Apresentar();
            Aluno aluno = new Aluno("Diego", "Alves", "Futebol");
            aluno.Apresentar();
            Data data = new Data();
            data.SetMes(13);
            data.ApresentarMes();
            data.Mes = 12; // uso do setter
            Console.WriteLine(data.Mes); // uso do get

            Matematica mat = new Matematica(10, 20);
            mat.Somar();
        }
    }
}
