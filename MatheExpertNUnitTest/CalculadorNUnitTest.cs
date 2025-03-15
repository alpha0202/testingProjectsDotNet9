using MathExpert;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheExpertNUnitTest
{

    [TestFixture]
    class CalculadorNUnitTest
    {
        [Test]
        public void SumarNumeros_IngresarDosNumeros_ObtenerSuma()
        {
            //Arrange
            Calculador calculador = new Calculador();


            //Act
            int result = calculador.SumarNumeros(5, 6);


            //Assert
            Assert.That(result,Is.EqualTo(11));
            

        }

        [Test]
        public void IsImpar_IngresarNumeroPar_ObtenerFalse()
        {
            //Arange
            Calculador calculador = new Calculador();

            //Act
            bool isImpar = calculador.IsImpar(12);

            //Assert
            Assert.That(isImpar, Is.EqualTo(false));



        }

        [Test]
        [TestCase(11)]
        [TestCase(15)]
        public void IsImpar_IngresarNumeroImpar_ObtenerTrue(int numero)
        {
            //Arange
            Calculador calculador = new Calculador();

            //Act
            bool isImpar = calculador.IsImpar(numero);

            //Assert
            Assert.That(isImpar, Is.EqualTo(true));



        }


        [Test]
        [TestCase(10,ExpectedResult =false)]
        [TestCase(11,ExpectedResult =true)]

        public bool IsImpar_IngresarNumero_ObtenerTrueOrFalse(int numero)
        {
            Calculador calculador = new Calculador();

            bool isImpar = calculador.IsImpar(numero);

            return isImpar;
        }

        [Test]
        [TestCase(5.3, 11.3)]    //16.6
        [TestCase(7.32, 31.45)] //38.77
        public void SumarNumerosDouble_IngresarDosNumeros_ObtenerSuma(double num1, double num2)
        {
            //Arrange
            Calculador calculador = new Calculador();


            //Act
            double result = calculador.SumarNumerosDouble(num1,num2);


            //Assert
            Assert.That(result, Is.InRange(16.6,50.8));


        }







    }
}
