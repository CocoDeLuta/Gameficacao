public class Categoria{
    private int Id { get; set; }
    private string Nome { get; set; }
    private string Descricao { get; set; }
    
    public Categoria(string nome, string descricao, int id)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
    }

    public int GetID(){
        return Id;
    }
    
    public void InfoCategoria()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("Id da Categoria: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Descrição: " + Descricao);
        Console.WriteLine("");
    }

    public string GetNome(){
        return Nome;
    }
}