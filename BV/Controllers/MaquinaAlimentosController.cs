using BV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BV.Controllers
{
    public class MaquinaAlimentosController : Controller
    {
        private MaquinaAlimentosModel model;

        public MaquinaAlimentosController()
        {
            model = new MaquinaAlimentosModel();
        }

        public ActionResult Index()
        {
            ViewBag.Productos = model.Productos;
            return View();
        }
        [HttpGet]
        public ActionResult ProcesarVenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcesarVenta(string nombre, string productoElegido, int montoIngresado)
        {
            int cantidad = 0;
            int cambio = 0;
            var vuelto = new List<Moneda> { };
            if (productoElegido == "A")
            {
                while (cantidad < 270)
                {


                    if (montoIngresado == 10 || montoIngresado == 50 || montoIngresado == 100)
                    {
                        cantidad += montoIngresado;
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, solo ingrese monedas de $10, $50 y $100");
                    }
                }
                if (cantidad > 270)
                {
                    cambio = cantidad - 270;

                    while (cambio > 0)
                    {
                      
                        if (cambio >= 100)
                        {
                            vuelto.Add(new Moneda(100));
                            cambio -= 100;
                        }
                        else if (cambio >= 50)
                        {
                            vuelto.Add(new Moneda(50));
                            cambio -= 50;
                        }
                        else if (cambio >= 10)
                        {
                            vuelto.Add(new Moneda(10));
                            cambio -= 10;
                        }

                    }
                    ViewBag.Vuelto = vuelto;
                    ViewBag.Datos = nombre;

                }
            }
            else  if (productoElegido == "B")
            {
                while (cantidad < 340)
                {


                    if (montoIngresado == 10 || montoIngresado == 50 || montoIngresado == 100)
                    {
                        cantidad += montoIngresado;
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, solo ingrese monedas de $10, $50 y $100");
                    }
                }
                if (cantidad > 340)
                {
                    cambio = cantidad - 340;

                    while (cambio > 0)
                    {
                      
                        if (cambio >= 100)
                        {
                            vuelto.Add(new Moneda(100));
                            cambio -= 100;
                        }
                        else if (cambio >= 50)
                        {
                            vuelto.Add(new Moneda(50));
                            cambio -= 50;
                        }
                        else if (cambio >= 10)
                        {
                            vuelto.Add(new Moneda(10));
                            cambio -= 10;
                        }

                    }
                    ViewBag.Vuelto = vuelto;

                }
            }
            else if (productoElegido == "C")
            {
                while (cantidad < 390)
                {


                    if (montoIngresado == 10 || montoIngresado == 50 || montoIngresado == 100)
                    {
                        cantidad += montoIngresado;
                    }
                    else
                    {
                        Console.WriteLine("Lo sentimos, solo ingrese monedas de $10, $50 y $100");
                    }
                }
                if (cantidad > 390)
                {
                    cambio = cantidad - 390;

                    while (cambio > 0)
                    {
                      
                        if (cambio >= 100)
                        {
                            vuelto.Add(new Moneda(100));
                            cambio -= 100;
                        }
                        else if (cambio >= 50)
                        {
                            vuelto.Add(new Moneda(50));
                            cambio -= 50;
                        }
                        else if (cambio >= 10)
                        {
                            vuelto.Add(new Moneda(10));
                            cambio -= 10;
                        }

                    }

                    ViewBag.Vuelto = vuelto;

                }
            }


            return View("ProcesarVenta");
        }
    }

}
