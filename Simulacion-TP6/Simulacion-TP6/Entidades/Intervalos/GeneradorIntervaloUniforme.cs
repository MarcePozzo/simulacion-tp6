using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.Entidades.Interfaces;

namespace Simulacion_TP6.Entidades
{
    class GeneradorIntervaloUniforme : GeneradorIntervalo
    {
        public GeneradorIntervaloUniforme(BindingList<VariableAleatoria> variablesAleatorias, int cantidadIntervalos) : base(variablesAleatorias, cantidadIntervalos)
        {
            
        }

        protected override double getFrecuenciaEsperada(double limiteInferior, double limiteSuperior)
        {
            return this.variablesAleatorias.Count / this.cantidadIntervalos;
        }
    }
}
