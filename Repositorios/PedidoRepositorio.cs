using System.Collections.Generic;
using System.IO;
using SENAI_Hamburgueria.Models;

namespace SENAI_Hamburgueria.Repositorios
{
    public class PedidoRepositorio
    {
        private List<Pedido> Pedidos = new List<Pedido>();

        public string Path = "DataBase/Pedido.csv";
        public bool Inserir(Pedido pedido)
        {
            if (File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            var linha = $"{pedido.ID};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Shake.Nome};{pedido.DataPedido}";

            File.AppendAllText(Path, linha + "\n");
            return true;
        }
    }
}