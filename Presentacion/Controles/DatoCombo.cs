using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimulacionTP1.Presentacion.ControlesUsuario
{
    public partial class DatoCombo : UserControl
    {
        public DatoCombo()
        {
            InitializeComponent();
            CargarCombo();
        }

        private void CargarCombo()
        {
            cmbValor.Items.Add(5);
            cmbValor.Items.Add(10);
            cmbValor.Items.Add(15);
            cmbValor.Items.Add(20);
            cmbValor.SelectedIndex = 1;
        }

        public Color ColorHover { get; set; } = Color.FromArgb(49, 63, 82);
        public Color ColorFondo { get; set; } = Color.FromArgb(38, 49, 64);

        public string Texto
        {
            get { return lblNombreCampo.Text; }
            set { lblNombreCampo.Text = value; }
        }

        public int Valor
        {
            get { return Convert.ToInt32(cmbValor.Text); }
        }

        private void Hover(object sender, EventArgs e)
        {
            BackColor = ColorHover;
        }

        private void CambioDimensiones(object sender, EventArgs e)
        {
            cmbValor.Height = lblNombreCampo.Height;
        }

        private void MouseSale(object sender, EventArgs e)
        {
            BackColor = ColorFondo;
        }
    }
}
