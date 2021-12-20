using System;
using FinaFastastico.source.Entities;

namespace FinaFastastico
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", "Elite Knight");
            Mage mage = new Mage("Wedge", "Sorcerer");
            Enemy kingMummy = new Enemy("King Mummy", "Zumbi");

            arus.Atacar();
            kingMummy.Atacar();
            if(arus.valorUltimoAtaque == kingMummy.valorUltimoAtaque){
                System.Console.WriteLine("Empate, Ninguem tomou dano");
            }
            else if (arus.valorUltimoAtaque > kingMummy.valorUltimoAtaque){
                kingMummy.ReceberDano(arus.valorUltimoAtaque - kingMummy.valorUltimoAtaque);
                System.Console.WriteLine(arus.name + "Venceu esse round");
            }
            else{
                arus.ReceberDano(kingMummy.valorUltimoAtaque - arus.valorUltimoAtaque );
                System.Console.WriteLine(kingMummy.name + "Venceu esse round");                
            }
            
            System.Console.WriteLine(arus.ToString());
            System.Console.WriteLine(mage.ToString());
            System.Console.WriteLine(arus.Atacar());
            System.Console.WriteLine(mage.Atacar());
            System.Console.WriteLine(mage.Atacar(3));
            
        }
    }
}
