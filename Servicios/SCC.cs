using SimulacionTP5.Model;
using System;
using System.Collections.Generic;

namespace SimulacionTP5.Servicios
{
    public class SCC
    {
        private List<string[]> seccion1;
        private List<string[]> finConsumo;
        private List<string[]> finUsoMesa;
        private List<string[]> seccion2;
        private List<string[]> personas;

        private double ocioEmpleado1;
        private double ocioEmpleado2;
        private double ocioDuenio;
        private double colaEmpleados;
        private double colaDuenio;
        private double tiempoCafeteria;
        private double tiempoColas;

        private static readonly string[] columnasSeccion1 = new string[]{
            "Evento",
            "Reloj (segundos)",
            "Tiempo entre Llegadas",
            "Próxima llegada",
            "RND",
            "Objetivo",
            "Fin Compra",
            "Tiempo Entrega",
            "Empleado 1",
            "Empleado 2",
            "RND",
            "Objetivo",
            "Tiempo uso mesa"
        };

        private static readonly string[] columnasSeccion2 = new string[]{
            "Estado Dueño",
            "Cola Dueño",
            "Mayor Cola Dueño",
            "AC Tiempo Libre",
            "Estado E1",
            "AC Tiempo Libre E1",
            "Estado E2",
            "AC Tiempo Libre E2",
            "Cola Empleados",
            "Mayor Cola Empleados",
            "AC Tiempo Permanencia Cafetería",
            "AC Tiempo Permanencia Colas",
            "Contador Clientes"
        };

        public void Simular(int iteraciones, double mostrarDesde, double mostrarHasta, double mediaLlegada, double desviacionLlegada, double desdeFinConsumo, double hastaFinConsumo, double desdeFinUsoMesa, double hastaFinUsoMesa, double tiempoCompra, double mediaEntrega){

            VectorEstado actual, anterior, temp;
            actual = new VectorEstado(mediaLlegada, desviacionLlegada, desdeFinConsumo, hastaFinConsumo, desdeFinUsoMesa, hastaFinUsoMesa, tiempoCompra, mediaEntrega);
            anterior = new VectorEstado(mediaLlegada, desviacionLlegada, desdeFinConsumo, hastaFinConsumo, desdeFinUsoMesa, hastaFinUsoMesa, tiempoCompra, mediaEntrega);

            seccion1 = new List<string[]>();
            seccion2 = new List<string[]>();
            finConsumo = new List<string[]>();
            finUsoMesa = new List<string[]>();
            personas = new List<string[]>();
            
            actual.Anterior = anterior;
            anterior.Anterior = actual;

            anterior.Inicializar();
            anterior.Simular();
            
            if (mostrarDesde == 0){
                Registrar(anterior);  
            }  

            for (int i = 0; i < iteraciones; i++)
            {
                actual.Preparar();
                actual.ElegirProximo();
                actual.ActualizarTiemposLibres();
                actual.Simular();

                if (mostrarDesde <= i && i <= mostrarHasta){
                    Registrar(actual);
                }

                temp = actual;
                actual = anterior;
                anterior = temp;
            }

            RegistrarMetricas(anterior);
        }

        private void RegistrarMetricas(VectorEstado estado)
        {
            ocioEmpleado1 = estado.Empleado1.ACTiempoLibre;
            ocioEmpleado2 = estado.Empleado2.ACTiempoLibre;
            ocioDuenio = estado.Duenio.ACTiempoLibre;
            colaDuenio = estado.Duenio.MayorCola;
            colaEmpleados = estado.MayorColaEmpleados;
            tiempoCafeteria = estado.ContadorClientes != 0 ? estado.ACTPermanenciaCafeteria / estado.ContadorClientes : 0;
            tiempoColas = estado.ContadorClientes != 0 ? estado.ACTPermanenciaColas / estado.ContadorClientes : 0;
        }

        public string GetTiempoColas()
        {
            return Math.Round(tiempoColas, 2).ToString();
        }

        public string GetTiempoCafeteria()
        {
            return Math.Round(tiempoCafeteria, 2).ToString();     
        }

        public string GetColaDuenio()
        {
            return colaDuenio.ToString();
        }

        public string GetColaEmpleados()
        {
            return colaEmpleados.ToString();
        }

        public string GetOcioDuenio()
        {
            return Math.Round(ocioDuenio, 2).ToString();
        }

        public string GetOcioEmpleado2()
        {
            return Math.Round(ocioEmpleado2, 2).ToString();
        }

        public string GetOcioEmpleado1()
        {
            return Math.Round(ocioEmpleado1, 2).ToString();
        }

        private void Registrar(VectorEstado estado)
        {
            seccion1.Add(estado.MostrarSeccion1());
            seccion2.Add(estado.MostrarSeccion2());
            finConsumo.Add(estado.MostrarFinConsumo());
            finUsoMesa.Add(estado.MostrarFinUsoMesa());
            personas.Add(estado.MostrarPersonas());
        }

        public string[][] GetSimulacion(){
            int mPersonas, mFinConsumo, mFinUso, lSeccion1, lSeccion2, m, n;
            n = seccion1.Count;

            string[][] filas = new string[n][];

            mPersonas = MayorLongitud(personas);
            mFinConsumo = MayorLongitud(finConsumo);
            mFinUso = MayorLongitud(finUsoMesa);
            lSeccion1 = seccion1[0].Length;
            lSeccion2 = seccion2[0].Length;

            m = mFinConsumo + mPersonas + mFinUso + lSeccion1 + lSeccion2;

            for (int i = 0; i < n; i++){
                string[] fila = new string[m];

                Array.Copy(seccion1[i],   0, fila, 0, lSeccion1);
                Array.Copy(finUsoMesa[i], 0, fila, lSeccion1, finUsoMesa[i].Length);
                Array.Copy(finConsumo[i], 0, fila, lSeccion1 + mFinUso, finConsumo[i].Length);
                Array.Copy(seccion2[i],   0, fila, lSeccion1 + mFinUso + mFinConsumo, lSeccion2);
                Array.Copy(personas[i],   0, fila, lSeccion1 + mFinUso + mFinConsumo + lSeccion2, personas[i].Length);

                filas[i] = fila;
            }
            return filas;
        }

        public int MayorLongitud(List<string[]> lista){
            
            int mayor = 0;
            foreach (string[] fila in lista){
                if (fila.Length > mayor){
                    mayor = fila.Length;
                }
            }
            return mayor;
        }

        public string[] GetColumnas(){
            int mPersonas, mFinConsumo, mFinUso, lSeccion1, lSeccion2, m, n;
            n = seccion1.Count;

            mPersonas = MayorLongitud(personas);
            mFinConsumo = MayorLongitud(finConsumo);
            mFinUso = MayorLongitud(finUsoMesa);
            lSeccion1 = seccion1[0].Length;
            lSeccion2 = seccion2[0].Length;

            m = mFinConsumo + mPersonas + mFinUso + lSeccion1 + lSeccion2;
            string[] cols = new string[m];

            for (int i = 0; i < columnasSeccion1.Length; i++){
                cols[i] = columnasSeccion1[i];
            }

            int pos = columnasSeccion1.Length + mFinConsumo + mFinUso;
            for (int i = 0; i < columnasSeccion2.Length; i++){
                cols[pos + i] = columnasSeccion2[i];
            }

            pos = columnasSeccion1.Length;
            for(int i = 0; i < mFinUso; i++){
                cols[pos + i] = $"Mesa {i + 1}";
            }

            pos = columnasSeccion1.Length + mFinUso + 1;
            cols[pos - 1] = "Tiempo Consumo"; 
            for(int i = 0; i < mFinConsumo - 1; i++){
                cols[pos + i] = $"Mesa {i + 1}";
            }

            pos = columnasSeccion1.Length + mFinUso + mFinConsumo + columnasSeccion2.Length;
            int nPersona = 1;
            for(int i = 0; i < mPersonas; i += 3){
                
                cols[pos + i] = $"Estado Persona {nPersona}";
                cols[pos + i + 1] = $"Tiempo Llegada Persona {nPersona}";
                cols[pos + i + 2] = $"Próximo Fin Persona {nPersona}";
                nPersona++;
            }

            return cols;
        }
    }
}