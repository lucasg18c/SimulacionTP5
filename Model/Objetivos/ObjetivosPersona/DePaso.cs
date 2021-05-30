using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos.ObjetivosPersona
{
    public class DePaso : ObjetivoPersona
    {
        public DePaso(double random) : base(random)
        {
        }

        public override void Ejecutar(Persona persona)
        {
            persona.DePaso();
        }

        public override string GetNombre()
        {
            return "De Paso";
        }
    }
}