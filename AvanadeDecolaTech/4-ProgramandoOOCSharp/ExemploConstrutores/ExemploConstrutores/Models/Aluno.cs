using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        //passando o parametro para classe mãe que é Pessoa usando parametro base
        //Ordem de excuçãõ é da classe mãe para classe filho
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {            
            Console.WriteLine("Contrutor classe Aluno pronta");
        }
    }
}
