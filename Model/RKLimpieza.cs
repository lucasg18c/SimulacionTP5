using System;
using System.Collections.Generic;
using System.Linq;

namespace SimulacionTP5.Model
{
    public class RKLimpieza
    {
        private static readonly double beta = 0.00331050847186312;
        private static readonly double paso = 1;
        private List<double[]> tabla;

        public double Calcular(double llegadasAlSistema)
        {
            tabla = new List<double[]>();
            double[] previa = null;

            do
            {
                double[] fila = new double[13];

                if (previa == null)
                {
                    fila[0] = 0;
                    fila[1] = llegadasAlSistema;
                    fila[2] = 0;
                }
                else
                {
                    fila[0] = previa[10];
                    fila[1] = previa[1] + (paso / 6) * (previa[3] + 2 * previa[6] + 2 * previa[9] + previa[12]);
                    fila[2] = previa[1] - fila[1];
                }

                fila[3] = -0.5 * beta * fila[1];
                fila[4] = fila[0] + paso / 2;
                fila[5] = fila[1] + fila[3] * paso / 2;
                fila[6] = -0.5 * beta * fila[5];
                fila[7] = fila[4];
                fila[8] = fila[1] + fila[6] * paso / 2;
                fila[9] = -0.5 * beta * fila[8];
                fila[10] = fila[0] + paso;
                fila[11] = fila[1] + fila[9] * paso;
                fila[12] = -0.5 * beta * fila[11];

                tabla.Add(fila);
                previa = fila;
            }
            while (previa[2] >= .02 || previa[2] == 0);

            return tabla.Last()[0] / 10;
        }

        public List<string[]> GetTabla()
        {
            List<string[]> t = new List<string[]>();
            int n = tabla[0].Length;

            foreach (double[] fila in tabla)
            {
                string[] f = new string[n];

                for (int i = 0; i < n; i++)
                    f[i] = Math.Round(fila[i], 4).ToString();

                t.Add(f);
            }
            return t;
        }

        public void Limpiar()
        {
            tabla = null;
        }
    }
}
