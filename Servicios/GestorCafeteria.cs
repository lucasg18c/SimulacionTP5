using SimulacionTP5.Presentacion;
using System;
using System.Windows.Forms;

namespace SimulacionTP5.Servicios
{
    public class GestorCafeteria
    {
        private readonly FrmPrincipal form;
        private SistemaColasCafeteria cafeteria;
        private int iteraciones, mostrarDesde, cantidadMostrar;
        private int mediaLlegada, desviacionLlegada, finCompra,
            finEntrega, desdeFinUsoMesa, hastaFinUsoMesa,
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
                form.MostrarExcepcion(e.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void MostrarResultado()
        {
            //form.MostrarResultado(
            //    $"$ {cafeteria.GetOcioEmp1()}",
            //    $"$ {cafeteria.GetOcioEmp2()}",
            //    $"$ {cafeteria.GetOcioDuenio()}",
            //    $"$ {cafeteria.GetPromPermEnCola()}",
            //    $"$ {cafeteria.GetColaMacDuenio()}",
            //    $"$ {cafeteria.GetColamMaxEmpleados()}");
            
        }

        private void CalcularCafeteria()
        {
            cafeteria = new SistemaColasCafeteria();

            //cafeteria.Calcular(iteraciones,
            //    mostrarDesde,cantidadMostrar,
            //    mediaLlegada,desviacionLlegada,
            //    finCompra,finEntrega,
            //    desdeFinUsoMesa,hastaFinUsoMesa,
            //    desdeFinConsumo,hastaFinConsumo);
        }

        private void Validar()
        {
            if (iteraciones == 0) throw new ApplicationException("La simulacion debe ser por lo menos de una fila");
            if (mostrarDesde >= iteraciones) throw new ApplicationException("El mostrar desde debe ser menor a las iteraciones, para poder mostrar algo");
            if (finCompra <= 0 && finEntrega <= 0) throw new ApplicationException("Los tiempos en segundos deben ser positivos");
            if (desdeFinUsoMesa >= hastaFinUsoMesa) throw new ApplicationException("Valores Fin uso de mesa incorrectos, valor desde debe ser menor a valor Hasta");
            if (desdeFinConsumo >= hastaFinConsumo) throw new ApplicationException("Valores Fin consumo incorrectos, Valor Desde es mayor a Valor Hasta");
            //No recuerdo si la media y desviacion estandar tiene algunas restrcciones de valores
        }
        private void GetDatos()
        {
            iteraciones = form.GetIterciones();
            mostrarDesde = form.GetMostrarDesde();
            cantidadMostrar = form.GetCantidadAMostar();

            mediaLlegada = form.GetMediaLlegada();
            desviacionLlegada = form.GetDesviacionLlegada();
            finCompra = form.GetSegundosFinCompra();
            finEntrega = form.GetFinEntrega();

            desdeFinUsoMesa = form.GetSegundosDesdeFinUsoMesa();
            hastaFinUsoMesa = form.GetSegundosHastaFinUsoMesa();
            desdeFinConsumo = form.GetSegundosDesdeFinConsumo();
            hastaFinConsumo = form.GetSegundosHastaFinConsumo();
            

        }
    }
}
