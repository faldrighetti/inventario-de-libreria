using System;
using Clases;

namespace InventarioDeLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto boligrafo = new Producto();
            boligrafo.nombre = "Boligrafo";
            boligrafo.precio = 40;
            boligrafo.cantidad = 200;
            boligrafo.aplicaDescuento = false;
        }
    }
}