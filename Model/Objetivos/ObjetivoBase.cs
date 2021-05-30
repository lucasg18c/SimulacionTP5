using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos
{
    public abstract class ObjetivoBase
    {
        public double Random { get; set; }
        public ObjetivoBase(double random){
            Random = random;
        }

        public abstract string GetNombre();
        public abstract void Ejecutar(Persona persona);
    }
}