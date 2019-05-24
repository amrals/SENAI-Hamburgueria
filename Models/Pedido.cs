using System;

namespace SENAI_Hamburgueria.Models
{
    public class Pedido
    {
        public ulong ID {get;set;}
        public Cliente Cliente {get;set;}
        public Hamburguer Hamburguer {get;set;}
        public Shake Shake {get;set;}
        public DateTime DataPedido {get;set;}
    }
}