using MathExpert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpertTest
{
    [TestClass]
    public class CalculadorMSTests
    {

        [TestMethod]

        public void SumarNumeros_IngresarDosNumeros_ObtenerSuma()
        {
            //Arrange
           Calculador calculador = new Calculador();


            //Act
            int result = calculador.SumarNumeros(5, 6);


            //Assert
            Assert.AreEqual(11,result);
        }
    }
}
