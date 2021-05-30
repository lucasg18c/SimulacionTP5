namespace SimulacionTP5.Model.Event
{
    public abstract class EventoBase
    {
        protected VectorEstado vectorEstado;

        public EventoBase(VectorEstado vectorEstado)
        {
            this.vectorEstado = vectorEstado;
        }

        public double Tiempo { get; set; }
        public double EntreTiempo { get; set; }        

        protected abstract double CalcularEntreTiempo();
        public abstract void Ejecutar();

        /// <summary> Calcula, almacena y retorna el próximo tiempo de fin para un evento.</summary>
        /// <returns>Próximo fin del evento.</returns>
        public double RegistrarEvento(){
            CalcularProximo();
            return Tiempo;
        }

        protected virtual void CalcularProximo()
        {
            EntreTiempo = CalcularEntreTiempo();
            Tiempo = vectorEstado.Reloj + EntreTiempo;
        }

        public virtual double GetTiempo(){
            return Tiempo;
        }

        public abstract string GetNombre();
    }
}