using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.Entidades.Interfaces;

namespace Simulacion_TP6.Entidades
{
    class Servidor
    {
        private IGeneradorVA generadorVA;
        private List<Cola> colas = new List<Cola>();
        public Boolean ocupado { get; set; } = false;
        public Boolean estabaOcupado { get; set; } = false;
        public double tiempo { get; set; } = 0;
        public double tiempoFinalizacion { get; set; } = 0;
        public int numeroPedido { get; set; } = 0;
        public int numeroPedidoAnterior { get; set; } = 0;
        public double tiempoPromedio { get; set; } = 0;
        public double tiempoOcupadoAcumulado = 0;
        public double tiempoBloqueadoAcumulado = 0;

        // PUNTO 8
        public double porcentajeTiempoOcupado = 0;

        // PUNTO 9
        public double porcentajeTiempoBloqueado = 0;
        public double proporcioneBloqueoRespectoOcupacion = 0;

        public Servidor(int cantidadColas, IGeneradorVA generadorVA)
        {
            this.generadorVA = generadorVA;
            for (int i = 0; i < cantidadColas; i++)
            {
                this.colas.Add(new Cola());
            }
        }
        public void tomarPedido(double reloj, int indiceCola)
        {
            // si estoy ocupado no puedo tomar el pedido, sumo uno a la cola correspondiente
            if (this.ocupado)
            {
                this.getCola(indiceCola).sumar();
            } else
            {
                // sino, tengo que ver si puedo ensamblar.
                // solo puede ensamblar si hay al menos 1 elemento en las otras colases
                Boolean puedeEnsamblar = true;
                for (int i = 0; i < this.colas.Count; i++)
                {
                    if (i != indiceCola)
                    {
                        Cola cola = this.colas.ElementAt(i);
                        // si hay al menos una cola sin elementos, no puedo ensamblar
                        if (cola.cantidad == 0)
                        {
                            puedeEnsamblar = false;
                        }
                    }
                }
                if (puedeEnsamblar)
                {
                    // si puedo ensamblar, calculo cuanto tiempo me toma y me pongo ocupado
                    this.sumarPedido(reloj);
                    if (this.generadorVA != null)
                    {
                        this.cambiarEstado(true);
                    } else
                    {
                        this.finalizarTarea(reloj);
                    }
                } else
                {
                    // si no puedo ensamblar, sumo uno a la cola correspondiente
                    this.getCola(indiceCola).sumar();
                }
            }
        }

        public void finalizarTarea(double reloj)
        {
            Boolean puedoEnsamblar = true;
            this.colas.ForEach(cola =>
            {
                if (cola.cantidad == 0)
                {
                    puedoEnsamblar = false;
                } else
                {
                    cola.restar();
                }
            });
            if (puedoEnsamblar)
            {
                this.sumarPedido(reloj);
            } else
            {
                this.cambiarEstado(false);
                this.tiempo = 0;
                this.tiempoFinalizacion = 0;
            }
        }

        private void cambiarEstado(Boolean ocupado)
        {
            this.estabaOcupado = this.ocupado;
            this.ocupado = ocupado;
        }

        private void sumarPedido(double reloj)
        {
            if (this.generadorVA != null)
            {
                this.tiempo = this.generadorVA.ObtenerSiguiente().ValorAleatorio;
            } else
            {
                this.tiempo = 0;
            }
            this.tiempoFinalizacion = this.tiempo + reloj;
            if (this.numeroPedido != 0)
            {
                this.tiempoPromedio = this.tiempoFinalizacion / this.numeroPedido;
            }
            this.numeroPedidoAnterior = this.numeroPedido;
            this.numeroPedido++;
        }

        public Cola getCola(int index)
        {
            return this.colas.ElementAt(index);
        }
        public List<Cola> getColas()
        {
            return this.colas;
        }
        public String getEstado()
        {
            if (this.ocupado)
            {
                return "OCUPADO";
            }
            return "LIBRE";
        }
        public void calcularPorcentajeOcupacionServidor(double reloj, double relojAnterior)
        {
            if (reloj != 0)
            {
                if (this.estabaOcupado)
                {
                    this.tiempoOcupadoAcumulado = reloj - relojAnterior + this.tiempoOcupadoAcumulado;
                }
                this.porcentajeTiempoOcupado = (this.tiempoOcupadoAcumulado / reloj) * 100;
            }
        }
        
        public void calcularPorcentajeBloqueoServidor(double reloj, double relojAnterior)
        {
            if (reloj != 0)
            {
                if (!this.estabaOcupado)
                {
                    this.tiempoBloqueadoAcumulado = reloj - relojAnterior + this.tiempoBloqueadoAcumulado;
                }
                this.porcentajeTiempoBloqueado = (this.tiempoBloqueadoAcumulado / reloj) * 100;
            }
        } 
        public void  calcularProporcioneBloqueoRespectoOcupacion()
        {
            var proporcionOcupacion = this.porcentajeTiempoOcupado / 100;
            var proporcionBloqueo = this.porcentajeTiempoBloqueado / 100;
            var proporcion = proporcionBloqueo / proporcionOcupacion;
            proporcioneBloqueoRespectoOcupacion = proporcion <= 1 ? proporcion : 1;

        }
    }
}
