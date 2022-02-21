using static System.Console;
using System.Text;
Demo2();
static void Demo2()
{
    var stringText = @"Lorem ipsum dolor sit amet. Nam doloribus magnam ut\n
        similique molestiae qui repellat voluptatem in consequatur eius vel\n
        consequatur numquam? Ex mollitia provident ut libero laboriosam ut maxime\n 
        eligendi et nemo expedita aut optio dolorem eum incidunt fugiat ut dolores 
        similique. Hic eaque dolorum aut praesentium internos vel repudiandae omnis
        quo illo rerum vel tempore consequatur ut dolores veniam ut similique 
        quia." + "\n\n" + 
       @"Ut deleniti modi qui nobis iure et omnis laboriosam qui dicta totam et 
       perspiciatis natus sit eligendi molestias et eligendi facere. Qui velit
        totam est dolores quod et consequatur illo qui veritatis quos."  + "\n\n" + 
        @"Sed tempore odit sed deleniti voluptatem qui necessitatibus quas sit minus 
        laudantium id asperiores magni id velit nobis? Sit quisquam omnis in galisum sunt
        ea asperiores quod et error minus in provident dolor ut repellendus dolorem!
        ";

        WriteLine($"Texto Original: {stringText}");
        string line, paragrafh = null;
        var sReader = new StringReader(stringText);

        while(true)
        {
            line = sReader.ReadLine();
            if (line != null)
            {
                paragrafh += line + " ";
            }
            else
            {
                paragrafh += "\n";
                break; 
            }
                       
        }
        WriteLine($"Texto modificado: {paragrafh}");
        int characterRead;
        char characterConvert;

        using var sWriter = new StringWriter();
        sReader = new StringReader(paragrafh);

        while (true)
        {
            characterRead = sReader.Read();
            if(characterRead == -1) break;
            characterConvert = Convert.ToChar(characterRead); //verifica letra de 0 a 255;
            //Verifica pontuação
            if(characterConvert == '.')
            {
            sWriter.Write("\n\n");
            sReader.Read();
            sReader.Read();
            }
            else
            {
                sWriter.Write(characterConvert);
            }
        }
        WriteLine($"O texto armazenado no StringWrite: {sWriter.ToString()}");
}

static void Demo1()
{
    var sBuilder = new StringBuilder();
    sBuilder.AppendLine("Caracteres da primeira linha");
    sBuilder.AppendLine("Segunda linha");
    sBuilder.AppendLine("Fim de leitura");

    using var sReader = new StringReader(sBuilder.ToString());

        /*
        var textOne = sReader.ReadToEnd(); Ler o arquivo inteiro mas use com cuidado
        var textTwo = sReader.ReadLine(); ler linha por linha mas pode ter linha infinita
        */
    var buffer = new char[10]; //define o tamanho da leitura
    var textThree = sReader.Read(buffer);
    //Modo curto
    do
    {
        WriteLine(sReader.ReadLine());    
    } while(sReader.Peek() >= 0); //vai consumindo caracteres por paragrafo e retorna -1
    //Quando não houver caractere retorna -1

    /* Modo longo  
    var size = 0;

    do
    {
        buffer = new char[10]; //limpar o buffer para evitar sujeira no final;
        size = sReader.Read(buffer);
        Write($"{string.Join("",buffer)}");// Forma de imprimir o buffer
    } while (size >= buffer.Length);
    */
}
WriteLine("digite enter para finalizar");
ReadLine();