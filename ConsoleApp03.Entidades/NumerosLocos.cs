using System.Text;

namespace ConsoleApp03.Entidades
{
    public class NumerosLocos
    {
        private int[] _numeros;
        private const int DefaultCapacity = 20;

        public NumerosLocos() : this(DefaultCapacity) { }

        public NumerosLocos(int capacity)
        {
            if (capacity < DefaultCapacity)
            {
                capacity = DefaultCapacity;
            }
            _numeros = new int[capacity];
            GenerarNumeros();
        }

        private void GenerarNumeros()
        {
            Random random = new Random();
            for (int i = 0; i < _numeros.Length; i++)
            {
                _numeros[i] = random.Next(-100, 101);
                if (_numeros[i] == 0)
                {
                    i--;
                }
            }
        }

        public string MostrarNumeros()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine("Números generados:");
            sb.AppendLine(string.Join(Environment.NewLine, _numeros));
            return sb.ToString();
        }

        public string MostrarPositivosOrdenadosDecreciente()
        {
            var positivos = _numeros.Where(n => n > 0)
                .OrderByDescending(n => n).ToArray();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Números positivos ordenados decrecientemente:");
            sb.AppendLine(string.Join(", ", positivos));
            return sb.ToString();
        }

        public string MostrarNegativosOrdenadosCreciente()
        {
            var negativos = _numeros.Where(n => n < 0).OrderBy(n => n).ToArray();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Números negativos ordenados crecientemente:");
            sb.AppendLine(string.Join(Environment.NewLine, negativos));
            return sb.ToString();
        }

        // Métodos adicionales convenientes para el diseño

        // Método para obtener el promedio de los números generados
        public double ObtenerPromedio()
        {
            return _numeros.Average();
        }

        // Método para obtener la suma de todos los números generados
        public int ObtenerSuma()
        {
            return _numeros.Sum();
        }
    }
}
