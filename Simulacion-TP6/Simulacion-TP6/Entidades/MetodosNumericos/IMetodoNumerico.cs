using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.InterfacesUsuario;

namespace Simulacion_TP6.Entidades.MetodosNumericos
{
    interface IMetodoNumerico
    {
        ResultadoMetodoNumerico calcular(FormMetodos formMetodos, double a, double b, double c, double h, double x0, double y0, Boolean graficar);
    }
}
