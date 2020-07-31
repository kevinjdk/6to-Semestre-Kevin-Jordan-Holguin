using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class ComparadorTest
    {
        [TestMethod]
        public void ObtenerMenor()
        {
            //
            var priemerE = 54;
            var segundoE = 13;
            var esperado = 13;

            Comparador comparador = new Comparador();
            int actual = comparador.ObtenerMenor(priemerE, segundoE);

            Assert.AreEqual(esperado, actual);
        }
    }
}
