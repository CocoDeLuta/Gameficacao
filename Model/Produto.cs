public class Produto
{
    private int Id { get; set; }
    private string Nome { get; set; }
    private string Descricao { get; set; }
    private decimal Preco { get; set; }
    private int CategoriaId { get; set; }
    private int Quantidade { get; set; }

    private Categoria categoriaProduto;

    public Produto(string nome, string descricao, decimal preco, int id)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
    }

    public void SetCategoria(Categoria categoria)
    {
        if (categoria != null)
        {
            categoriaProduto = categoria;
        }

    }

    public void InfoProduto()
    {
        Console.WriteLine("Id do Produto: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Descrição: " + Descricao);
        Console.WriteLine("Preço: R$" + Preco);
        Console.WriteLine("Categoria: " + categoriaProduto.GetNome());
        Console.WriteLine("");
    }

    public int GetCategoria()
    {
        return CategoriaId;
    }

    public int GetID()
    {
        return Id;
    }

    public void SetID(int id)
    {
        Id = id;
    }

    public decimal GetPreco()
    {
        return Preco;
    }

    public string GetNome()
    {
        return Nome;
    }

    public void SetQuantidade(int quantidade)
    {
        Quantidade = quantidade;
    }

    public int GetQuantidade()
    {
        return Quantidade;
    }

    public void InfoProdutoVenda()
    {
        Console.WriteLine("Id do Produto: " + Id);
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Descrição: " + Descricao);
        Console.WriteLine("Preço: " + Preco);
        Console.WriteLine("Quantidade: " + GetQuantidade());
        Console.WriteLine("Categoria: " + categoriaProduto.GetNome());
        Console.WriteLine("");
    }
}