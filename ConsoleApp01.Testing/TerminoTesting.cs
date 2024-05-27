using ConsoleApp01.Entidades;

namespace ConsoleApp01.Testing
{
    [TestClass]
    public class TerminoTesting
    {
        [TestMethod]
        public void CrearTermino()
        {
            int numero = 5;
            Termino t=new Termino(numero);
            Assert.AreEqual(numero, t.GetNumero());
        }
        [TestMethod]
        public void CompararTerminosIguales()
        {
            int numero = 5;
            Termino t1 = new Termino(numero);
            Termino t2 = new Termino(numero);
            Assert.IsTrue(t1 == t2);
        }

        [TestMethod]
        public void CompararTerminosDistintos()
        {
            int numero = 5;
            Termino t1 = new Termino(numero);
            Termino t2 = new Termino(10);
            Assert.IsFalse(t1 == t2);
        }

    }
}