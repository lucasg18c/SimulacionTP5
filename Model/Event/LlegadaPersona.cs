using SimulacionTP5.Model.Objetivos.ObjetivosPersona;
using SimulacionTP5.Model.Objeto;
using SimulacionTP5.Servicios;
using System;

namespace SimulacionTP5.Model.Event
{
    public class LlegadaPersona : EventoBase
    {
        private double media;
        private double desviacion;
        private int idPersona;
        private ObjetivoPersona objetivo = null;
        public LlegadaPersona(VectorEstado vectorEstado, double media, double desviacion) : base(vectorEstado)
        {
            this.media = media;
            this.desviacion = desviacion;
        }

        public override void Ejecutar()
        {
            RegistrarEvento();
            objetivo = ObjetivoPersona.ObtenerObjetivo(); 
            Persona p = new Persona(vectorEstado);    
            
            int pos = BuscarPosPersonaBorrada();

            if (pos == -1){
                vectorEstado.Personas.Add(p);
            }
            else{
                vectorEstado.Personas[pos] = p;
            }
            
            p.Id = pos == -1 ? vectorEstado.Personas.Count : pos + 1;
            idPersona = p.Id;
            objetivo.Ejecutar(p);            
        }

        private int BuscarPosPersonaBorrada()
        {
            for (int i = 0; i < vectorEstado.Personas.Count; i++){
                if (vectorEstado.Personas[i].EstaBorrado()){
                    return i;
                }
            }
            return -1;
        }

        protected override double CalcularEntreTiempo()
        {
            return Math.Abs(Generador.GenerarNormal(media, desviacion));
        }

        public double GetRandomObjetivo(){
            return objetivo == null ? 0 : objetivo.Random;
        }

        public string GetNombreObjetivo(){
            return objetivo == null ? "-" : objetivo.GetNombre();
        }

        public override string GetNombre()
        {
            return $"Llegada Persona ({idPersona})";
        }

        public void Preparar(){
            EntreTiempo = 0;
            Tiempo = vectorEstado.Anterior.LlegadaPersona.Tiempo;
            objetivo = null;
        }

        public override string[] Mostrar()
        {
            return new string[] {
                EntreTiempo == 0 ? "" : Math.Round(EntreTiempo, 2).ToString(),
                Math.Round(Tiempo, 2).ToString(),
                objetivo == null ? "" : Math.Round(objetivo.Random, 2).ToString(),
                objetivo == null ? "" : objetivo.GetNombre()
            };
        }
    }
}