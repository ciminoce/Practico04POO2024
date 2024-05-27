namespace ConsoleApp01.Entidades
{
    public class Termino
    {
        private readonly int _numero;
        private int? _posicion;
        public Termino(int Numero, int? posicion=null)
        {
            _numero = Numero;
            _posicion = posicion ?? 0;
            //if (posicion is not null)
            //{
            //    _posicion = posicion;
            //}
            //else
            //{
            //    _posicion = null;
            //}
        }
        public int? Posicion { get; set; }
        public int GetNumero() => _numero;
        public static bool operator ==(Termino a, Termino b)
        {
            if (a is null || b is null) { return false; }
            return a.GetNumero() == b.GetNumero();
        }
        public static bool operator !=(Termino a, Termino b)
        {
            
            return !(a == b);
        }
        public static Termino? operator+(Termino a, Termino b)
        {
            if (a is null || b is null)
            {
                return null;
            }
            return new Termino(a.GetNumero() + b.GetNumero());
        }

        public override string ToString()
        {
            return $"{this.GetNumero()}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Termino other))
            {
                return false;
            }
            return this == other;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash += this.GetNumero().GetHashCode() * 26;
            }
        }
    }
}
