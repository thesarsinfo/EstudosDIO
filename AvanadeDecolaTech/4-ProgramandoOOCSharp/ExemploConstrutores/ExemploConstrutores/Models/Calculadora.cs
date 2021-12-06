using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"A soma de {x} + {y} = {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum Inscrito");
            }
        }
        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"A Subtração de {x} - {y} = {x - y}");
        }
    }
}
