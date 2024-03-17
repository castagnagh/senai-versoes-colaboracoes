using LH_Pets_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LH_Pets_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Cliente cliente1 = new Cliente(1, "João da Silva", "123.456.789-00", "joao.silva@email.com", "Rex");
            Cliente cliente2 = new Cliente(2, "Maria Souza", "987.654.321-00", "maria.souza@email.com", "Luna");
            Cliente cliente3 = new Cliente(3, "Pedro Almeida", "456.789.123-00", "pedro.almeida@email.com", "Toby");
            Cliente cliente4 = new Cliente(4, "Ana Santos", "321.654.987-00", "ana.santos@email.com", "Max");
            Cliente cliente5 = new Cliente(5, "Luiza Oliveira", "789.123.456-00", "luiza.oliveira@email.com", "Mel");

            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            listaClientes.Add(cliente3);
            listaClientes.Add(cliente4);
            listaClientes.Add(cliente5);

            ViewBag.listaClientes = listaClientes;

            Fornecedor fornecedor1 = new Fornecedor(1, "Fornecedor A", "123.456.789/0001-00", "fornecedorA@email.com");
            Fornecedor fornecedor2 = new Fornecedor(2, "Fornecedor B", "987.654.321/0001-00", "fornecedorB@email.com");
            Fornecedor fornecedor3 = new Fornecedor(3, "Fornecedor C", "456.789.123/0001-00", "fornecedorC@email.com");
            Fornecedor fornecedor4 = new Fornecedor(4, "Fornecedor D", "321.654.987/0001-00", "fornecedorD@email.com");
            Fornecedor fornecedor5 = new Fornecedor(5, "Fornecedor E", "789.123.456/0001-00", "fornecedorE@email.com");

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();

            listaFornecedores.Add(fornecedor1);
            listaFornecedores.Add(fornecedor2);
            listaFornecedores.Add(fornecedor3);
            listaFornecedores.Add(fornecedor4);
            listaFornecedores.Add(fornecedor5);
            
            ViewBag.listaFornecedor = listaFornecedores;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
