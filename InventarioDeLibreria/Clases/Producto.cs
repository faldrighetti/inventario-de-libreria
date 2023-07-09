using System;
using Clases;

namespace Clases
{
    public class Producto{
        public string nombre;
        public double precioUnitarioCosto;
        public double precioUnitarioVenta;
        public int cantidad;
        public bool aplicaDescuento;

        public int comprarProducto(){
            cantidad++;
            return cantidad;
        }

        public int venderProducto(double precioUnitarioVenta, int cantidad){
            double precioVenta = cantidad * precioUnitarioVenta;
            cantidad--;
            return cantidad;
        }

        public double cobrarEnEfectivo()
        {
            double ratio = 0.2;
            if (aplicaDescuento){
                precioUnitarioVenta = precioUnitarioVenta * (1 - ratio);
            }
            return precioUnitarioVenta;
        }

        public Producto(string nombreProducto, float precioUnitarioVentaProducto, int cantidadProducto, bool aplicaDescuentoProducto){
            nombre = nombreProducto;
            precioUnitarioVenta = precioUnitarioVentaProducto;
            cantidad = cantidadProducto;
            aplicaDescuento = aplicaDescuentoProducto;
        }
    }
}
