namespace SimulacionTP5.Model.Event
{
    public class Inicializar : EventoBase
    {
        public Inicializar(VectorEstado vectorEstado) : base(vectorEstado)
        {
        }

        public override void Ejecutar()
        {
            vectorEstado.Reloj = 0;
            vectorEstado.LlegadaPersona.RegistrarEvento();

            vectorEstado.Inestable.RegistrarEvento();
        }

        public override string GetNombre()
        {
            return "Inicialización";
        }

        public override string[] Mostrar()
        {
            return new string[]{};
        }

        protected override double CalcularEntreTiempo()
        {
            return 0;
        }
    }
}