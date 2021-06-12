using SimulacionTP5.Presentacion.Pantallas;
using SimulacionTP5.Servicios;
using System;
using System.Collections.Generic;
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
        private void ClickBtnSimular(object sender, EventArgs e)
        {
            gestor.Simular();
        }

        private void ClickBtnExportar(object sender, EventArgs e)
        {
            gestor.Exportar();
        }

        public double GetMediaLlegada()
        {
            return txtMediaLlegada.Valor;
        }
        public double GetDesviacionLlegada()
        {
            return txtDesviacionLlegada.Valor;
        }

        public void PermitirExportar(bool permitir)
        {
            btnExportar.Visible = permitir;
        }

        public void PermitirAlternar(bool permitir)
        {
            btnAlternar.Visible = permitir;
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
        public void MostrarPantallaResultado()
        {
            resultadoControl.Visible = true;
            inicioControl.Visible = false;
            errorControl.Visible = false;
            tiemposLimpiezaControl.Visible = false;
            btnAlternar.Text = "Ver R-K Limpieza";
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

        public void MostrarTabla(string[][] tabla)
        {
            resultadoControl.MostrarTabla(tabla);
        }

        public void MostrarColumnas(string[] columnas)
        {
            resultadoControl.MostrarColumnas(columnas);
        }

        public double GetMediaEntrega()
        {
            return txtMediaEntrega.Valor;
        }
        public void MostrarError(string error)
        {
            errorControl.MostrarError(error);
            inicioControl.Visible = false;
            resultadoControl.Visible = false;
            tiemposLimpiezaControl.Visible = false;
        }

        public void MostrarInformacion(string mensaje, string titulo)
        {
            MessageBox.Show(
                mensaje,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void LimpiarTabla()
        {
            resultadoControl.LimpiarTabla();
        }

        public void LimpiarTablaTiemposLimpieza()
        {
            tiemposLimpiezaControl.LimpiarTabla();
        }

        public void MostrarResultado(string OcioE1, string OcioE2, string OcioDuenio, string colaEmpleados, string colaDuenio, string tiempoCafe, string tiempoColas)
        {
            resultadoControl.MostrarResultado(OcioE1, OcioE2, OcioDuenio, colaEmpleados, colaDuenio, tiempoCafe, tiempoColas);
        }

        public void Esperar(bool esperar)
        {
            Cursor.Current = esperar ? Cursors.WaitCursor : Cursors.Default;
        }

        public void CopiarPortapapeles(string tabla)
        {
            Clipboard.SetText(tabla);
        }

        private void ClickBtnMenu(object sender, EventArgs e)
        {
            pnlLateral.Visible = !pnlLateral.Visible;
        }

        public void MostrarColumnasLimpieza(string[] columnas)
        {
            tiemposLimpiezaControl.MostrarColumnas(columnas);
        }

        public void MostrarTablaLimpieza(List<string[]> tabla)
        {
            tiemposLimpiezaControl.MostrarTabla(tabla);
        }

        private void ClickBtnAlternar(object sender, EventArgs e)
        {
            tiemposLimpiezaControl.Visible = !tiemposLimpiezaControl.Visible;
            resultadoControl.Visible = !resultadoControl.Visible;
            btnAlternar.Text = resultadoControl.Visible ? "Ver R-K Limpieza" : "Ver Simulación";

            btnExportar.Visible = (tiemposLimpiezaControl.Visible && tiemposLimpiezaControl.EstaMostrandoTabla()) || resultadoControl.Visible;
        }

        public bool EstaMostrandoResultado()
        {
            return resultadoControl.Visible;
        }
    }
}
