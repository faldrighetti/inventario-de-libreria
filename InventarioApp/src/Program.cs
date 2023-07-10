using System;
using Clases;

namespace InventarioDeLibreria
{
    class Program
    {
        static void Main(string[] args){
            Producto boligrafo = new Producto("Bolígrafos", false, 200, 100, 35);
            Producto lapiz = new Producto("Lápices", false, 180, 80, 20);
            Producto resma = new Producto("Resmas de papel A4", true, 50, 2300, 970);
            Producto carpeta = new Producto("Carpetas N°3", true, 150, 1200, 250);
            Producto cuaderno = new Producto("Cuadernos A4", true, 170, 1000, 300);
            Producto cintaAdhesiva = new Producto("Cintas adhesivas", false, 60, 500, 150);
            Producto abrochadora = new Producto("Abrochadoras", true, 40, 3700, 1100);
            Producto notasAdhesivas = new Producto("Blocs de notas adhesivas", true, 250, 2500, 700);
            Dinero activoMonetario = new Dinero(27000);

            //Con la compra de 5 unidades de un producto en promoción, el precio total tendrá un 20% de descuento.

            cuaderno.comprarProducto(15, 200, activoMonetario);
            notasAdhesivas.venderProducto(10, 2500, activoMonetario);
            Console.WriteLine(activoMonetario);
        }
    }
}
