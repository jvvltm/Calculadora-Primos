using System.Diagnostics;



namespace NumerosPrimos_Negocio
{
    public static class Negocio
    {
        
        //metodo para determinar si es primo
        public static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }


        //metodo para los calculos
        public static (string rango, int menor, int mayor, int cantidad, double tiempo) CalcularPrimos(string rango)
        {
            //rango
            var partes = rango.Split('-');
            int inicio = int.Parse(partes[0]);
            int fin = int.Parse(partes[1]);
            
            //iniciar cronometro
            Stopwatch stopwatch = Stopwatch.StartNew();
           
            
            //lista de primos
            List<int> primos = new List<int>();
            

            //bucle para encontrar primos
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    primos.Add(i);
                }
            }

            //detener cronometro
            stopwatch.Stop();

            //resultados menor mayor y tiempo
            int menor = primos.Count > 0 ? primos[0] : 0;
            int mayor = primos.Count > 0 ? primos[^1] : 0;
            double tiempo = stopwatch.Elapsed.TotalSeconds;

            return (rango, menor, mayor, primos.Count, tiempo);

        }


    }
}
