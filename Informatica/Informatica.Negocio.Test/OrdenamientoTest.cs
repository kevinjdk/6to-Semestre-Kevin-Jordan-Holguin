using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class OrdenamientoTest
    {
        [TestMethod]
        public void TresElementos()
        {
            //Organizar datos
            var primero = 45;
            var segundo = 23;
            var tercero = 15;

            var esperado0 = 15; //primer valor
            var esperado1 = 23; //segundo valor

            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);

            Assert.AreEqual(esperado0, esperados[0]);
            Assert.AreEqual(esperado1, esperados[1]);
        }

        [TestMethod]
        public void TresElementosConNegativos()
        {
            //Organizar datos
            var primero = 45;
            var segundo = -23;
            var tercero = 15;

            var esperado0 = -23; //primer valor
            var esperado1 = 15; //segundo valor

            Ordenamiento ordenamiento = new Ordenamiento();
            List<int> esperados = ordenamiento.Ordenar(primero, segundo, tercero);

            Assert.AreEqual(esperado0, esperados[0]);
            Assert.AreEqual(esperado1, esperados[1]);
        }
    }
}