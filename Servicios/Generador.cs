using System;

namespace SimulacionTP5.Servicios
{
    public class Generador
    {
        private static double[] serie;
        private static double semilla = 77;//DateTime.Now.Ticks;
        
        // Puxiliares para Box-Muller
        private static double randomBM = double.NaN;
        private static double dosPI = 2 * Math.PI;
        private static double temp1, temp2;

        private Generador()
        {
        }

        public static double GenerarUniforme(double a, double b)
        {
            return a + GenerarUniforme() * (b - a);
        }

        // Métodos para generar un único número

        public static double GenerarUniforme()
        {
            semilla = (86529D * semilla + 33554431D) % 33554432D;
            return semilla / 33554432D;
        }

        public static double GenerarExponencial(double media)
        {
            return -media * Math.Log(1 - GenerarUniforme());
        }

        public static double GenerarNormal(double media, double desviacion)
        {
            if (double.IsNaN(randomBM)){
                
                temp1 = Math.Sqrt(-2 * Math.Log(GenerarUniforme()));
                temp2 = dosPI * GenerarUniforme();

                randomBM = temp1 * Math.Cos(temp2) * desviacion + media;
                return temp1 * Math.Sin(temp2) * desviacion + media;
            }

            temp1 = randomBM;
            randomBM = double.NaN;
            return temp1;
        }

        // Métodos para generar múltiples números

        public static double[] GenerarUniforme(double a, double b, int cantidad)
        {
            serie = new double[cantidad];
            double ancho = b - a;

            for (int i = 0; i < cantidad; i++)
                serie[i] = a + GenerarUniforme() * ancho;

            return serie;
        }

        public static double[] GenerarExponencial(double media, int cantidad)
        {
            serie = new double[cantidad];
            media *= -1;

            for (int i = 0; i < cantidad; i++)
                serie[i] = media * Math.Log(1 - GenerarUniforme());

            return serie;
        }

        public static double[] GenerarPoisson(double media, int cantidad)
        {
            double p, x, a;

            serie = new double[cantidad];
            a = Math.Exp(-media);

            for (int i = 0; i < cantidad; i++)
            {
                p = 1;
                x = -1;

                do
                {
                    p *= GenerarUniforme();
                    x++;

                } while (p >= a);

                serie[i] = x;
            }

            return serie;
        }

        public static double[] GenerarNormalBM(double media, double desviacion, int cantidad)
        {
            double temp1, temp2, dosPI;
            int iteraciones;

            serie = new double[cantidad];
            dosPI = 2 * Math.PI;
            iteraciones = cantidad % 2 == 0 ? cantidad : cantidad - 1;

            for (int i = 0; i < iteraciones; i += 2)
            {
                temp1 = Math.Sqrt(-2 * Math.Log(GenerarUniforme()));
                temp2 = dosPI * GenerarUniforme();

                serie[i] = temp1 * Math.Cos(temp2) * desviacion + media;
                serie[i + 1] = temp1 * Math.Sin(temp2) * desviacion + media;
            }

            if (cantidad % 2 == 1)
                serie[cantidad - 1] = Math.Sqrt(-2 * Math.Log(GenerarUniforme())) * Math.Cos(dosPI * GenerarUniforme()) * desviacion + media;
            
            return serie;
        }

        public static double[] GenerarNormalConvolucion(double media, double desviacion, int cantidad)
        {
            double suma;

            serie = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                suma = -6;
                for (int j = 0; j < 12; j++)
                    suma += GenerarUniforme();

                serie[i] = suma * desviacion + media;
            }
            return serie;
        }
    }
}
