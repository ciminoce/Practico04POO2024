using System.Text;

namespace ConsoleApp01.Entidades
{
    public class Fibonacci
    {
        private readonly int _cantidadTerminos;
        private Termino[] terminos;
        private int _tope = -1;
        public int GetTope() => _tope;
        public int CantidadTerminos() => _cantidadTerminos;

        public Fibonacci(int cantidadTerminos)
        {
            _cantidadTerminos = cantidadTerminos >= 2 && cantidadTerminos <= 20 ? cantidadTerminos : 5;
            terminos = new Termino[_cantidadTerminos];
        }

        public Fibonacci() : this(5) { }

        private bool EstaVacio() => _tope == -1;
        private bool EstaLleno() => _tope == _cantidadTerminos - 1;

        public static bool operator +(Fibonacci f, Termino t)
        {
            if (f is null || t is null) return false;
            if (f.EstaLleno()) return false;

            if (f != t)
            {
                f._tope++;
                f.terminos[f._tope] = t;
                return true;
            }
            return false;
        }

        public static bool operator ==(Fibonacci f, Termino t)
        {
            if (f is null || t is null) return false;
            if (f.EstaVacio()) return false;

            foreach (var terminoEnArray in f.terminos)
            {
                if (terminoEnArray == t) return true;
            }
            return false;
        }

        public static bool operator !=(Fibonacci f, Termino t)
        {
            return !(f == t);
        }

        public void GenerarTerminos()
        {
            terminos[0] = new Termino(0, 1);
            terminos[1] = new Termino(1, 1);
            _tope = 1;

            for (int i = 2; i < _cantidadTerminos; i++)
            {
                _tope++;
                terminos[i] = terminos[i - 2] + terminos[i - 1] ?? new Termino(0);
                terminos[i].Posicion = _tope;
            }
        }

        public Termino? GetTermino(int index)
        {
            if (EstaVacio()) return null;
            return index >= 0 && index < _cantidadTerminos ? terminos[index] : null;
        }

        public string MostrarTerminosEnLinea()
        {
            if (EstaVacio()) return "No hay términos";
            return MostrarArray(terminos);
        }

        public string MostrarTerminosDecreciente()
        {
            if (EstaVacio()) return "No hay términos";
            var terminosRe = terminos.Reverse().ToArray();
            return MostrarArray(terminosRe);
        }

        private string MostrarArray(Termino[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var termino in array)
            {
                sb.Append($"{termino} ");
            }
            return sb.ToString();
        }

        public (bool, int?) BuscarTermino(Termino t)
        {
            if (EstaVacio()) return (false, null);

            for (int i = 0; i < _cantidadTerminos; i++)
            {
                if (t == terminos[i])
                {
                    return (true, terminos[i].Posicion);
                }
            }
            return (false, null);
        }

        public Termino[] GetTerminos() => terminos;

        public static implicit operator int(Fibonacci f)
        {
            if (f is null || f.EstaVacio()) return 0;

            int sumaTerminos = 0;
            foreach (var termino in f.GetTerminos())
            {
                sumaTerminos += termino.GetNumero();
            }
            return sumaTerminos;
        }

        public static implicit operator double(Fibonacci f)
        {
            return (double)f / f._cantidadTerminos;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || obj is not Fibonacci other) return false;
            if (_cantidadTerminos != other._cantidadTerminos) return false;

            return terminos.SequenceEqual(other.GetTerminos());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                foreach (var termino in terminos)
                {
                    hash = hash * 23 + (termino?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }
    }
}
