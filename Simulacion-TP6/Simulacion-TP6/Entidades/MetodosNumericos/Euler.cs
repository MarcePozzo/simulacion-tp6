using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_TP6.InterfacesUsuario;

namespace Simulacion_TP6.Entidades.MetodosNumericos
{
    class Euler : IMetodoNumerico
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

            if (graficar)
            {
                this.agregarFila(resultado, t, x, y, yd);
            }

            int contadorPicos = 0;
            double valorAnterior = 0;
            double valorPico = 0;

            while (contadorPicos < 2)
            {
                t = t + h;
                x = x + y * h;
                y = y + yd * h;
                yd = this.derivadaSegunda(a, b, c, y, x, t);

                if (valorPico > x && valorPico > valorAnterior)
                {
                    contadorPicos++;
                }
                valorAnterior = valorPico;
                valorPico = x;
                if (graficar)
                {
                    this.agregarFila(resultado, t, x, y, yd);
                }
            }

            resultado.tiempo = t;
            resultado.valor = valorPico;

            if(graficar)
            {
                this.graficar(formMetodos, resultado);
            }

            return resultado;
        }

        private void graficar(FormMetodos formMetodos, ResultadoMetodoNumerico resultado)
        {
            formMetodos.getDataGridViewEuler().DataSource = resultado.tabla;

            formMetodos.getInputTiempoPicoEuler().Value = (decimal)resultado.tiempo;
            formMetodos.getInputValorPicoEuler().Value = (decimal)resultado.valor;

            foreach (DataRow row in resultado.tabla.Rows)
            {
                double t = Double.Parse((String)row.ItemArray[0]);
                double x = Double.Parse((String)row.ItemArray[1]);
                double xPrima = Double.Parse((String)row.ItemArray[2]);
                double xPrimaSegunda = Double.Parse((String)row.ItemArray[3]);

                formMetodos.getChartEuler().Series[0].Points.AddXY(t, xPrimaSegunda);
                formMetodos.getChartEuler().Series[1].Points.AddXY(t, xPrima);
                formMetodos.getChartEuler().Series[2].Points.AddXY(t, x);

                formMetodos.getChartXSegundaEnFuncionDeXEuler().Series[0].Points.AddXY(Math.Round(x, 4), xPrimaSegunda);
                formMetodos.getChartXPrimeraEnFuncionDeXEuler().Series[0].Points.AddXY(Math.Round(x, 4), xPrima);
                formMetodos.getChartXSegundaEnFuncionDeXPrimeraEuler().Series[0].Points.AddXY(Math.Round(xPrima, 4), xPrimaSegunda);
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
        }

        private void agregarFila(ResultadoMetodoNumerico resultado, double t, double x, double y, double yd)
        {
            List<String> fila = new List<string>();
            fila.Add(t.ToString());
            fila.Add(x.ToString());
            fila.Add(y.ToString());
            fila.Add(yd.ToString());
            this.agregarFila(resultado, fila);
        }

        private void agregarFila(ResultadoMetodoNumerico resultado, List<String> fila)
        {
            resultado.tabla.Rows.Add(fila.ToArray());
        }
    }
}
