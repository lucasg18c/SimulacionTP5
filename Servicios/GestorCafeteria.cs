using SimulacionTP5.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP5.Servicios
{
    public class GestorCafeteria
    {
        private readonly FrmPrincipal form;
        private SCC cafeteria;
        private int iteraciones, mostrarDesde, cantidadMostrar;
        private double mediaLlegada, desviacionLlegada, finCompra,
            mediaEntrega, desdeFinUsoMesa, hastaFinUsoMesa,
            desdeFinConsumo, hastaFinConsumo;

        public GestorCafeteria(FrmPrincipal form)
        {
            this.form = form;
        }
        public void Calcular()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GetDatos();
                Validar();
                CalcularCafeteria();
                MostrarResultado();
            }
            catch (Exception e)
            {
                form.MostrarExcepcion(e.StackTrace);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MostrarResultado()
        {
            // Mostrar tabla
            form.LimpiarTabla();

            string[] columnas = cafeteria.GetColumnas();
            for (int i = 0; i < columnas.Length; i++)
                form.MostrarColumnas($"col{i}", columnas[i]);

            foreach (string[] fila in cafeteria.GetSimulacion())
                form.MostrarTabla(fila);

            // Mostrar métricas
            form.MostrarResultado(
                cafeteria.GetOcioEmpleado1(),
                cafeteria.GetOcioEmpleado2(),
                cafeteria.GetOcioDuenio(),
                cafeteria.GetColaEmpleados(),
                cafeteria.GetColaDuenio(),
                cafeteria.GetTiempoCafeteria(),
                cafeteria.GetTiempoColas() 
            );
        }

        private void CalcularCafeteria()
        {
            cafeteria = new SCC();
            cafeteria.Simular(
                iteraciones, 
                mostrarDesde, 
                mostrarDesde + cantidadMostrar,
                mediaLlegada, 
                desviacionLlegada, 
                desdeFinConsumo, 
                hastaFinConsumo, 
                desdeFinUsoMesa, 
                hastaFinUsoMesa, 
                finCompra, 
                mediaEntrega);
        }

        private void Validar()
        {
            if (iteraciones == 0) throw new ApplicationException("La simulacion debe ser por lo menos de una fila");
            if (mostrarDesde >= iteraciones) throw new ApplicationException("El mostrar desde debe ser menor a las iteraciones, para poder mostrar algo");
            if (finCompra <= 0 && mediaEntrega <= 0) throw new ApplicationException("Los tiempos en segundos deben ser positivos");
            if (desdeFinUsoMesa >= hastaFinUsoMesa) throw new ApplicationException("Valores Fin uso de mesa incorrectos, valor desde debe ser menor a valor Hasta");
            if (desdeFinConsumo >= hastaFinConsumo) throw new ApplicationException("Valores Fin consumo incorrectos, Valor Desde es mayor a Valor Hasta");
            //No recuerdo si la media y desviacion estandar tiene algunas restrcciones de valores
        }

        public void Exportar()
        {
            string tabla = "";
            string[] columnas = cafeteria.GetColumnas();
            int m = columnas.Length - 1;

            for (int i = 0; i < m + 1; i++)
            {
                tabla += columnas[i];

                if (i < m)
                    tabla += "\t";
            }
            tabla += "\n";

            string[][] filas = cafeteria.GetSimulacion();
            int n = filas.Length - 1;

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    tabla += filas[i][j];

                    if (j < m)
                        tabla += "\t";
                }

                if (i < n)
                    tabla += "\n";
            }

            Clipboard.SetText(tabla);
            form.MostrarExcepcion("listo xd");
        }

        private void GetDatos()
        {
            iteraciones = form.GetIterciones();
            mostrarDesde = form.GetMostrarDesde();
            cantidadMostrar = form.GetCantidadAMostar();

            mediaLlegada = form.GetMediaLlegada();
            desviacionLlegada = form.GetDesviacionLlegada();
            finCompra = form.GetDuracionCompra();
            mediaEntrega = form.GetMediaEntrega();

            desdeFinUsoMesa = form.GetDesdeUsoMesa();
            hastaFinUsoMesa = form.GetHastaUsoMesa();
            desdeFinConsumo = form.GetDesdeConsumo();
            hastaFinConsumo = form.GetHastaConsumo();
        }
    }
}
