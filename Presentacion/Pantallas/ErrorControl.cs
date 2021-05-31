namespace SimulacionTP5.Presentacion.Pantallas
{
    public partial class ErrorControl : PantallaBase
    {
        public ErrorControl()
        {
            InitializeComponent();
        }

        public void MostrarError(string mensaje)
        {
            mensajeError.Text = mensaje;
            Visible = true;
        }
    }
}
