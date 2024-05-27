namespace ConsoleApp02.Entidades
{
    public class Primo
    {
        public int Valor { get; }

        public Primo(int valor)
        {
            if (!EsPrimo(valor))
            {
                throw new ArgumentException($"{valor} no es un número primo.");
            }
            Valor = valor;
        }
        /// <summary>
        /// Método privado para validar si el número es primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
