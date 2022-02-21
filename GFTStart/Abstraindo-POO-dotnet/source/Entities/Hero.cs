
namespace Abstraindo_POO_dotnet.source.Entities
{
    public abstract class Hero
    {
        public string? Name { get; set; }
        public int Level { get; set; }
        public string? HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public  virtual string Attack()
        {
            return this.Name + "Atacou com a sua espada";
        }
        public override string ToString()
        {
            return this.Name;
        }

    }
}