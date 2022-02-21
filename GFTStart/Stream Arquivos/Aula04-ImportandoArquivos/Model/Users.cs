using CsvHelper.Configuration.Attributes;
public class Users
{
    //anotação de propriedade
    [Name("nome")]
    public string? Name { get; set; }
    [Name("email")]
    public string? Email { get; set; }
    [Name("telefone")]
    public long Telefon {get;set;}
    [Name("data de nascimento")]
    [Format("dd/MM/yyyy")]
    public DateOnly BirthDate { get; set; }
}
