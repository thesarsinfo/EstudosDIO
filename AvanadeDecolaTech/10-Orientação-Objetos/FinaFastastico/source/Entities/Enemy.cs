using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFastastico.source.Entities
{
    public class Enemy : Hero
    {
        public Enemy(string name, string vocation) : base(name, vocation)
        {
            this.name = name;
            this.vocation = vocation;
            this.level = 1;
            this.lifePoints = 300;
            this.magicPoints = 0;
        }
        public override string Atacar()
        {
            Random dado = new Random();
            int forcaAtaque = this.level + dado.Next(1,15);
            this.valorUltimoAtaque = forcaAtaque;
            return this.name + " Ataca com sua garra e da " + 
                    forcaAtaque + " de dano";
        }
       
    }
}