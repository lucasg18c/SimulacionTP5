using System;
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
        public double Remanente { get; set; }

        public void FinLimpieza()
        {
            if (Remanente != 0)
            {
                Ocupado();
                Remanente += vectorEstado.Reloj;
                vectorEstado.BuscarPersonaBloqueada().Desbloquear(Remanente);
                vectorEstado.FinCompra.FinInterrupcion(Remanente);
                Remanente = 0;
            }
            
            else if (Cola > 0)
            {
                ReducirCola();
                Persona p = vectorEstado.BuscarProximaEAC();
                p.SiendoAtendidoCompra();
                AtenderCompra(p);
            }
            else
            {
                Libre();
            }
        }

        public Duenio(VectorEstado vectorEstado){
            Libre();
            Cola = 0;
            ACTiempoLibre = 0;
            this.vectorEstado = vectorEstado;
        }

        public void Limpiando()
        {
            if (EstaOcupado())
            {
                vectorEstado.BuscarPersonaSAC().Bloquear();
                Remanente = vectorEstado.FinCompra.Tiempo - vectorEstado.Reloj;
                vectorEstado.FinCompra.Interrumpir();
            }

            Estado = "Limpiando";
        }

        public string[] Mostrar(){
            return new string[] {
                Estado,
                Cola.ToString(),
                MayorCola.ToString(),
                Math.Round(ACTiempoLibre, 2).ToString(),
                Remanente == 0 ? "" : Math.Round(Remanente, 2).ToString()
            };
        }

        public void AtenderCompra(Persona atendiendo){            
            Ocupado();
            atendiendo.ProximoFin = vectorEstado.FinCompra.RegistrarEvento();
        }

        public bool EstaLimpiando()
        {
            return Estado == "Limpiando";
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
            Remanente = vectorEstado.Anterior.Duenio.Remanente;
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