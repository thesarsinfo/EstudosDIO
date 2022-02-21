using static System.Console;

using System.Text;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

Demo02();

static void Demo02()
{
    var path = Path.Combine(Environment.CurrentDirectory,
                            "Arquive",
                            "user.csv");
    var fInfo = new FileInfo(path);
    if(!fInfo.Exists)
        throw new FileNotFoundException($"O arquivo não existe");
    readCSVDynamic();

    void readCSVDynamic()
    {
        using var sRead = new StreamReader(fInfo.FullName);
        var csvConfig = new CsvConfiguration(CultureInfo.GetCultureInfo("pt-BR"))
        {
            Delimiter = ";"
        };
        using var csvReader = new CsvReader(sRead,csvConfig);
        //Podemos usar dymaics ou a classe é prefirivel usar classe
        //para uma tipação forte
        //var registrys = csvReader.GetRecords<dynamics>();

        var registrys = csvReader.GetRecords<Users>().ToList();

        foreach (var item in registrys)
        {
            // O arquivo deve ser separado por , e não por ;
            WriteLine($"nome:{item.Name}");
            WriteLine($"nome:{item.Email}");
            WriteLine($"nome:{item.Telefon}");            
            WriteLine("----------------");
        }
    }
    
}

static void Demo01()
{
    User users = new();
    users.CreateCSV();
    var path = Path.Combine(Environment.CurrentDirectory,
                            "Arquive",
                            "user.csv");
    if (File.Exists(path))
    {
        readArquive(path);
    }
    else
    {
        WriteLine("Arquivo não existe");
    }
    WriteLine("Digite enter para finalizar");
    ReadLine();

    //funções 

    static void readArquive(string path)
    {
        using var sReader = new StreamReader(path);
        var header = sReader.ReadLine()?.Split(';');
        while(true)
        {
            var registry = sReader.ReadLine()?.Split(';');
            if(registry == null) break;
            for(int i = 0 ; i < registry.Length;i++)
            {
                WriteLine($"{header?[i]}: {registry[i]}");
            }
            WriteLine("----------------");
        }
    }
}



