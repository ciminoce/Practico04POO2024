using ConsoleApp01.Entidades;

namespace ConsoleApp01.Windows
{
    public partial class Form1 : Form
    {
        private Fibonacci? fibonacci;
        private int cantidad;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                fibonacci = new Fibonacci(cantidad);
                fibonacci.GenerarTerminos();
                MostrarTerminos(fibonacci.GetTerminos());
            }
        }

        private void MostrarTerminos(Termino[]? terminos)
        {
            lsbFibonacci.Items.Clear();
            for (int i = 0; i < terminos?.Length; i++)
            {
                Termino? termino = terminos[i];
                if (termino is not null)
                {
                    lsbFibonacci.Items.Add(termino.ToString());
                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!int.TryParse(txtCantidad.Text, out cantidad) || (cantidad <= 0))
            {
                valido = false;
                errorProvider1.SetError(txtCantidad, "Cantidad mal ingresada");

            }
            return valido;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lsbFibonacci.Items.Clear();
            errorProvider1.Clear();
            txtCantidad.Clear();
            txtCantidad.Focus();
        }

        private void rbtDesc_CheckedChanged(object sender, EventArgs e)
        {
            var terminos = fibonacci?.GetTerminos();

            MostrarTerminos(terminos?.Reverse().ToArray());
        }

        private void rbtAsc_CheckedChanged(object sender, EventArgs e)
        {
            MostrarTerminos(fibonacci?.GetTerminos()); ;
        }
    }
}
