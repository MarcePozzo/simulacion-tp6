using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.Entidades;
using Simulacion_TP6.Entidades.Randoms;

namespace Simulacion_TP6.Entidades.Modelo
{
    class Pedido
    {
        // los pedidos llegan con una distribucion exponencial con media de 3 pedidos por hora
        // eso quiere decir, 1/20 pedidos por minuto
        private GeneradorVAExponencialNegativa generadorVA = new GeneradorVAExponencialNegativa(new MetodoLenguaje(), 1d/20d);
        public double tiempo { get; set; } = 0;
        public double llegada { get; set; } = 0;
        public int numeroPedido { get; set; } = 0;
        public void calcularTiempo(double reloj)
        {
            this.tiempo = generadorVA.ObtenerSiguiente().ValorAleatorio;
            this.llegada = this.tiempo + reloj;
            this.numeroPedido++;
        }
    }
}
