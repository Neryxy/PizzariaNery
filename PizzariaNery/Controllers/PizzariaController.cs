using Microsoft.AspNetCore.Mvc;
using Pizzaria.Models;

namespace Pizzaria.Controllers
{
    public class PizzariaController : Controller
    {
        public IActionResult NovoPedido()
        {
            return View();
        }
        // pedido é uma instancia da classe Pedido, que é preenchida com os dados do formulário enviado pelo usuário
        public IActionResult NotaPedido(Pedido pedido)
        {
            ViewBag.total = pedido.CalcularPedido();
            pedido.horarioPedido = DateTime.Now;
            return View(pedido);
        }
        // o viewbag é um objeto dinâmico que permite mostrar dados internos na view
    }
}