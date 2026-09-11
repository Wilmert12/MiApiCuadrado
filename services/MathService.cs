namespace MiApiCuadrado.Services
{
    public class MathService
    {
        public int CalcularMcd(int dividendo, int divisor)
        {
            // Algoritmo de Euclides (basado en el diagrama de flujo de tu tarea)
            while (divisor != 0)
            {
                int residuo = dividendo % divisor;
                dividendo = divisor;
                divisor = residuo;
            }
            return dividendo;
        }
    }
}