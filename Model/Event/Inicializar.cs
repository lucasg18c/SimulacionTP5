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
        }

        public override string GetNombre()
        {
            return "Inicializar";
        }

        protected override double CalcularEntreTiempo()
        {
            return 0;
        }
    }
}