public class Venda{
    private int Id { get; set; }
    private Cliente clienteVenda { get; set; }
    private List<Produto> produtoVenda { get; set; }
    private DateOnly data { get; set; }

    public Venda(Cliente cliente, List<Produto> produtosVendidos, DateOnly dataVenda)
    {
        clienteVenda = cliente;
        produtoVenda = produtosVendidos;
        data = dataVenda;
    }

    public void InfoVenda()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("Id da Venda: " + Id);
        Console.WriteLine("Cliente: " + clienteVenda.GetNome());
        Console.WriteLine("Data: " + data);
        Console.WriteLine("Valor Total: R$" + ValorTotal());
        Console.WriteLine("Produtos: ");
        Console.WriteLine("");
        foreach (var produto in produtoVenda)
        {
            produto.InfoProdutoVenda();
        }
        Console.WriteLine("");
    }

    public int GetID()
    {
        return Id;
    }

    public void SetID(int id)
    {
        Id = id;
    }

    public decimal ValorTotal(){
        decimal valorTotal = 0;
        foreach (var produto in produtoVenda)
        {
            valorTotal += produto.GetPreco() * produto.GetQuantidade();
        }
        return valorTotal;
    }

}