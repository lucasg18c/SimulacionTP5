using SimulacionTP5.Servicios;
using System;
using System.Windows.Forms;

namespace SimulacionTP5.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        private readonly GestorCafeteria gestor;
        public FrmPrincipal()
        {
            InitializeComponent();
            gestor = new GestorCafeteria(this);
        }
        private void ClickBtnCalcular(object sender, System.EventArgs e)
        {
            gestor.Calcular();
        }

        public double GetMediaLlegada()
        {
            return txtMediaLlegada.Valor;
        }
        public double GetDesviacionLlegada()
        {
            return txtDesviacionLlegada.Valor;
        }
        public double GetDuracionCompra()
        {
            return txtDuracionCompra.Valor;
        }
        public double GetDesdeUsoMesa()
        {
            return txtDesdeUsoMesa.Valor;
        }
        public double GetHastaUsoMesa()
        {
            return txtHastaUsoMesa.Valor;
        }
        public double GetDesdeConsumo()
        {
            return txtDesdeConsumo.Valor;
        }
        public double GetHastaConsumo()
        {
            return txtHastaConsumo.Valor;
        }

        public int GetIterciones()
        {
            return (int)txtIteraciones.Valor;
        }
        public int GetMostrarDesde()
        {
            return (int)txtMostrarDesde.Valor;
        }
        public int GetCantidadAMostar()
        {
            return (int)txtCantidadMostrar.Valor;
        }

        public void MostrarTabla(string[] fila)
        {
            tablaCafeteria.Rows.Add(fila);
        }

        public void MostrarColumnas(string nombre, string cabecera)
        {
            tablaCafeteria.Columns.Add(nombre, cabecera);
        }

        public double GetMediaEntrega()
        {
            return txtMediaEntrega.Valor;
        }
        public void MostrarExcepcion(string excepcion)
        {
            MessageBox.Show(
                excepcion,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void LimpiarTabla()
        {
            tablaCafeteria.Columns.Clear();
            tablaCafeteria.Rows.Clear();
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

        private void ClickBtnExportar(object sender, EventArgs e)
        {
            gestor.Exportar();
        }
    }
}
