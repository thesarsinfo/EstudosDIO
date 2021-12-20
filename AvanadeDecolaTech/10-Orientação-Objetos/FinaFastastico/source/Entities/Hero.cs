using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaFastastico.source.Entities
{
    public class Hero
    {
        public Hero(string name, string vocation)
        {
            this.name = name;
            this.vocation = vocation;
            this.level = 1;
            this.lifePoints = 150;
            this.magicPoints = 30;
        }
        //properties
        public string name { get; set; }
        public int level {get;set;}
        public int lifePoints { get; set; }
        public int magicPoints { get; set; }
        public string vocation { get; set; }
        public int valorUltimoAtaque {get;set;}
        public string namePet {get;set;}
        //metodos
        public override string ToString(){
            return "Meu nome é " + this.name +  "\n"
                + "Level " + this.level +  "\n"
                + "Pontos de vida " + this.lifePoints +  "\n"
                + "Pontos de magia " + this.magicPoints +  "\n"
                + "Minha classe " + this.vocation +  "\n";
        }
        public virtual string Atacar(){
            Random dado = new Random();
            int forcaAtaque = this.level + dado.Next(1,10);
            this.valorUltimoAtaque = forcaAtaque;
            return this.name + " Ataca com sua espada e da " + 
                    forcaAtaque + " de dano";                    
        }
         public void ReceberDano(int danoRecebido){
            this.lifePoints -= danoRecebido;
        }
        
    }
}