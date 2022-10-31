using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.InterfacesUsuario;

namespace Simulacion_TP6.Entidades.MetodosNumericos
{
    class RungeKutta : IMetodoNumerico
    {
        public ResultadoMetodoNumerico calcular(FormMetodos formMetodos, double a, double b, double c, double h, double x0, double y0, Boolean graficar)
        {
            ResultadoMetodoNumerico resultado = new ResultadoMetodoNumerico();

            if (graficar)
            {
                this.agregarColumnas(resultado);
            }

            double t = 0;
            double x = x0;
            double y = y0;
            double yd = this.derivadaSegunda(a, b, c, y, x, t);
            double l1 = h * yd;
            double k1 = h * y;
            double l2 = h * derivadaSegunda(a, b, c, (x + 0.5 * k1), (y + 0.5 * l1), (t + 0.5 * h));
            double k2 = h * (y + 0.5 * l1);
            double l3 = h * derivadaSegunda(a, b, c, (x + 0.5 * k2), (y + 0.5 * l2), (t + 0.5 * h));
            double k3 = h * (y + 0.5 * l2);
            double l4 = h * derivadaSegunda(a, b, c, (x + k3), (y + l3), (t + h));
            double k4 = h * (y + l3);

            if (graficar)
            {
                this.agregarFila(resultado, t, x, y, yd, k1, k2, k3, k4, l1, l2, l3, l4);
            }

            int contadorPicos = 0;
            double valorAnterior = 0;
            double valorPico = 0;

            while (contadorPicos < 2)
            {
                t = t + h;
                x = x + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                y = y + (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                yd = derivadaSegunda(a, b, c, y, x, t);
                l1 = h * yd;
                k1 = h * y;
                l2 = h * derivadaSegunda(a, b, c, (y + 0.5 * l1), (x + 0.5 * k1), (t + 0.5 * h));
                k2 = h * (y + 0.5 * l1);
                l3 = h * derivadaSegunda(a, b, c, (y + 0.5 * l2), (x + 0.5 * k2), (t + 0.5 * h));
                k3 = h * (y + 0.5 * l2);
                l4 = h * derivadaSegunda(a, b, c, (y + l3), (x + k3), (t + h));
                k4 = h * (y + l3);

                if (valorPico > x && valorPico > valorAnterior)
                {
                    contadorPicos++;
                }
                valorAnterior = valorPico;
                valorPico = x;

                if (graficar)
                {
                    this.agregarFila(resultado, t, x, y, yd, k1, k2, k3, k4, l1, l2, l3, l4);
                }
            }

            resultado.tiempo = t;
            resultado.valor = valorPico;

            if (graficar)
            {
                this.graficar(formMetodos, resultado);
            }

            return resultado;
        }

        private void graficar(FormMetodos formMetodos, ResultadoMetodoNumerico resultado)
        {
            formMetodos.getDataGridViewRK().DataSource = resultado.tabla;

            formMetodos.getInputTiempoPicoRK().Value = (decimal)resultado.tiempo;
            formMetodos.getInputValorPicoRK().Value = (decimal)resultado.valor;

            foreach (DataRow row in resultado.tabla.Rows)
            {
                double t = Double.Parse((String)row.ItemArray[0]);
                double x = Double.Parse((String)row.ItemArray[1]);
                double xPrima = Double.Parse((String)row.ItemArray[2]);
                double xPrimaSegunda = Double.Parse((String)row.ItemArray[3]);

                formMetodos.getChartRK().Series[0].Points.AddXY(t, xPrimaSegunda);
                formMetodos.getChartRK().Series[1].Points.AddXY(t, xPrima);
                formMetodos.getChartRK().Series[2].Points.AddXY(t, x);

                formMetodos.getChartXSegundaEnFuncionDeXRK().Series[0].Points.AddXY(Math.Round(x, 4), xPrimaSegunda);
                formMetodos.getChartXPrimeraEnFuncionDeXRK().Series[0].Points.AddXY(Math.Round(x, 4), xPrima);
                formMetodos.getChartXSegundaEnFuncionDeXPrimeraRK().Series[0].Points.AddXY(Math.Round(xPrima, 4), xPrimaSegunda);
            }
        }

        private double derivadaSegunda(double a, double b, double c, double y, double x, double t)
        {
            return -(a * y) - (b * x) + Math.Exp(-c * t);
        }

        private void agregarColumnas(ResultadoMetodoNumerico resultado)
        {
            resultado.tabla.Columns.Add("t");
            resultado.tabla.Columns.Add("x");
            resultado.tabla.Columns.Add("y = x'");
            resultado.tabla.Columns.Add("y'");
            resultado.tabla.Columns.Add("K1");
            resultado.tabla.Columns.Add("K2");
            resultado.tabla.Columns.Add("K3");
            resultado.tabla.Columns.Add("K4");
            resultado.tabla.Columns.Add("L1");
            resultado.tabla.Columns.Add("L2");
            resultado.tabla.Columns.Add("L3");
            resultado.tabla.Columns.Add("L4");
        }

        private void agregarFila(ResultadoMetodoNumerico resultado, double t, double x, double y, double yd,
            double k1, double k2, double k3, double k4,
            double l1, double l2, double l3, double l4)
        {
            List<String> fila = new List<string>();
            fila.Add(t.ToString());
            fila.Add(x.ToString());
            fila.Add(y.ToString());
            fila.Add(yd.ToString());
            fila.Add(k1.ToString());
            fila.Add(k2.ToString());
            fila.Add(k3.ToString());
            fila.Add(k4.ToString());
            fila.Add(l1.ToString());
            fila.Add(l2.ToString());
            fila.Add(l3.ToString());
            fila.Add(l4.ToString());
            this.agregarFila(resultado, fila);
        }

        private void agregarFila(ResultadoMetodoNumerico resultado, List<String> fila)
        {
            resultado.tabla.Rows.Add(fila.ToArray());
        }
    }
}
