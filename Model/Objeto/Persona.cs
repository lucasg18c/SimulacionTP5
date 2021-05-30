using System;

namespace SimulacionTP5.Model.Objeto
{
    public class Persona
    {
        private VectorEstado vectorEstado;
        public string Estado { get; set; }
        public double TiempoLlegada { get; set; }
        public double ProximoFin { get; set; }

        public void ConsumirEnMesa()
        {
            UsarMesa();
            ProximoFin = vectorEstado.FinConsumo.RegistrarEvento();
        }

        public void ContarCliente()
        {
            vectorEstado.ContarCliente();
        }

        public void SentarseEnMesa()
        {
            UsarMesa();
            ProximoFin = vectorEstado.FinUsoMesa.RegistrarEvento();
        }

        public void AcumularPermanenciaColas()
        {
            vectorEstado.AcumularPermanenciaColas(TiempoLlegada);
        }

        public Persona(VectorEstado vectorEstado){
            this.vectorEstado = vectorEstado;
            TiempoLlegada = vectorEstado.Reloj; 
        }

        public void Retirarse()
        {
            Estado = "Retirado";
        }

        public void AcumularPermanenciaCafeteria()
        {
            vectorEstado.AcumularPermanenciaCafeteria(TiempoLlegada);
        }

        public bool SeRetiro(){
            return Estado == "Retirado";
        }

        public void Comprar()
        {
            if(vectorEstado.Duenio.EstaOcupado()){
                EsperandoAtencionCompra();
                vectorEstado.Duenio.AumentarCola();
            }
            else{
                SiendoAtendidoCompra();
                vectorEstado.Duenio.AtenderCompra(this);
            }
        }

        public void RecibirEntrega()
        {
            if (vectorEstado.EmpleadosOcupados()){
                EsperandoAtencionEntrega();
                vectorEstado.AumentarColaEmpleados();
            }
            else{
                SiendoAtendidoEntrega();
                vectorEstado.RecibirEntrega(this);
            }
        }

        public bool EstaEsperandoAtencionCompra()
        {
            return Estado == "EAC";
        }

        public bool EstaEsperandoAtencionEntrega()
        {
            return Estado == "EAE";
        }

        public void SiendoAtendidoEntrega()
        {
            Estado = "SAE";
        }

        public Persona Clone()
        {
            return new Persona(vectorEstado.Anterior) {Estado =  this.Estado, TiempoLlegada = this.TiempoLlegada, ProximoFin = this.ProximoFin};
        }

        public void EsperandoAtencionEntrega()
        {
            Estado = "EAE";
        }

        public bool EstaSiendoAtendidoCompra()
        {
            return Estado == "SAC";
        }

        public void EsperandoAtencionCompra(){
            Estado = "EAC";
        }

        public void SiendoAtendidoCompra(){
            Estado = "SAC";
        }

        public void DePaso(){
            Retirarse();
            //Estado = "DP";
        }

        public void UsarMesa(){
            Estado = "UM";
        }

        public bool EstaSiendoAtendidoEntrega()
        {
            return Estado == "SAE";
        }

        public bool EstaUsandoMesa()
        {
            return Estado == "UM";
        }
    }
}