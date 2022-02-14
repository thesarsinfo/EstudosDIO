namespace Demos.Classes
{
    public class People
    {
        public int Age { get; set; }
        public string Name { get; set; } 
        public string Document { get; set; }

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
