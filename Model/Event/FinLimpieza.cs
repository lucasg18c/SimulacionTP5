using System;
using System.Collections.Generic;

namespace SimulacionTP5.Model.Event
{
    public class FinLimpieza : EventoBase
    {
        private RKLimpieza rk;

        public FinLimpieza(VectorEstado vectorEstado) : base(vectorEstado)
        {
            rk = new RKLimpieza(); 

        }

        public override void Ejecutar()
        {
            Tiempo = 0;
            vectorEstado.Duenio.FinLimpieza();
            vectorEstado.Inestable.RegistrarEvento();
        }

        public override string GetNombre()
        {
            return "Fin Limpieza";
        }

        public override string[] Mostrar()
        {
            return new string[]
            {
                EntreTiempo == 0 ? "" : Math.Round(EntreTiempo, 2).ToString(),
                Tiempo == 0 ? "" : Math.Round(Tiempo, 2).ToString()
            };
        }

        protected override double CalcularEntreTiempo()
        {
            return rk.Calcular(vectorEstado.ContadorPersonas);
        }

        public void Preparar()
        {
            EntreTiempo = 0;
            Tiempo = vectorEstado.Anterior.FinLimpieza.Tiempo;
            rk.Limpiar();
        }

        public bool HizoRK()
        {
            return EntreTiempo != 0;
        }

        public List<string[]> GetRK()
        {
            return rk.GetTabla();
        }
    }
}
