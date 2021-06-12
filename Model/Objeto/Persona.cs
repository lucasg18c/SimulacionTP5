using System;

namespace SimulacionTP5.Model.Objeto
{
    public class Persona
    {
        private VectorEstado vectorEstado;
        
        ///Realmente no es un id único, es solo su posición en el vector
        public int Id { get; set; } 
        public string Estado { get; set; }
        public double TiempoLlegada { get; set; }
        public double ProximoFin { get; set; }

        public string[] Mostrar(){
            return new string[] {
                EstaBorrado() || EstaRetirado() ? "" : Estado,
                TiempoLlegada == 0 ? "" : Math.Round(TiempoLlegada, 2).ToString(),
                ProximoFin == 0 ? "" : Math.Round(ProximoFin, 2).ToString()
            };
        }

        public void Desbloquear(double nuevoFin)
        {
            SiendoAtendidoCompra();
            ProximoFin = nuevoFin;
        }

        public void ConsumirEnMesa()
        {
            UsarMesa();
            ProximoFin = vectorEstado.FinConsumo.RegistrarEvento();
        }

        public void Bloquear()
        {
            ProximoFin = 0;
            Estado = "Bloqueado";
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

        public Persona(VectorEstado vectorEstado){
            this.vectorEstado = vectorEstado;
            TiempoLlegada = vectorEstado.Reloj; 
        }

        public void Retirarse()
        {
            Estado = "Retirado";
            TiempoLlegada = 0;
            ProximoFin = 0;
        }

        public bool EstaRetirado(){
            return Estado == "Retirado";
        }

        public void Borrar(){
            Estado = "Borrado";
        }

        public bool EstaBorrado(){
            return Estado == "Borrado";
        }

        public void Comprar()
        {
            if(vectorEstado.Duenio.EstaOcupado() || vectorEstado.Duenio.EstaLimpiando()){
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

        public Persona CopiarYPreparar()
        {
            if (EstaRetirado()){
                Borrar();
            }
            if (EstaDePaso()){
                Retirarse();
            }
            return new Persona(vectorEstado.Anterior) {
                Id = this.Id,
                Estado = this.Estado, 
                TiempoLlegada = this.TiempoLlegada, 
                ProximoFin = this.ProximoFin
            };
        }

        public void ActualizarPermanencia()
        {
            if (!EstaBorrado() && !EstaDePaso() && !EstaRetirado())
            {
                vectorEstado.AcumularPermanenciaCafeteria();

                if (!EstaUsandoMesa())
                {
                    vectorEstado.AcumularPermanenciaColas();
                }
            }
        }

        public bool EstaDePaso()
        {
            return Estado == "DP";
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
            //Retirarse();
            Estado = "DP";
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

        public bool EstaBloqueado()
        {
            return Estado == "Bloqueado";
        }
    }
}