namespace Demos.Classes
{
    public class People
    {
        public int Age { get; set; }
        public string Name { get; set; } 
        public string Document { get; set; }
        public void PeopleInit(int agePeople,string name, string document)
        {
            this.Age = agePeople;
            this.Name = name;
            this.Document = document;
        }

        public People Clone()
        {
            return new People()
            {
                Document = this.Document,
                Name = this.Name,
                Age = this.Age
            };
        }
    }
}
