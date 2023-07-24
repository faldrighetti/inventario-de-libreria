using System;
using Clases;

namespace Clases
{
    public class Producto{
        private string nombre;
        private bool enPromocion;
        private int cantidad;
        private double precioUnitarioVenta;
        private double precioUnitarioCosto;

        public void comprarProducto(int cantidadAComprar, double precioUnitarioCosto, Dinero dinero){
            double montoCompra = cantidadAComprar * precioUnitarioCosto;
            double dineroEnCuenta = dinero.obtenerCantidadDisponible();
            if(dineroEnCuenta >= montoCompra){
                cantidad += cantidadAComprar;
                dineroEnCuenta -= montoCompra;
                dinero.establecerCantidadDisponible(dineroEnCuenta);
            } 
            else{
                cantidadAComprar = 0;
                Console.WriteLine("No contamos con fondos suficientes para llevar a cabo esta compra.");
            }
        }

        public void venderProducto(int cantidadVendida, double precioUnitarioVenta, Dinero dinero){
            double dineroEnCuenta = dinero.obtenerCantidadDisponible();
            if(cantidadVendida <= cantidad){
                double precioVenta = cantidadVendida * precioUnitarioVenta;
                double ratio = 0.2;
                if (enPromocion && cantidadVendida >= 5){
                    precioVenta = precioVenta * (1 - ratio);
                }
                cantidad -= cantidadVendida;
                dineroEnCuenta += precioVenta;
                dinero.establecerCantidadDisponible(dineroEnCuenta);
            }
            else{
                cantidadVendida = 0;
                Console.WriteLine("No contamos con suficiente stock para concretar esta venta.");
            }
        }

        #region Constructores
        public Producto(string nombreProducto, bool enPromocionProducto, int cantidadProducto, float precioUnitarioVentaProducto){
            nombre = nombreProducto;
            enPromocion = enPromocionProducto;
            cantidad = cantidadProducto;            
            precioUnitarioVenta = precioUnitarioVentaProducto;
        }

        public Producto(string nombreProducto, bool enPromocionProducto, int cantidadProducto, float precioUnitarioVentaProducto,
        float precioUnitarioCostoProducto):this(nombreProducto, enPromocionProducto,
        cantidadProducto, precioUnitarioVentaProducto){
            precioUnitarioCosto = precioUnitarioCostoProducto;
        }

        public override string ToString()
        {
            return $"Producto: {nombre}, En promoción: {enPromocion}, Cantidad: {cantidad}.\nPrecio unitario de venta: {precioUnitarioVenta}, Precio unitario de costo: {precioUnitarioCosto}";
        }

        #endregion
    }
}
