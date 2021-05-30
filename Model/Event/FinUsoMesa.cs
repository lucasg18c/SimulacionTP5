using SimulacionTP5.Model.Objeto;
using SimulacionTP5.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimulacionTP5.Model.Event
{
    public class FinUsoMesa : EventoBase
    {

        private List<double> mesas;
        private double desde, hasta;
        private int idPersona;

        public FinUsoMesa(VectorEstado vectorEstado, double desde, double hasta) : base(vectorEstado)
        {
            mesas = new List<double>();
            this.desde = desde;
            this.hasta = hasta;
        }

        public override void Ejecutar()
        {
            Persona p = vectorEstado.BuscarPersonaPorRetirarse();
            idPersona = p.Id;
            p.ContarCliente();
            p.AcumularPermanenciaCafeteria();
            p.Retirarse();
            mesas[mesas.IndexOf(vectorEstado.Reloj)] = 0;
        }

        protected override double CalcularEntreTiempo()
        {
            return 60 * Generador.GenerarUniforme(desde, hasta);
        }

        protected override void CalcularProximo()
        {
            base.CalcularProximo();

            int pos = mesas.IndexOf(0);
            if (pos == -1){
                mesas.Add(Tiempo);
            }
            else{
                mesas[pos] = Tiempo;
            }
        }

        public override double GetTiempo()
        {
            double min = 0;

            foreach (double d in mesas){
                if (min == 0 || d < min){
                    min = d;
                }
            }
            return min;
        }

        public override string GetNombre()
        {
            return $"Fin Uso Mesa ({idPersona})";
        }

        public List<double> GetTiempos()
        {
            return mesas;
        }

        public void Preparar(){
            EntreTiempo = 0;
            Tiempo = 0;
            mesas = vectorEstado.Anterior.FinUsoMesa.mesas.Select(i => i).ToList();
        }

        public override string[] Mostrar()
        {
            string[] res = new string[mesas.Count + 1];
            res[0] = EntreTiempo == 0 ? "" : Math.Round(EntreTiempo, 2).ToString();

            for (int i = 0; i < mesas.Count; i++){
                res[i+1] = mesas[i] == 0 ? "" : Math.Round(mesas[i], 2).ToString();
            }
            return res;
        }
    }
}