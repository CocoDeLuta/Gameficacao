public class Cliente{

    private int Id { get; set; }
    private string Nome { get; set; }
    private string Sobrenome { get; set; }
    private string Endereco { get; set; }
    private string Telefone { get; set; }

    private int idNumber = 0;
    
    public Cliente(string nome, string sobrenome, string endereco, string telefone)
    {
        Id = idNumber;
        Nome = nome;
        Sobrenome = sobrenome;
        Endereco = endereco;
        Telefone = telefone;
        idNumber++;
    }

    public void InfoCliente()
    {   
        Console.WriteLine("==================================");
        Console.WriteLine("Id do Cliente: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Sobrenome: " + Sobrenome);
        Console.WriteLine("Endereço: " + Endereco);
        Console.WriteLine("Telefone: " + Telefone);
        Console.WriteLine("");
    }

    public int GetID(){
        return Id;
    }

    public void SetID(int id){
        Id = id;
    }

    public string GetNome(){
        return Nome;
    }
}