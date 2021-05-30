using SimulacionTP5.Model.Event;
using SimulacionTP5.Model.Objeto;
using SimulacionTP5.Model.Server;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimulacionTP5.Model
{
    public class VectorEstado
    {
        public VectorEstado Anterior { get; set; }
        public EventoBase EventoActual { get; set; }
        public double Reloj { get; set; }
        public LlegadaPersona LlegadaPersona { get; set; }

        public FinCompra FinCompra { get; set; }
        public FinEntrega FinEntrega { get; set; }

        public void ContarCliente()
        {
            ContadorClientes++;
        }

        public FinConsumo FinConsumo { get; set; }
        public FinUsoMesa FinUsoMesa { get; set; }
        public Duenio Duenio { get; set; }

        public void AcumularPermanenciaColas(double tiempoLlegada)
        {
            ACTPermanenciaColas += Reloj - tiempoLlegada;
        }

        public Empleado Empleado1 { get; set; }
        public Empleado Empleado2 { get; set; }
        public int ColaEmpleados { get; set; }
        public int MayorColaEmpleados { get; set; }
        public double ACTPermanenciaCafeteria { get; set; }
        public double ACTPermanenciaColas { get; set; }

        public void AcumularPermanenciaCafeteria(double tiempoLlegada)
        {
            ACTPermanenciaCafeteria += Reloj - tiempoLlegada;
        }

        public int ContadorClientes { get; set; }
        public List<Persona> Personas;

        /// <summary>Ejecuta el evento de la iteración actual</summary>
        public void Simular()
        {
            EventoActual.Ejecutar();
        }

        /// <summary>Prepara la iteración actual para la simulación: borra cálculos intermedios, mantiene tiempos 
        /// de eventos próximos</summary> 
        public void Preparar()
        {
            LlegadaPersona.Preparar();
            FinCompra.Preparar();
            FinEntrega.Preparar();
            FinCompra.Preparar();
            FinUsoMesa.Preparar();
            FinConsumo.Preparar();

            Duenio.Preparar();
            Empleado1.Preparar(Anterior.Empleado1);
            Empleado2.Preparar(Anterior.Empleado2);
            ColaEmpleados = Anterior.ColaEmpleados;
            MayorColaEmpleados = Anterior.MayorColaEmpleados;
            ACTPermanenciaCafeteria = Anterior.ACTPermanenciaCafeteria;
            ACTPermanenciaColas = Anterior.ACTPermanenciaColas;
            ContadorClientes = Anterior.ContadorClientes;
            Personas = Anterior.Personas.Select(p => p.Clone()).ToList();
        }

        public string[] MostrarPersonas()
        {
            List<string> personas = new List<string>();

            foreach(Persona p in Personas){
                if (p.SeRetiro()){
                    personas.Add("");
                    personas.Add("");
                    personas.Add("");
                }
                else{
                personas.Add(p.Estado);
                personas.Add(Math.Round(p.TiempoLlegada, 2).ToString());
                personas.Add(Math.Round(p.ProximoFin, 2).ToString());
                }
            }
            return personas.ToArray();
        }

        public void ActualizarTiemposLibres()
        {
            Duenio.ActualizarTiempoLibre();
            Empleado1.ActualizarTiempoLibre();
            Empleado2.ActualizarTiempoLibre();
        }

        public string[] MostrarFinUsoMesa()
        {
            return FinUsoMesa.GetTiempos().Select(
                mesa => Math.Round(mesa, 2).ToString()
            ).ToArray();
        }

        public string[] MostrarFinConsumo()
        {
            List<string> lista = new List<string>();
            lista.Add($"{Math.Round(FinConsumo.EntreTiempo, 2)}");
            lista.AddRange(FinConsumo.GetTiempos().Select(mesa => $"{Math.Round(mesa, 2)}")); 
            return lista.ToArray();
        }

        public string[] MostrarSeccion2()
        {
            return new string[] {
                Duenio.Estado,
                $"{Duenio.Cola}",
                $"{Duenio.MayorCola}",
                $"{Math.Round(Duenio.ACTiempoLibre, 2)}",
                Empleado1.Estado,
                $"{Math.Round(Empleado1.ACTiempoLibre, 2)}",
                Empleado2.Estado,
                $"{Math.Round(Empleado2.ACTiempoLibre, 2)}",
                $"{ColaEmpleados}",
                $"{MayorColaEmpleados}",
                $"{Math.Round(ACTPermanenciaCafeteria, 2)}",
                $"{Math.Round(ACTPermanenciaColas, 2)}",
                $"{ContadorClientes}"
            };
        }

        public string[] MostrarSeccion1()
        {
            return new string[] {
                EventoActual.GetNombre(),
                $"{Math.Round(Reloj, 2)}",
                $"{Math.Round(LlegadaPersona.EntreTiempo, 2)}",
                $"{Math.Round(LlegadaPersona.Tiempo, 2)}",
                $"{Math.Round(LlegadaPersona.GetRandomObjetivo(), 2)}",
                LlegadaPersona.GetNombreObjetivo(),
                $"{Math.Round(FinCompra.Tiempo, 2)}",
                $"{Math.Round(FinEntrega.EntreTiempo, 2)}",
                $"{Math.Round(FinEntrega.GetEmpleado1(), 2)}",
                $"{Math.Round(FinEntrega.GetEmpleado2(), 2)}",
                $"{Math.Round(FinEntrega.GetRandomObjetivo(), 2)}",
                FinEntrega.GetNombreObjetivo(),
                $"{Math.Round(FinUsoMesa.EntreTiempo, 2)}"
            };
        }

        public void RecibirEntrega(Persona persona)
        {
            EmpleadoLibre().Atender(persona);
        }

        public void ReducirColaEmpleados()
        {
            ColaEmpleados--;
        }

        private Empleado EmpleadoLibre()
        {
            if (!Empleado1.EstaOcupado()){
                return Empleado1;
            }
            if (!Empleado2.EstaOcupado()){
                return Empleado2;
            }
            return null;
        }

        public VectorEstado(double mediaLlegada, double desviacionLlegada, double desdeFinConsumo, double hastaFinConsumo, double desdeFinUsoMesa, double hastaFinUsoMesa, double tiempoCompra, double mediaEntrega){
            LlegadaPersona = new LlegadaPersona(this, mediaLlegada, desviacionLlegada);
            FinCompra = new FinCompra(this, tiempoCompra);
            FinEntrega = new FinEntrega(this, mediaEntrega);
            FinConsumo = new FinConsumo(this, desdeFinConsumo, hastaFinConsumo);
            FinUsoMesa = new FinUsoMesa(this, desdeFinUsoMesa, hastaFinConsumo);
            Duenio = new Duenio(this);
            Empleado1 = new Empleado(this);
            Empleado2 = new Empleado(this);

            Personas = new List<Persona>();

            ACTPermanenciaCafeteria = 0;
            ACTPermanenciaColas = 0;
            ContadorClientes = 0;
        }

        public void Inicializar(){
            EventoActual = new Inicializar(this);
        }

        public void AumentarColaEmpleados()
        {
            ColaEmpleados++;
            if (ColaEmpleados > MayorColaEmpleados){
                MayorColaEmpleados = ColaEmpleados;
            }
        }

        public bool EmpleadosOcupados()
        {
            return Empleado1.EstaOcupado() && Empleado2.EstaOcupado();
        }

        public void ElegirProximo(){
            EventoActual = LlegadaPersona;
            Reloj = Anterior.LlegadaPersona.GetTiempo();
            double tiempoAnterior;

            tiempoAnterior = Anterior.FinCompra.GetTiempo(); 
            if (0 < tiempoAnterior && tiempoAnterior < Reloj){
                EventoActual = FinCompra;
                Reloj = tiempoAnterior;
            }

            tiempoAnterior = Anterior.FinEntrega.GetTiempo(); 
            if (0 < tiempoAnterior && tiempoAnterior < Reloj){
                EventoActual = FinEntrega;
                Reloj = tiempoAnterior;
            }

            tiempoAnterior = Anterior.FinConsumo.GetTiempo(); 
            if (0 < tiempoAnterior && tiempoAnterior < Reloj){
                EventoActual = FinConsumo;
                Reloj = tiempoAnterior;
            }

            tiempoAnterior = Anterior.FinUsoMesa.GetTiempo(); 
            if (0 < tiempoAnterior && tiempoAnterior < Reloj){
                EventoActual = FinUsoMesa;
                Reloj = tiempoAnterior;
            }
        }

        public Persona BuscarPersonaSAC()
        {
            foreach (Persona p in Personas){
                if (p.EstaSiendoAtendidoCompra()){
                    return p;
                }
            }
            return null;
        }

        public Persona BuscarPersonaPorRetirarse()
        {
            foreach (Persona p in Personas){
                if (p.EstaUsandoMesa() && p.ProximoFin == Reloj){
                    return p;
                }
            }
            return null;   
        }
    }
}