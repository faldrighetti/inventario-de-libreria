using System;
using Clases;

namespace Clases
{
    public class Producto{
        public string nombre;
        public bool enPromocion;
        public int cantidad;
        public double precioUnitarioVenta;
        public double precioUnitarioCosto;

        public void comprarProducto(int cantidadAComprar, double precioUnitarioCosto, Dinero dinero){
            double montoCompra = cantidadAComprar * precioUnitarioCosto;
            if(dinero.cantidadDisponible >= montoCompra){
                cantidad += cantidadAComprar;
                dinero.cantidadDisponible -= montoCompra;
            } 
            else{
                Console.WriteLine("No contamos con fondos suficientes para llevar a cabo esta compra.");
            }
        }

        public void venderProducto(int cantidadVendida, double precioUnitarioVenta, Dinero dinero){
            if(cantidadVendida <= cantidad){
                double precioVenta = cantidadVendida * precioUnitarioVenta;
                double ratio = 0.2;
                if (enPromocion && cantidadVendida >= 5){
                    precioVenta = precioVenta * (1 - ratio);
                }
                cantidad -= cantidadVendida;
                dinero.cantidadDisponible += precioVenta;
            }
            else{
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
        #endregion
    }
}

/*TODO:
-Cambiar los atributos públicos a privados y modificar las funciones en consecuencia
-Atrapar los movimientos de dinero en la clase dinero, relacionándolos con Program y Producto
-Agregar producto
-Crear HTML con 4 opciones select: Mostrar stock, comprar a proveedor (verificar si ya existe el producto y sino, crearlo), vender con tarjeta, vender con efectivo.
-Relacionar el HTML con los archivos .cs
*/