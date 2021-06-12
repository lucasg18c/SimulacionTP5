using System;
using System.Collections.Generic;

namespace SimulacionTP5.Presentacion.Pantallas
{
    public partial class TiemposLimpiezaControl : PantallaBase
    {
        public TiemposLimpiezaControl()
        {
            InitializeComponent();
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

        public void MostrarTabla(List<string[]> tabla)
        {
            foreach (string[] fila in tabla) this.tabla.Rows.Add(fila);

            if (tabla.Count == 0)
            {
                this.tabla.Visible = false;
                lblSinTabla.Visible = true;
            }
            else
            {
                this.tabla.Visible = true;
                lblSinTabla.Visible = false;
            }
        }

        public bool EstaMostrandoTabla()
        {
            return tabla.Visible;
        }
    }
}
