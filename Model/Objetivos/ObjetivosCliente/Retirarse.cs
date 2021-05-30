using SimulacionTP5.Model.Objeto;

namespace SimulacionTP5.Model.Objetivos.ObjetivosCliente
{
    public class Retirarse : ObjetivoCliente
    {
        public Retirarse(double random) : base(random)
        {
        }

        public override void Ejecutar(Persona persona)
        {
            persona.ContarCliente();
            persona.AcumularPermanenciaCafeteria();
            persona.Retirarse();
        }

        public override string GetNombre()
        {
            return "Retirarse";
        }
    }
}