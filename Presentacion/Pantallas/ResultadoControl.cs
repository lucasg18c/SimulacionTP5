using System;
using System.Windows.Forms;

namespace SimulacionTP5.Presentacion.Pantallas
{
    public partial class ResultadoControl : PantallaBase
    {
        public ResultadoControl()
        {
            InitializeComponent();
            IniciarTabla();
        }

        public void MostrarTabla(string[][] tabla)
        {
            foreach (string[] fila in tabla)
            {
                this.tabla.Rows.Add(fila);
            }
        }

        public void LimpiarTabla()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
        }

        public void MostrarColumnas(string[] columnas)
        {
            for (int i = 0; i < columnas.Length; i++)
            {
                tabla.Columns.Add($"col{i}", columnas[i]);
            }
        }

        public void MostrarResultado(string OcioE1, string OcioE2, string OcioDuenio, string colaEmpleados, string colaDuenio, string tiempoCafe, string tiempoColas)
        {
            lblOcioEmpleado1.Text = OcioE1;
            lblOcioEmpleado2.Text = OcioE2;
            lblOcioDuenio.Text = OcioDuenio;

            lblColaEmpleados.Text = colaEmpleados;
            lblColaDuenio.Text = colaDuenio;

            lblTiempoCola.Text = tiempoColas;
            lblTiempoCafe.Text = tiempoCafe;
        }

        private void IniciarTabla()
        {
            foreach (DataGridViewColumn column in tabla.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
