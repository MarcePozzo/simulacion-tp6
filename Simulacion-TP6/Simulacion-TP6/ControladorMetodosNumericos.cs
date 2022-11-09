using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.Entidades.MetodosNumericos;
using Simulacion_TP6.InterfacesUsuario;

namespace Simulacion_TP6
{
    class ControladorMetodosNumericos
    {
        private IMetodoNumerico metodoEuler = new Euler();
        private IMetodoNumerico metodoRK = new RungeKutta();

        public void simular(FormMetodos formMetodos, double a, double b, double c, double h, double x0, double y0, double cantidadPicos)
        {
            metodoEuler.calcular(formMetodos, a, b, c, h, x0, y0, true, cantidadPicos);
            metodoRK.calcular(formMetodos, a, b, c, h, x0, y0, true, cantidadPicos);
        }
    }
}
