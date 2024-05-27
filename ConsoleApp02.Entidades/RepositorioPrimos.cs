namespace ConsoleApp02.Entidades
{
    public class RepositorioPrimos
    {
        private int cantidad;
        private Primo[]? primos;

        public int Cantidad => cantidad;

        public RepositorioPrimos() : this(5) { }

        public RepositorioPrimos(int cantidad)
        {
            this.cantidad = cantidad;
            primos = new Primo[cantidad];
        }

        public void AgregarPrimo(Primo primo)
        {
            for (int i = 0; i < primos?.Length; i++)
            {
                if (primos[i] == null)
                {
                    primos[i] = primo;
                    return;
                }
            }
            throw new InvalidOperationException("No hay espacio para agregar más números primos.");
        }

        public void QuitarPrimo(Primo primo)
        {
            if (primos == null)
            {
                throw new InvalidOperationException("El array de primos no está inicializado.");
            }

            for (int i = 0; i < primos.Length; i++)
            {
                if (primos[i] is not null && primos[i].Valor == primo.Valor)
                {
                    primos[i] = null;
                    return;
                }
            }
            throw new ArgumentException("El número primo no se encontró en la colección.");
        }
        public Primo? ObtenerPrimo(int index)
        {
            if (index < 0 || index >= primos?.Length || primos?[index] is null)
            {
                throw new ArgumentOutOfRangeException("El índice está fuera de rango o el primo no existe.");
            }
            return primos[index];
        }

        public string MostrarPrimos()
        {
            if (primos is null)
            {
                return "No se han cargado números primos todavía";

            }
            else
            {

                return string.Join(", ", primos
                    .Where(p => p is not null)
                    .Select(p => p.ToString()));

            }
        }

        public void OrdenarPrimos(bool ascendente = true)
        {
            if (primos == null)
            {
                throw new InvalidOperationException("El array de primos no está inicializado.");
            }
            var primosOrdenados = primos?.Where(p => p != null)
                        .OrderBy(p => p.Valor).ToArray();
            if (!ascendente)
            {
                primosOrdenados = primosOrdenados?.Reverse().ToArray();
            }
            for (int i = 0; i < primosOrdenados?.Length; i++)
            {
                primos[i] = primosOrdenados[i];
            }

        }

        public (bool, int) ContienePrimo(int valor)
        {
            for (int i = 0; i < primos?.Length; i++)
            {
                if (primos[i] != null && primos[i].Valor == valor)
                {
                    return (true, i);
                }
            }
            return (false, -1);
        }

        public static implicit operator int(RepositorioPrimos repo)
        {
            return repo.primos?.Sum(p=>p.Valor) ?? 0;
        }
    }
}
