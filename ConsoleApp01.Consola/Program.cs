using ConsoleApp01.Entidades;
using MiDLL;
namespace ConsoleApp01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = ConsoleExtensions.ReadInt("Ingrese la cantidad de términos:");
            Termino termino = new Termino(numero);
            Console.WriteLine(termino.ToString());

            Fibonacci f = new Fibonacci(numero);
            f.GenerarTerminos();
            Console.WriteLine(f.MostrarTerminosEnLinea());
            var t = new Termino(2);

            (bool, int?) resultado = f.BuscarTermino(t);
            Console.WriteLine(resultado.Item1);

        }
    }
}
