using System;

namespace Clases
{
    public class Producto{
        public string nombre;
        public double precio;
        public int cantidad;
        public bool aplicaDescuento;

        public int agregarProducto(){
            cantidad++;
            return cantidad;
        }

        public int venderProducto(){
            cantidad--;
            return cantidad;
        }

        public double pagarConEfectivo()
        {
            double ratio = 0.2;
            if (aplicaDescuento){
                precio = precio * (1 - ratio);
            }
            return precio;
        }
    }
}
