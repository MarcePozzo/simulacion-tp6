using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP6.Entidades.Modelo
{
    class ProximoEvento
    {
        public double reloj { get; set; }
        public String evento { get;set; }

        public ProximoEvento(double reloj, String evento)
        {
            this.reloj = reloj;
            this.evento = evento;
        }
    }
}
