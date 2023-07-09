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
            Producto abrochadora = new Producto("Abrochadoras", true, 40, 5000, 1100);
            Producto notasAdhesivas = new Producto("Blocs de notas adhesivas", true, 250, 2500, 700);
            Dinero activoMonetario = new Dinero(27000);

            //Con la compra de 5 unidades de un producto en promoción, el precio total gozará un 20% de descuento.

            cuaderno.comprarProducto(17, 300, activoMonetario);
            Console.WriteLine("Ahora tenemos " + cuaderno.cantidad + " cuadernos, y nuestro saldo es de " 
            + activoMonetario.cantidadDisponible);
            //cantidadDisponible = 21900. 300 * 17 = 5100. 27000 - 5100 = 21900, verifica
            cuaderno.venderProducto(13, 1000, activoMonetario);
            Console.WriteLine("Ahora tenemos " + cuaderno.cantidad + " cuadernos, y nuestro saldo es de " 
            + activoMonetario.cantidadDisponible);
            //cantidadDisponible = 32300, la venta de 13 cuadernos se dio por 10400 pesos. El 80% de 13000 es 10400, verifica. 
        }
    }
}

// nombre, aplicaDescuento, cantidad, unitarioVenta, unitarioCosto
