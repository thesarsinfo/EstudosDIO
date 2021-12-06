using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }
        public void SetMes(int mes)
        {
            if (mes > 0 && mes < 13)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public int Mes
        { 
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value < 13) //value vem depois da atribuição da instancia do 
                    //objeto
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }
        public void ApresentarMes()
        {
            string mensagem = (this.mesValido) ? this.mes.ToString() : "Mes invalido";
            Console.WriteLine(mensagem);
        }
    }
}
