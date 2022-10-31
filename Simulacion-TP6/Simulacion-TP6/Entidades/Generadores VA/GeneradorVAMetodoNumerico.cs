using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.Entidades.Interfaces;
using Simulacion_TP6.Entidades.MetodosNumericos;
using Simulacion_TP6.Entidades.Randoms;

namespace Simulacion_TP6.Entidades.Generadores_VA
{
    class GeneradorVAMetodoNumerico : IGeneradorVA
    {
        private IMetodoNumerico metodo;
        private IGeneradorVA generador;
        double aDesde;
        double aHasta;
        double b;
        double c;
        double h;
        double x0;
        double y0;
        public GeneradorVAMetodoNumerico(IMetodoNumerico metodo, double aDesde, double aHasta, double b, double c, double h, double x0, double y0)
        {
            this.metodo = metodo;
            this.aDesde = aDesde;
            this.aHasta = aHasta;
            this.b = b;
            this.c = c;
            this.h = h;
            this.x0 = x0;
            this.y0 = y0;
            this.generador = new GeneradorVAUniforme(new MetodoLenguaje(), this.aDesde, this.aHasta);
        }
        public BindingList<VariableAleatoria> generarListaVA(double cantidad, [Optional] BindingList<VariableAleatoria> listaCompletar)
        {
            throw new NotImplementedException();
        }

        public VariableAleatoria ObtenerEstadoActual()
        {
            throw new NotImplementedException();
        }

        public VariableAleatoria ObtenerSiguiente()
        {
            VariableAleatoria variableAleatoria = new VariableAleatoria();
            double a = generador.ObtenerSiguiente().ValorAleatorio;
            ResultadoMetodoNumerico resultado = metodo.calcular(null, a, this.b, this.c, this.h, this.x0, this.y0, false);
            variableAleatoria.ValorAleatorio = resultado.valor;
            return variableAleatoria;
        }
    }
}
