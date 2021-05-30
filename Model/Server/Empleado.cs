using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Server
{
    public class Empleado
    {
        private VectorEstado vectorEstado;

        public string Estado { get; set; }     
        public double ACTiempoLibre { get; set; }   

        public Empleado(VectorEstado vectorEstado){
            this.vectorEstado = vectorEstado;
            ACTiempoLibre = 0;
            Libre();
        }

        public bool EstaOcupado(){
            return Estado == "Ocupado";
        }

        public void Libre()
        {
            Estado = "Libre";
        }

        private void Ocupado()
        {
            Estado = "Ocupado";
        }

        public void Atender(Persona persona)
        {
            Ocupado();
            persona.ProximoFin = vectorEstado.FinEntrega.RegistrarEvento();
        }

        public void Preparar(Empleado anterior)
        {
            Estado = anterior.Estado;
            ACTiempoLibre = anterior.ACTiempoLibre;
        }

        public void ActualizarTiempoLibre()
        {
            // Por el momento, su estado es el de la itración previa
            if (!EstaOcupado()){
                ACTiempoLibre += vectorEstado.Reloj - vectorEstado.Anterior.Reloj;
            }
        }
    }
}