using Abstraindo_POO_dotnet.source.Entities;
using static System.Console;

namespace AbstraindoRPGDonet
{
    class Program
    {
        static void Main()
        {
            Knight arus = new("Arus", 23 , "Knight");      
            Wizard jenica = new("Jennica", 23 , "White Wizard");      

            WriteLine(arus.Attack());     
            WriteLine(jenica.Attack(6));     
        }
    }
}