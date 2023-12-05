using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BV.Models
{
    public class Moneda
    {
        public int Valor { get; set; }
        public Producto Producto { get; set; }
        public Moneda(int valor)
        {
            Valor = valor;
        }
    }
}