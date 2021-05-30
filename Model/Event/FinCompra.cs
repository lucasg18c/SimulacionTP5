using System;
using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Event
{
    public class FinCompra : EventoBase
    {
        private double tiempoEntrega;
        private int idPersona;
        public FinCompra(VectorEstado vectorEstado, double tiempoEntrega) : base(vectorEstado)
        {
            this.tiempoEntrega = tiempoEntrega;
        }

        public override void Ejecutar()
        {
            Persona p = vectorEstado.BuscarPersonaSAC();
            p.RecibirEntrega();
            idPersona = p.Id;

            vectorEstado.Duenio.Libre();
            Tiempo = 0;

            AvanzarCola();
        }

        private void AvanzarCola()
        {
            if (vectorEstado.Duenio.Cola > 0)
            {
                vectorEstado.Duenio.ReducirCola();
                Persona proximaPersona = BuscarProximaEAC();
                proximaPersona.SiendoAtendidoCompra();
                vectorEstado.Duenio.AtenderCompra(proximaPersona);
            }
        }

        /// <summary> Busca la próxima persona en estado Esperando Atención Compra, según su tiempo de llegada.</summary>
        private Persona BuscarProximaEAC()
        {
            Persona proxima = null;

            foreach (Persona p in vectorEstado.Personas){
                if (p.EstaEsperandoAtencionCompra()){
                    if (proxima == null || p.TiempoLlegada < proxima.TiempoLlegada){
                        proxima = p;
                    }
                }
            }
            return proxima;
        }

        protected override double CalcularEntreTiempo()
        {
            return tiempoEntrega;
        }

        public override string GetNombre()
        {
            return $"Fin Compra ({idPersona})";
        }

        public void Preparar(){
            EntreTiempo = 0;
            Tiempo = vectorEstado.Anterior.FinCompra.Tiempo;
        }

        public override string[] Mostrar()
        {
            return new string[] { Tiempo == 0 ? "" : Math.Round(Tiempo, 2).ToString() };
        }
    }
}