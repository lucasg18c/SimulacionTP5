using SimulacionTP5.Servicios;
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
        private void btnCalcular_Click(object sender, System.EventArgs e)
        {
            //gestor.Calcular();
        }

        public int GetMediaLlegada()
        {
            return (int)txtMediaLlegada.Valor * 60;
        }
        public int GetDesviacionLlegada()
        {
            return (int)txtDesviacionLlegada.Valor * 60;
        }
        public int GetSegundosFinCompra()
        {
            return (int)txtSegFinCompra.Valor;
        }
        public int GetSegundosDesdeFinUsoMesa()
        {
            return (int)txtDesdeFinMesa.Valor * 60;
        }
        public int GetSegundosHastaFinUsoMesa()
        {
            return (int)txtHastaFinMesa.Valor * 60;
        }
        public int GetSegundosDesdeFinConsumo()
        {
            return (int)txtDesdeFinConsumo.Valor * 60;
        }
        public int GetSegundosHastaFinConsumo()
        {
            return (int)txtHastaFinConsumo.Valor * 60;
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
            return (int)txtCantidadMostra.Valor;
        }
        public int GetFinEntrega()
        {
            return (int)txtSegFinEntrega.Valor;
        }
        public void MostrarExcepcion(string excepcion)
        {
            MessageBox.Show(
                excepcion,
                "Ocurrió un error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        /// <summary>
        /// 
        /// </summary>
        public void LimpiarTablaCalculo()
        {
            tablaCafeteria.Rows.Clear();
        }

        public void MostrarResultado(string OcioE_1, string OcioE_2, string OcioDueño, string promedioEnCola
            , string colaMaxDuenio, string lblColaMaxEmp)
        {
            lblTiempOciosoEmp1.Text = OcioE_1;
            lblTiempoOciosoEmp2.Text = OcioE_2;
            lblTimepoOciosoDueño.Text = OcioDueño;

            lblValorPromedioPermCola.Text = promedioEnCola;

            lblCantidadColaMaxDuenio.Text = colaMaxDuenio;
            lblCantidadColaMaxEmp.Text = lblColaMaxEmp;
            //PrepararVentana();
        }

        private void FrmPrincipal_Load(object sender, System.EventArgs e)
        {

        }
    }
}
