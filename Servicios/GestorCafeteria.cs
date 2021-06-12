using SimulacionTP5.Presentacion;
using System;

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
        public void Simular()
        {
            try
            {
                form.Esperar(true);
                GetDatos();
                Validar();
                CalcularCafeteria();
                MostrarResultado();
                form.PermitirExportar(true);
                form.PermitirAlternar(true);
            }
            catch (Exception e)
            {
                form.MostrarError(e.Message);
                form.PermitirExportar(false);
                form.PermitirAlternar(false);
            }
            finally
            {
                form.Esperar(false);
            }
        }

        private void MostrarResultado()
        {
            form.MostrarPantallaResultado();
            // Mostrar tabla
            form.LimpiarTabla();
            form.LimpiarTablaTiemposLimpieza();

            form.MostrarColumnas(cafeteria.GetColumnas());
            form.MostrarTabla(cafeteria.GetSimulacion());

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

            form.MostrarColumnasLimpieza(cafeteria.GetColumnasLimpieza());
            form.MostrarTablaLimpieza(cafeteria.GetTablaLimpieza());
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
            if (iteraciones == 0) throw new ApplicationException("Debe simular por lo menos una iteración.");
            if (mostrarDesde >= iteraciones) throw new ApplicationException("Debe mostrar desde una iteración menor al total de iteraciones.");
            if (cantidadMostrar == 0) throw new ApplicationException("Debe mostrar por lo menos una iteración de la simulación.");
            if (mediaLlegada == 0) throw new ApplicationException("El tiempo medio de llegada de personas no puede ser nulo.");
            if (desviacionLlegada == 0) throw new ApplicationException("La desviación estándar en tiempo de llegada de personas no puede ser nulo.");
            if (finCompra == 0) throw new ApplicationException("El tiempo de compra no puede ser nulo.");
            if (mediaEntrega == 0) throw new ApplicationException("El tiempo medio de entrega no puede ser nulo.");
            if (desdeFinUsoMesa >= hastaFinUsoMesa) throw new ApplicationException("El rango de valores de la duración de uso de mesas es inválido: \"Desde\" debe ser menor que \"Hasta\".");
            if (desdeFinUsoMesa == 0) throw new ApplicationException("El rango de valores de la duración de uso de mesas es inválido: \"Desde\" no puede ser nulo.");
            if (desdeFinConsumo >= hastaFinConsumo) throw new ApplicationException("El rango de valores de la duración de consumo en mesas es inválido: \"Desde\" debe ser menor que \"Hasta\".");
            if (desdeFinConsumo == 0) throw new ApplicationException("El rango de valores de la duración de consumo en mesas es inválido: \"Desde\" no puede ser nulo.");
        }

        public void Exportar()
        {
            string[] columnas;
            string[][] filas;
            string mensaje;
            try
            {
                form.Esperar(true);

                if (form.EstaMostrandoResultado())
                {
                    columnas = cafeteria.GetColumnas();
                    filas = cafeteria.GetSimulacion();
                    mensaje = "La simulación ha sido copiada a portapapeles! :D";
                }
                else
                {
                    columnas = cafeteria.GetColumnasLimpieza();
                    filas = cafeteria.GetTablaLimpieza().ToArray();
                    mensaje = "La tabla de tiempos de limpieza ha sido copiada a portapapeles ;D";
                }

                string tabla = "";
                
                int m = columnas.Length - 1;

                for (int i = 0; i < m + 1; i++)
                {
                    tabla += columnas[i];

                    if (i < m)
                        tabla += "\t";
                }
                tabla += "\n";

                
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

                form.CopiarPortapapeles(tabla);
                form.MostrarInformacion(mensaje, "Resultado copiado");
            }
            catch (Exception e)
            {
                form.MostrarError("Ocurrió un error al exportar: " + e.Message);
            }
            finally
            {
                form.Esperar(false);
            }
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
