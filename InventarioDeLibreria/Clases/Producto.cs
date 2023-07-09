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

        public int comprarProducto(double precioUnitarioProveedor, int cantidadAComprar){
            double precioCompra = cantidadAComprar * precioUnitarioProveedor;
            cantidad += cantidadAComprar;
            return cantidad;
        }

        public int venderProducto(int cantidadVendida){
            cantidad -= cantidadVendida;
            return cantidad;
        }

        public double cobrarEnEfectivo(double precioUnitarioVenta, int cantidadVendida){
            double precioVenta = cantidadVendida * precioUnitarioVenta;
            double ratio = 0.2;
            if (aplicaDescuento){
                precioVenta = precioUnitarioVenta * (1 - ratio);
            }

            return precioVenta;
        }

        public double cobrarConTarjeta(double precioUnitarioVenta, int cantidadVendida){
            double precioVenta = cantidadVendida * precioUnitarioVenta;
            return precioVenta;
        }

        public Producto(string nombreProducto, bool aplicaDescuentoProducto, int cantidadProducto, float precioUnitarioVentaProducto){
            nombre = nombreProducto;
            aplicaDescuento = aplicaDescuentoProducto;
            cantidad = cantidadProducto;            
            precioUnitarioVenta = precioUnitarioVentaProducto;
        }

        public Producto(string nombreProducto, bool aplicaDescuentoProducto, int cantidadProducto, float precioUnitarioVentaProducto, float precioUnitarioCostoProducto):this(nombreProducto, aplicaDescuentoProducto, cantidadProducto, precioUnitarioVentaProducto){
            precioUnitarioCosto = precioUnitarioCostoProducto;
        }
    }
}
