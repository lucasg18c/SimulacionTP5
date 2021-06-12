using SimulacionTP5.Servicios;
using System;

namespace SimulacionTP5.Model.Event
{
    public class Inestable : EventoBase
    {
        private double rnd;
        public Inestable(VectorEstado vectorEstado) : base(vectorEstado)
        {
        }

        public override void Ejecutar()
        {
            Tiempo = 0;
            vectorEstado.FinLimpieza.RegistrarEvento();

            vectorEstado.Duenio.Limpiando();
            vectorEstado.ContadorPersonas = 0;
        }

        public override string GetNombre()
        {
            return "Inestable";
        }

        public override string[] Mostrar()
        {
            return new string[]
            {
                rnd == 0 ? "" : Math .Round(rnd, 2).ToString(),
                EntreTiempo == 0 ? "" : Math.Round(EntreTiempo, 2).ToString(),
                Tiempo == 0 ? "" : Math.Round(Tiempo, 2).ToString()
            };
        }

        protected override double CalcularEntreTiempo()
        {
            rnd = Generador.GenerarUniforme();

            if (rnd < .2) return 363.7;
            if (rnd < .5) return 465.4;
            return 573.06;
        }

        public void Preparar()
        {
            rnd = 0;
            EntreTiempo = 0;
            Tiempo = vectorEstado.Anterior.Inestable.Tiempo;
        }
    }
}
