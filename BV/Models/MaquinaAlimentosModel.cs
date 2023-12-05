using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BV.Models
{
    public class MaquinaAlimentosModel
    {
        public List<Producto> Productos { get; set; }
        public List<Moneda> Monedas { get; set; }

        public int Moneda {  get; set; }

        public MaquinaAlimentosModel()
        {
            Productos = new List<Producto>
        {
            new Producto("A", 270),
            new Producto("B", 340),
            new Producto("C", 390)
        };

            Monedas = new List<Moneda>
        {
            new Moneda(10),
            new Moneda(50),
            new Moneda(100)
        };
        }
    }
}