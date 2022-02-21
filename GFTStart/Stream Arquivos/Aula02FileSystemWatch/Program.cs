var path = @"..\Aula01\globo";

using var fileSystemWatcher = new FileSystemWatcher(path);
{
    fileSystemWatcher.Created += OnCreated;
    fileSystemWatcher.Deleted += OnDeleted;
    fileSystemWatcher.Renamed += OnRenamed;
    fileSystemWatcher.EnableRaisingEvents = true;
    fileSystemWatcher.IncludeSubdirectories = true;
}
Console.WriteLine("Monitorando eventos!");
Console.WriteLine("--Pressione enter para finalizar");
Console.ReadLine();

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"O arquivo {e.Name} foi excluido");

}

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}