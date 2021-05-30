using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos.ObjetivosPersona
{
    public class UsarMesa : ObjetivoPersona
    {
        public UsarMesa(double random) : base(random)
        {
        }

        public override string GetNombre()
        {
            return "Usar Mesa";
        }

        public override void Ejecutar(Persona persona)
        {
            persona.SentarseEnMesa();
        }
    }
}