using static System.Console;
Demo3();
ReadLine();
static void Demo3() //ler diretorios
{
 var path = Path.Combine(Environment.CurrentDirectory,"globo");
 ReadDiretorys(path);
 ReadArquive(path);
}

static void Demo2() //Cria diretorios
{
    createDiretory();
    Demo1();
    var origin = Path.Combine(Environment.CurrentDirectory,"brasil.txt");
    var destiny = Path.Combine(Environment.CurrentDirectory,
                                    "Globo",
                                    "America do Sul",
                                    "Brasil",
                                    "brasil.txt");   
    MoveArquive(origin,destiny);
}

static void Demo1()
{
    WriteLine("Digite o nome do arquivo");
    string? arquive = ReadLine() ?? "padrao";
    arquive = VerifyWrongChar(arquive);

    var path = Path.Combine(Environment.CurrentDirectory,$"{arquive}.txt");
    /* quanto utilizamos string devemos usar o  escape \\ caso contrario com o uso dpo combien
    devemos usar o caminho ou podemos utilizar uma pasta aleatoria se quiser.*/
    if(!File.Exists(path))
    {
        CreateArquive(path);   
    }
    WriteLine("Digite enter para finalizar");
    ReadLine();    
}
 
    //Copy arquive funciona do mesmo jeito que move arquive
    static void CopyArquive(string pathOrigin, string pathFinal)
    {
        if(VerifyOriginDestiny(pathOrigin,pathFinal))
        {
            File.Copy(pathOrigin,pathFinal);
        }        
    }
    static void MoveArquive(string pathOrigin, string pathFinal)    
    {
        if(VerifyOriginDestiny(pathOrigin,pathFinal))
        {
            File.Move(pathOrigin,pathFinal);
        }      
    }
    static bool VerifyOriginDestiny(string pathOrigin, string pathFinal)
    {
        if(!File.Exists(pathOrigin))
        {
            WriteLine("O arquivo de origem não existe");
            return false;
        }
        else if(File.Exists(pathFinal))
        {
            WriteLine("O arquivo de destino já existe");
            return false;
        }
        return true;
    }
    static void createDiretory()
    {
        var path = Path.Combine(Environment.CurrentDirectory,"globo");
        if(!Directory.Exists(path))
        {
            var globalDiretory = Directory.CreateDirectory(path);
            var northAmericaDiretory = globalDiretory.CreateSubdirectory("America do Norte");
            var centralAmericaDiretory = globalDiretory.CreateSubdirectory("America Central");
            var southAmericadiretory = globalDiretory.CreateSubdirectory("America do Sul");
            northAmericaDiretory.CreateSubdirectory("Estado Unidos");
            northAmericaDiretory.CreateSubdirectory("Canada");
            northAmericaDiretory.CreateSubdirectory("Mexico");

            centralAmericaDiretory.CreateSubdirectory("Costa Rica");
            centralAmericaDiretory.CreateSubdirectory("Panama");

            southAmericadiretory.CreateSubdirectory("Paraguai");
            southAmericadiretory.CreateSubdirectory("Brasil");
            southAmericadiretory.CreateSubdirectory("Uruguai");

            WriteLine("Diretorio criado em " + path.ToString());
        }
    }
    static string VerifyWrongChar(string arquive)
    {
        // O codigo abaixo serve para tratar o arquivo ou informar o usuario de caracteres 
        //invalidos
        foreach(var @char in Path.GetInvalidFileNameChars()) //@char serve para usar palavra reservada do dotnet
        {
            arquive = arquive.Replace(@char,'-');
        }
        return arquive;
    }
    static void CreateArquive(string path)
    {
    //File.Create(path); cria um arquivo vazio
    //O metodo abaixo serve para automatizar o fechamento do arquivo sem o uso do metodo
    //flush
        try
        {
            using var sw = File.CreateText(path);
            {
                sw.WriteLine("População: 215.000.000");
                sw.WriteLine("IDH: 0,921");
                sw.WriteLine("Dados atualizados em: 17/02/2022");
            };
        }
        catch (Exception)
        {
            WriteLine("Nome de arquivo invalido");        
        }
    //o metodo flush serve para descarregar a memoria no arquivo
    //sw.Flush(); // cuidado com o tamanho
    //O metodo close serve para fechar a conexao como padrao de qualquer linguagem;
    //sw.Close();
    }
static void ReadDiretorys(string path)
{
    if(Directory.Exists(path))
    {
        var directory = Directory.GetDirectories(path,"*",SearchOption.AllDirectories);
        foreach(var dir in directory)
        {
            var diretoryInformation = new DirectoryInfo(dir);
            WriteLine($"[Nome da pasta]:{diretoryInformation.Name}");
            WriteLine($"[Pasta Raiz]:{diretoryInformation.Root}");
            if(diretoryInformation.Parent != null)        
                WriteLine($"[Pasta Pai]:{diretoryInformation.Parent.Name}");
            WriteLine("--------------");            
        }
    }
    else
    {
        WriteLine($"O {path} não existe!");

    }
}
static void ReadArquive(string path)
{
    if(Directory.Exists(path))
    {
        var arquivesInfo = Directory.GetFiles(path,"*.txt",SearchOption.AllDirectories);
        WriteLine("Imprimindo arquivos");
        foreach(var arq in arquivesInfo)
        {
            var arquiveInformation = new FileInfo(arq);
            WriteLine($"[Nome do arquivo]:{arquiveInformation.Name}");
            WriteLine($"[Data de criação]:{arquiveInformation.CreationTime}");                   
            WriteLine($"[Extensão]:{arquiveInformation.Extension}");
            WriteLine($"[Pasta]:{arquiveInformation.DirectoryName}");
            WriteLine("--------------");            
        }

    }
}