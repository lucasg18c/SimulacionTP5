using System;
using SimulacionTP5.Model.Objetivos.ObjetivosCliente;
using SimulacionTP5.Model.Objeto;
using SimulacionTP5.Model.Server;
using SimulacionTP5.Servicios;

namespace SimulacionTP5.Model.Event
{
    public class FinEntrega : EventoBase
    {
        private double media;    
        private double empleado1 = 0;    
        private double empleado2 = 0; 
        private int idPersona;
        private ObjetivoCliente objetivo;   

        public FinEntrega(VectorEstado vectorEstado, double media) : base(vectorEstado)
        {
            this.media = media;
        }

        public override void Ejecutar()
        {
            Persona p = BuscarPersonaConEntrega();
            idPersona = p.Id;
            //p.AcumularPermanenciaColas();

            objetivo = ObjetivoCliente.ObtenerObjetivo();
            objetivo.Ejecutar(p);

            Empleado empleado;

            if (empleado1 == vectorEstado.Reloj){
                empleado1 = 0;
                empleado = vectorEstado.Empleado1;
            }
            else{
                empleado2 = 0;
                empleado = vectorEstado.Empleado2;
            }

            empleado.Libre();
            AvanzarCola(empleado);
        }

        private void AvanzarCola(Empleado empleado)
        {
            if (vectorEstado.ColaEmpleados > 0){
                vectorEstado.ReducirColaEmpleados();
                Persona p = BuscarProximaEAE();
                p.SiendoAtendidoEntrega();
                empleado.Atender(p);
            }
        }

        private Persona BuscarPersonaConEntrega()
        {
            foreach (Persona p in vectorEstado.Personas){
                if (p.EstaSiendoAtendidoEntrega() && p.ProximoFin == vectorEstado.Reloj){
                    return p;
                }
            }
            return null;     
        }

        private Persona BuscarProximaEAE()
        {
            Persona proxima = null;

            foreach (Persona p in vectorEstado.Personas){
                if (p.EstaEsperandoAtencionEntrega()){
                    if (proxima == null || p.TiempoLlegada < proxima.TiempoLlegada){
                        proxima = p;
                    }
                }
            }
            return proxima;
        }

        protected override void CalcularProximo()
        {
            base.CalcularProximo();
            
            if(empleado1 == 0) empleado1 = Tiempo;
            else empleado2 = Tiempo;
        }

        public override double GetTiempo()
        {
            if (empleado1 > 0 && empleado1 < empleado2) return empleado1;
            return empleado2;
        }

        protected override double CalcularEntreTiempo()
        {
            return Generador.GenerarExponencial(media);
        }

        public double GetEmpleado1()
        {
            return empleado1;
        }

        public double GetEmpleado2()
        {
            return empleado2;
        }

        public double GetRandomObjetivo(){
            return objetivo == null ? 0 : objetivo.Random;
        }

        public string GetNombreObjetivo(){
            return objetivo == null ? "-" : objetivo.GetNombre();
        }

        public override string GetNombre()
        {
            return $"Fin Entrega ({idPersona})";
        }

        public void Preparar(){
            EntreTiempo = 0;
            Tiempo = 0;
            empleado1 = vectorEstado.Anterior.FinEntrega.empleado1;
            empleado2 = vectorEstado.Anterior.FinEntrega.empleado2;
            objetivo = null;
        }

        public override string[] Mostrar()
        {
            return new string[] {
                EntreTiempo == 0 ? "" : Math.Round(EntreTiempo, 2).ToString(),
                empleado1 == 0 ? "" : Math.Round(empleado1, 2).ToString(),
                empleado2 == 0 ? "" : Math.Round(empleado2, 2).ToString(),
                objetivo == null ? "" : Math.Round(objetivo.Random, 2).ToString(),
                objetivo == null ? "" : objetivo.GetNombre()
            };
        }
    }
}