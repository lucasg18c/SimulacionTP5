using SimulacionTP5.Servicios;

namespace SimulacionTP5.Model.Objetivos.ObjetivosCliente
{
    public abstract class ObjetivoCliente : ObjetivoBase
    {
        protected ObjetivoCliente(double random) : base(random)
        {
        }

        public static ObjetivoCliente ObtenerObjetivo(){
            double rnd = Generador.GenerarUniforme();

            if (rnd < .5)
                return new ConsumirEnMesa(rnd);

            return new Retirarse(rnd);
        }
    }    
}