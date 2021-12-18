
namespace LojaProdutos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + Nome + "\nPreco: " + Preco + "\n";
        }

    }
}
