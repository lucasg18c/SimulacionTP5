using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos.ObjetivosPersona
{
    public class Comprar : ObjetivoPersona
    {
        public Comprar(double random) : base(random)
        {
        }

        public override string GetNombre()
        {
            return "Comprar";
        }

        public override void Ejecutar(Persona persona)
        {
            persona.Comprar();
        }
    }
}