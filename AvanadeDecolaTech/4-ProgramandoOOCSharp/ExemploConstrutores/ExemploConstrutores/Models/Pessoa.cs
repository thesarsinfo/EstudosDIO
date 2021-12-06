using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        // sendo readonly podemos fazer alterações somente no construtor ou na inicialização
        //de resto não podemos fazer alteração
        private readonly string nome = "thiago";
        private readonly string sobrenome;
        //construtor sem parametro e sem retorno e com mesmo nome da classe
        /*
        public Pessoa() //construtor padrao
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        */
        //construtor com parametros e podemos instanciar os dois
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome= sobrenome;
            Console.WriteLine("Contrutor classe Pessoa pronta");
        }
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {nome} e meu sobrenome é {sobrenome}");
        }
        //exemplo de erros
        public void AlteraNome(string nome)
        {
            //this.nome = nome;
        }
    }
}
