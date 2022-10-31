using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP6.Entidades.MetodosNumericos
{
    class ResultadoMetodoNumerico
    {
        public DataTable tabla { get; set; } = new DataTable();
        public Double tiempo { get; set; } = 0;
        public Double valor { get; set; } = 0;
    }
}
