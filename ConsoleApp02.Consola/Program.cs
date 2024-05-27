using ConsoleApp02.Entidades;
namespace ConsoleApp02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioPrimos repo = new RepositorioPrimos(10);

            try
            {
                repo.AgregarPrimo(new Primo(2));
                repo.AgregarPrimo(new Primo(3));
                repo.AgregarPrimo(new Primo(5));
                repo.AgregarPrimo(new Primo(7));
                repo.AgregarPrimo(new Primo(11));

                Console.WriteLine("Primos almacenados:");
                Console.WriteLine(repo.MostrarPrimos());

                var (existe, posicion) = repo.ContienePrimo(5);
                Console.WriteLine(existe ? $"El primo 5 está en la posición {posicion}." : "El primo 5 no se encuentra.");

                Console.WriteLine("Ordenando primos en orden descendente:");
                repo.OrdenarPrimos(false);
                Console.WriteLine(repo.MostrarPrimos());

                repo.QuitarPrimo(new Primo(7));
                Console.WriteLine("Después de quitar el primo 7:");
                Console.WriteLine(repo.MostrarPrimos());

               int suma = repo;
                Console.WriteLine($"Suma de primos:{suma}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
