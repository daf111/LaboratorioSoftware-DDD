using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_DominioTests
{
    [TestClass]
    public class TipoProductoDominioTest
    {
        [TestMethod]
        public void Validar_ConDatosValidos_Valido()
        {
            //Arrange
            _02_Dominio.Entidades.TipoProducto tipoProducto = new _02_Dominio.Entidades.TipoProducto() { Id = 1, Nombre = "Test" };

            //Act
            bool resultado = tipoProducto.Validar();

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Validar_ConDatosNoValidos_NoValido()
        {
            //Arrange
            _02_Dominio.Entidades.TipoProducto tipoProducto = new _02_Dominio.Entidades.TipoProducto() { Id = 1, Nombre = "" };

            //Act
            bool resultado = tipoProducto.Validar();

            //Assert
            Assert.IsFalse(resultado);
        }
    }
}
