using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos.ObjetivosCliente
{
    public class ConsumirEnMesa : ObjetivoCliente
    {
        public ConsumirEnMesa(double random) : base(random)
        {
        }

        public override void Ejecutar(Persona persona)
        {
            persona.ConsumirEnMesa();
        }

        public override string GetNombre()
        {
            return "Consumir en Mesa";
        }
    }
}