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
    }
}
