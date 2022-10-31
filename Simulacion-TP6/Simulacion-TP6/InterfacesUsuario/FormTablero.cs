using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP6.Entidades.MetodosNumericos;

namespace Simulacion_TP6.InterfacesUsuario
{
    public partial class FormTablero : Form
    {
        public FormTablero()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.dataGridViewSimulaciones.Rows.Clear();

            int cantidadSimulaciones = (int)this.inputCantidadSimulaciones.Value;
            int mostrarDesde = (int)this.inputMostrarDesde.Value;
            int cantidadMostrar = (int)this.inputCantidadMostrar.Value;
            double pedidosPorHoraProbabilidad = (double)this.inputPedidosPorHoraProbabilidad.Value;

            double aDesde = (double)this.inputCoeficienteADesdeSimulacion.Value;
            double aHasta = (double)this.inputCoeficienteAHastaSimulacion.Value;

            double b = (double)this.inputCoeficienteBSimulacion.Value;
            double c = (double)this.inputCoeficienteCSimulacion.Value;
            double h = (double)this.inputCoeficienteHSimulacion.Value;
            double x0 = (double)this.inputCoeficienteX0Simulacion.Value;
            double y0 = (double)this.inputCoeficienteXPrima0Simulacion.Value;

            String metodoNumerico = this.inputMetodoNumerico.Text;

            IMetodoNumerico metodo;
            if (metodoNumerico == "EULER")
            {
                metodo = new Euler();
            } else
            {
                this.inputMetodoNumerico.Text = "RK";
                metodo = new RungeKutta();
            }

            Controlador controlador = new Controlador();
            controlador.simular(this, cantidadSimulaciones, mostrarDesde, cantidadMostrar, pedidosPorHoraProbabilidad,
                metodo, aDesde, aHasta, b, c, h, x0, y0);
        }
        public void agregarFila(List<String> fila)
        {
            this.dataGridViewSimulaciones.Rows.Add(fila.ToArray());
        }
        public void agregarFilaSuspensiva()
        {
            List<String> fila = new List<String>();
            for (int i = 0; i < this.dataGridViewSimulaciones.Columns.Count; i++)
            {
                fila.Add("......");
            }
            this.dataGridViewSimulaciones.Rows.Add(fila.ToArray());
        }
    }
}
