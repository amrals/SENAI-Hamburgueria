using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SENAI_Hamburgueria.Models;
using SENAI_Hamburgueria.Repositorios;

namespace Hamburgueria.Controllers
{
    public class PedidoController : Controller
    {
        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);
            Pedido pedido = new Pedido();

            //Instanciação do objeto
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];
            pedido.Cliente = cliente;

            Hamburguer hamburguer = new Hamburguer();
            hamburguer.Nome = form["hamburguer"];
            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake();
            shake.Nome = form["shake"];
            pedido.Shake = shake;

            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Controller"] = "Pedido";

            return View("Sucesso");
        }
    }
}