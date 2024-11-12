using NumerosPrimos_Negocio;

namespace NumerosPrimos_Soporte
{
    public class Soporte
    {
        public (string rango, int menor, int mayor, int cantidad, double tiempo) ObtenerResultados (string rango)
        {
            return Negocio.CalcularPrimos(rango);
        }
    }
}
