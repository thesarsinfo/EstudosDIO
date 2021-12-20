using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFastastico.source.Entities
{
    public class Mage : Hero
    {
        public Mage(string name, string vocation) : base(name, vocation)
        {
            this.name = name;
            this.vocation = vocation;
            this.level = 1;
            this.lifePoints = 150;
            this.magicPoints = 30;
        }
        public override string Atacar()
        {
            Random dado = new Random();
            int forcaAtaque = this.level + dado.Next(1,20);
            this.valorUltimoAtaque = forcaAtaque;
            return this.name + " Ataca com seu cajado e da " + 
                    forcaAtaque + " de dano";
        }
        public string Atacar(int bonus)
        {
            Random dado = new Random();
            int forcaAtaque = this.level + dado.Next(1,10) + bonus;
            this.valorUltimoAtaque = forcaAtaque;
            return this.name + " Ataca com seu cajado e da " + 
                    forcaAtaque + " de dano";
        }
    }
}