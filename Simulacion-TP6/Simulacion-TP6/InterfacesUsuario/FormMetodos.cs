using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Simulacion_TP6.Entidades;
using Simulacion_TP6.Entidades.MetodosNumericos;
using Simulacion_TP6.Entidades.Randoms;

namespace Simulacion_TP6.InterfacesUsuario
{
    public partial class FormMetodos : Form
    {
        private ControladorMetodosNumericos controlador = new ControladorMetodosNumericos();
        public FormMetodos()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.chartEuler.Series[0].Points.Clear();
            this.chartEuler.Series[1].Points.Clear();
            this.chartEuler.Series[2].Points.Clear();

            this.chartXSegundaEnFuncionDeXEuler.Series[0].Points.Clear();
            this.chartXPrimeraEnFuncionDeXEuler.Series[0].Points.Clear();
            this.chartXSegundaEnFuncionDeXPrimeraEuler.Series[0].Points.Clear();

            this.chartRK.Series[0].Points.Clear();
            this.chartRK.Series[1].Points.Clear();
            this.chartRK.Series[2].Points.Clear();

            this.chartXSegundaEnFuncionDeXRK.Series[0].Points.Clear();
            this.chartXPrimeraEnFuncionDeXRK.Series[0].Points.Clear();
            this.chartXSegundaEnFuncionDeXPrimeraRK.Series[0].Points.Clear();

            double aDesde = (double)this.inputCoeficienteADesdeSimulacion.Value;
            double aHasta = (double)this.inputCoeficienteAHastaSimulacion.Value;
            double a = new GeneradorVAUniforme(new MetodoLenguaje(), aDesde, aHasta).ObtenerSiguiente().ValorAleatorio;

            this.inputValorA.Value = (decimal)a;

            double b = (double)this.inputCoeficienteBSimulacion.Value;
            double c = (double)this.inputCoeficienteCSimulacion.Value;
            double h = (double)this.inputCoeficienteHSimulacion.Value;
            double x0 = (double)this.inputCoeficienteX0Simulacion.Value;
            double y0 = (double)this.inputCoeficienteXPrima0Simulacion.Value;

            controlador.simular(this, a, b, c, h, x0, y0);
        }

        public DataGridView getDataGridViewEuler()
        {
            return this.dataGridViewEuler;
        }

        public Chart getChartEuler()
        {
            return this.chartEuler;
        }

        public Chart getChartXSegundaEnFuncionDeXEuler()
        {
            return this.chartXSegundaEnFuncionDeXEuler;
        }

        public Chart getChartXPrimeraEnFuncionDeXEuler()
        {
            return this.chartXPrimeraEnFuncionDeXEuler;
        }

        public Chart getChartXSegundaEnFuncionDeXPrimeraEuler()
        {
            return this.chartXSegundaEnFuncionDeXPrimeraEuler;
        }

        public DataGridView getDataGridViewRK()
        {
            return this.dataGridViewRK;
        }

        public Chart getChartRK()
        {
            return this.chartRK;
        }

        public Chart getChartXSegundaEnFuncionDeXRK()
        {
            return this.chartXSegundaEnFuncionDeXRK;
        }

        public Chart getChartXPrimeraEnFuncionDeXRK()
        {
            return this.chartXPrimeraEnFuncionDeXRK;
        }

        public Chart getChartXSegundaEnFuncionDeXPrimeraRK()
        {
            return this.chartXSegundaEnFuncionDeXPrimeraRK;
        }

        public NumericUpDown getInputTiempoPicoEuler()
        {
            return this.inputTiempoPicoEuler;
        }

        public NumericUpDown getInputValorPicoEuler()
        {
            return this.inputValorPicoEuler;
        }

        public NumericUpDown getInputTiempoPicoRK()
        {
            return this.inputTiempoPicoRK;
        }

        public NumericUpDown getInputValorPicoRK()
        {
            return this.inputValorPicoRK;
        }
    }
}
