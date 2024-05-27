using ConsoleApp03.Entidades;
namespace ConsoleApp03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumerosLocos numerosLocos = new NumerosLocos();
            numerosLocos.MostrarNumeros();
            Console.WriteLine(numerosLocos.MostrarPositivosOrdenadosDecreciente());
            Console.WriteLine(numerosLocos.MostrarNegativosOrdenadosCreciente());
            Console.WriteLine($"Promedio de los números: {numerosLocos.ObtenerPromedio()}");
            Console.WriteLine($"Suma de los números: {numerosLocos.ObtenerSuma()}");
        }
    }
}
