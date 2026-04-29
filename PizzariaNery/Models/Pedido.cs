using System.Security.Cryptography.X509Certificates;

namespace Pizzaria.Models
{
    public class Pedido
    {
        // as propriedades get e set permitem respectivamente acessar e modificar o valor da variável
        public string? tamanho { get; set; }
        public string? sabor { get; set; }
        public string? borda { get; set; }
        public List<string> adicionais { get; set; } = new List<string>();
        public string? endereco { get; set; }
        public double valorEntrega { get; set; }
        public DateTime horarioPedido { get; set; }
        public DateTime previsaoEntrega => horarioPedido.AddHours(1);

        public double CalcularPedido()
        {
            double total = 0;
            total += tamanho switch
            {
                "Pequena" => 30.00,
                "Média" => 50.00,
                "Grande" => 60.00,
                _ => 0.00
            };
            total *= sabor switch
            {
                "Queijo" => 1.00,
                "Pepperoni" => 1.00,
                "Calabresa" => 1.10,
                "Marguerita" => 1.10,
                "Portuguesa" => 1.15,
                "Frango com Catupiry" => 1.20,
                _ => 1.00
            };
            total += borda switch
            {
                "- Nenhuma -" => 0.00,
                "Borda de catupiry" => 10.00,
                "Borda de cheddar" => 10.00,
                "Borda de queijo" => 10.00,
                _ => 0.00
            };
            total += adicionais.Count * 5.00;
            total += 10.00; // valor fixo para entrega
            return total;
        }
    }
}