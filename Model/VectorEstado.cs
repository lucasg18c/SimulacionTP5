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
        public FinConsumo FinConsumo { get; set; }
        public FinUsoMesa FinUsoMesa { get; set; }
        public Duenio Duenio { get; set; }
        public Empleado Empleado1 { get; set; }
        public Empleado Empleado2 { get; set; }
        public int ColaEmpleados { get; set; }
        public int MayorColaEmpleados { get; set; }
        public double ACTPermanenciaCafeteria { get; set; }
        public double ACTPermanenciaColas { get; set; }
        public int ContadorClientes { get; set; }
        public List<Persona> Personas;

        public void AcumularPermanenciaCafeteria()
        {
            ACTPermanenciaCafeteria += Reloj - Anterior.Reloj;
        }
        public void AcumularPermanenciaColas()
        {
            ACTPermanenciaColas += Reloj - Anterior.Reloj;
        }
        public void ContarCliente()
        {
            ContadorClientes++;
        }

        /// <summary>Ejecuta el evento de la iteración actual</summary>
        public void Simular()
        {
            EventoActual.Ejecutar();
        }

        /// <summary>
        /// Prepara la iteración actual para la simulación: borra cálculos intermedios, mantiene tiempos 
        /// de eventos próximos.
        ///</summary> 
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
            Personas = Anterior.Personas.Select(p => p.CopiarYPreparar()).ToList();
        }

        public string[] MostrarPersonas()
        {
            List<string> res = new List<string>();
            foreach( Persona p in Personas){
                res.AddRange(p.Mostrar());
            }
            return res.ToArray();
        }

        public void ActualizarTiemposLibres()
        {
            Duenio.ActualizarTiempoLibre();
            Empleado1.ActualizarTiempoLibre();
            Empleado2.ActualizarTiempoLibre();
        }

        public void ActualizarPermanencias()
        {
            foreach (Persona p in Personas){
                p.ActualizarPermanencia();
            }
        }

        public string[] MostrarFinUsoMesa()
        {
            List<string> res = new List<string>();
            res.AddRange(FinUsoMesa.Mostrar());
            return res.ToArray();
        }

        public string[] MostrarFinConsumo()
        {
            List<string> res = new List<string>();
            res.AddRange(FinConsumo.Mostrar());
            return res.ToArray();
        }

        public string[] MostrarSeccion2()
        {
            List<string> res = new List<string>();
            res.AddRange(Duenio.Mostrar());
            res.AddRange(Empleado1.Mostrar());
            res.AddRange(Empleado2.Mostrar());
            res.Add(ColaEmpleados.ToString());
            res.Add(MayorColaEmpleados.ToString());
            res.Add(Math.Round(ACTPermanenciaCafeteria, 2).ToString());
            res.Add(Math.Round(ACTPermanenciaColas, 2).ToString());
            res.Add(ContadorClientes.ToString());

            return res.ToArray();
        }

        public string[] MostrarSeccion1()
        {
            List<string> res = new List<string>();
            res.Add(EventoActual.GetNombre());
            res.Add(Math.Round(Reloj, 2).ToString());
            res.AddRange(LlegadaPersona.Mostrar());
            res.AddRange(FinCompra.Mostrar());
            res.AddRange(FinEntrega.Mostrar());

            return res.ToArray();
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
            FinUsoMesa = new FinUsoMesa(this, desdeFinUsoMesa, hastaFinUsoMesa);
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