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
        [Test]
        public void SaludoCliente_IngresarNombreApellido_ObtenerSaludoNombreCompleto()
        {

            Cliente cliente = new Cliente();

            string saludo = cliente.SaludoCliente("edwin", "martinez");

            Assert.That(saludo, Is.EqualTo("hola, edwin martinez"));


        }
    }
}
