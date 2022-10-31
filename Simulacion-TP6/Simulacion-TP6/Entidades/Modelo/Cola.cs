using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP6.Entidades
{
    class Cola
    {
        public int cantidad { get; set; } = 0;
        // PUNTO 4
        public int cantidadMaxima { get; set; } = 0;
        public double tiempoAcumulado { get; set; } = 0;
        public double tiempoPromedio { get; set; } = 0;
        // PUNTO 5
        public double promedioPermanenciaEnCola { get; set; } = 0;
        // PUNTO 6
        public double promedioPedidosEnCola { get; set; } = 0;
        public void sumar()
        {
            this.cantidad++;
            if (this.cantidad > this.cantidadMaxima)
            {
                this.cantidadMaxima = this.cantidad;
            }
        }
        public void restar()
        {
            if (this.cantidad > 0)
            {
                this.cantidad--;
            }
        }

        public void calcularPromedios(double reloj, double relojAnterior, int pedidosSolicitados)
        {
            if (reloj != 0)
            {
                this.calcularTiempoAcumulado(reloj, relojAnterior);
                this.calcularPromedioPermanenciaEnCola(pedidosSolicitados);
                this.calcularPromedioPedidosEnCola(reloj);
            }
        }
        private void calcularTiempoAcumulado (double reloj, double relojAnterior)
        {
            this.tiempoAcumulado = this.cantidad * (reloj - relojAnterior) + this.tiempoAcumulado;
        }
        private void calcularPromedioPermanenciaEnCola(int pedidosSolicitados)
        {
            this.promedioPermanenciaEnCola = this.tiempoAcumulado / (double)pedidosSolicitados;
        }
        private void calcularPromedioPedidosEnCola(double reloj)
        {
            this.promedioPedidosEnCola = this.tiempoAcumulado / reloj;
        }
    }
}
