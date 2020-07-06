using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03_InfraestructuraDatos.NPOCO;

namespace _01_AplicacionTests
{
    [TestClass]
    public class ClienteAplicacionTest
    {
        [TestMethod]
        public void ValidarListarPor_ConDatosValidos_Valido()
        {
            //Arrange
            _01_Aplicacion.ClienteServicio servicioCL = new _01_Aplicacion.ClienteServicio(new _03_InfraestructuraDatos.NPOCO.ClienteRepositorio());

            //Act
            _02_Dominio.Entidades.Cliente cliente = servicioCL.ListarPor(2);

            //Assert
            Assert.IsNotNull(cliente);
        }

        [TestMethod]
        public void ValidarListarPor_ConDatosInvalidos_Invalido()
        {
            //Arrange
            _01_Aplicacion.ClienteServicio servicioCL = new _01_Aplicacion.ClienteServicio(new _03_InfraestructuraDatos.NPOCO.ClienteRepositorio());

            //Act and assert
            try
            {
                _02_Dominio.Entidades.Cliente cliente = servicioCL.ListarPor(34);
            }
            catch (InvalidOperationException ioe){
                //Assert
                StringAssert.Contains(ioe.Message, ClienteRepositorio.MensajeIdClienteNoExiste);
                return;
            }
            Assert.Fail("El cliente no existe");

        }

        [TestMethod]
        public void ValidarActualizar_ConDatosValidos_Valido()
        {
            //Arrange
            _01_Aplicacion.ClienteServicio servicioCL = new _01_Aplicacion.ClienteServicio(new _03_InfraestructuraDatos.NPOCO.ClienteRepositorio());
            _02_Dominio.Entidades.Cliente clienteMod = servicioCL.ListarPor(3);
            clienteMod.Nombre = "Roberto";
            String esperado = clienteMod.Nombre; 

            //Act
            servicioCL.Actualizar(clienteMod);

            //Assert
            String actual = servicioCL.ListarPor(3).Nombre;
            Assert.AreEqual(esperado, actual);
        }

    }
}
