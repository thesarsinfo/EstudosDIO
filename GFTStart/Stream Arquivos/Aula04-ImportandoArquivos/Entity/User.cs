
public class User
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public long Telefon {get;set;}
    public DateOnly BirthDate { get; set; }
    public void CreateCSV()
    {
        var path = Path.Combine(Environment.CurrentDirectory,"Arquive");

        var users = new List<User>()
        {
            new User()
            {
                Name = "Jose da Silva",
                Email = "jss@gmail.com",
                Telefon = 14981591546,
                BirthDate = new DateOnly(year: 1980, month: 4, day: 2)
            },
             new User()
            {
                Name = "Antonio Jose Nunes",
                Email = "ajn@yahoo.com.br",
                Telefon = 13982097569,
                BirthDate = new DateOnly(year: 1985, month: 6, day: 3)
            },
            new User()
            {
                Name = "Cleomares Antonieta Josemur",
                Email = "ajn@yahoo.com.br",
                Telefon = 13987851343,
                BirthDate = new DateOnly(year: 1990, month: 8, day: 4)
            }
        };
        var diretory = new DirectoryInfo(path);
        if(!diretory.Exists)
        {
            diretory.Create();
            path = Path.Combine(path,"user.csv");
        
            using var sWriter = new StreamWriter(path);
            {
                sWriter.WriteLine("nome;email;telefone;nascimento"); //header
                foreach(var user in users)
                {
                    var line = $"{user.Name};{user.Email};{user.Telefon}; {user.BirthDate}";
                    sWriter.WriteLine(line);
                }
            }
        }

    }

}
