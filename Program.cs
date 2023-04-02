using static System.Console;

namespace ConPerimetroOptimizado
{
    class CalculoPerimetroCuadrilatero
    {
        static void Main()
        {
            Write("Ingrese el alto del rectangulo: ");
            double.TryParse(ReadLine(), out double alto);

            Write("Ingrese el ancho del rectangulo: ");
            double.TryParse(ReadLine(), out double ancho);

            double perimetro = 2 * (alto + ancho);
            WriteLine($"El perimetro es {perimetro}");

            ReadKey();
        }
    }
}