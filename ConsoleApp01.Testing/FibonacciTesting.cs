using ConsoleApp01.Entidades;

namespace ConsoleApp01.Testing
{
    [TestClass]
    public class FibonacciTesting
    {
        [TestMethod]
        public void GenerarSerie()
        {
            int cantidad = 10;
            var f = new Fibonacci(cantidad);
            Assert.AreEqual(cantidad, f.CantidadTerminos());
        }

        [TestMethod]
        public void VerificarSiEstaVacio()
        {
            int cantidad = 10;
            var f = new Fibonacci(cantidad);
            Assert.IsTrue(f.GetTope()==-1);
        }
        [TestMethod]
        public void VerificarSiEstaLleno()
        {
            int cantidad = 10;
            var f = new Fibonacci(cantidad);
            f.GenerarTerminos();
            Assert.IsTrue(f.GetTope() == f.CantidadTerminos()-1);
        }
        [TestMethod]
        public void VerificarSobreCargaInt()
        {
            int cantidad = 5;
            var f = new Fibonacci(cantidad);
            f.GenerarTerminos();
            var resultado = f;
            Assert.AreEqual(7, resultado);
        }
        [TestMethod]
        public void VerificarExisteTerminoOK()
        {
            var t = new Termino(2);
            var f = new Fibonacci(5);//0 1 1 2 3
            f.GenerarTerminos();
            (bool, int?) resultado = f.BuscarTermino(t);
            Assert.AreEqual(true,resultado.Item1);
        }
        [TestMethod]
        public void VerificarExisteTerminoNoEsta()
        {
            var t = new Termino(15);
            var f = new Fibonacci(5);//0 1 1 2 3
            f.GenerarTerminos();
            (bool, int?) resultado = f.BuscarTermino(t);
            Assert.AreEqual(false, resultado.Item1);
        }

    }
}
