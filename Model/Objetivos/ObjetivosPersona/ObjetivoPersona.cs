using SimulacionTP5.Servicios;

namespace SimulacionTP5.Model.Objetivos.ObjetivosPersona
{
    public abstract class ObjetivoPersona : ObjetivoBase
    {
        protected ObjetivoPersona(double random) : base(random)
        {
        }

        public static ObjetivoPersona ObtenerObjetivo(){
            double rnd = Generador.GenerarUniforme();

            if (rnd < .3)
                return new Comprar(rnd);
            if (rnd < .5)
                return new UsarMesa(rnd);
            return new DePaso(rnd);
        }
    }
}