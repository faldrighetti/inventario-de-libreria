using System;
using Clases;

namespace InventarioDeLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinero dineroEnCaja = new Dinero(75000);
            Producto boligrafo = new Producto("Bolígrafo", 45, 200, false);
            //Ver si a la variable del objeto la llamo boligrafo o producto1
            boligrafo.venderProducto(45, 3);
            Console.WriteLine(boligrafo.cantidad);
        }
    }
}

/*
Artículos de papelería (string nombre, float precioUnitarioVenta, int cantidad, bool aplica descuento):

Bolígrafo 45 200 false
Lápiz 35 180 false
Resma de impresora 2300 50 true
Carpeta A4 1500 80 true
Carpeta N°3 1200 150 true
Cuaderno A4 1000 170 true
Cinta adhesiva 500 60 false
Abrochadora 5000 40 true
Notas adhesivas 2500 250 true

*/