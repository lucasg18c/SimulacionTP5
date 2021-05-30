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
            
            int pos = BuscarPosPersonaRetirada();

            if (pos == -1){
                vectorEstado.Personas.Add(p);
            }
            else{
                vectorEstado.Personas[pos] = p;
            }
            
            objetivo.Ejecutar(p);            
        }

        private int BuscarPosPersonaRetirada()
        {
            for (int i = 0; i < vectorEstado.Personas.Count; i++){
                if (vectorEstado.Personas[i].SeRetiro()){
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
            return "Llegada Persona";
        }

        public void Preparar(){
            EntreTiempo = 0;
            Tiempo = vectorEstado.Anterior.LlegadaPersona.Tiempo;
            objetivo = null;
        }
    }
}