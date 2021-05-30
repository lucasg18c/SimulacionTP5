using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Server
{
    public class Duenio
    {
        private VectorEstado vectorEstado;

        public string Estado { get; set; }
        public int Cola { get; set; }
        public int MayorCola { get; set; }
        public double ACTiempoLibre { get; set; }

        public Duenio(VectorEstado vectorEstado){
            Libre();
            Cola = 0;
            ACTiempoLibre = 0;
            this.vectorEstado = vectorEstado;
        }

        public void AtenderCompra(Persona atendiendo){            
            Ocupado();
            atendiendo.ProximoFin = vectorEstado.FinCompra.RegistrarEvento();
        }

        public void Libre(){
            Estado = "Libre";
        }

        public void ReducirCola()
        {
            Cola--;
        }

        public void Ocupado(){
            Estado = "Ocupado";
        }

        public bool EstaOcupado(){
            return Estado == "Ocupado";
        }

        public void AumentarCola(){
            Cola++;
            if (Cola > MayorCola){
                MayorCola = Cola;
            }
        }

        public void Preparar()
        {
            Estado = vectorEstado.Anterior.Duenio.Estado;
            Cola = vectorEstado.Anterior.Duenio.Cola;
            MayorCola = vectorEstado.Anterior.Duenio.MayorCola;
            ACTiempoLibre = vectorEstado.Anterior.Duenio.ACTiempoLibre;
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