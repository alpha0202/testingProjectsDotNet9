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
    class ClienteNUnitTests
    {
        private Cliente? cliente;

        [SetUp]
        public void SetUp()
        {
            cliente = new Cliente();
        }

        [Test]
        public void SaludoCliente_IngresarNombreApellido_ObtenerSaludoNombreCompleto()
        {

          
            string saludo = cliente.SaludoCliente("edwin", "martinez");

            Assert.That(saludo, Is.EqualTo("hola, edwin martinez"));
            Assert.That(saludo, Does.Match("hola, [a-z]+ [a-z]+"));

        }
    }
}
