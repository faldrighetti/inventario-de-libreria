using System;

namespace Clases{
    public class Dinero{
        private double cantidadDisponible;

        public Dinero(long dineroEnCaja){
            cantidadDisponible = dineroEnCaja;
        }

        public double obtenerCantidadDisponible(){
            return cantidadDisponible;
        }

        public double establecerCantidadDisponible(double cantidad){
            cantidadDisponible = cantidad;
            return cantidadDisponible;
        }

        public override string ToString()
        {
            return $"Cantidad disponible: ${obtenerCantidadDisponible()}";
        }
    }
}