using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Controlador controlador = new Controlador();
            controlador.simular(this, cantidadSimulaciones, mostrarDesde, cantidadMostrar, pedidosPorHoraProbabilidad);
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
