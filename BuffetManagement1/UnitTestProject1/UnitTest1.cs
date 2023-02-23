using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cliente = new BuffetManagement.Modelo.Cliente();
            cliente.Nome = "Bruno";
            cliente.Telefone = "190";
            cliente.Cpf = "12345678910";
            var cadastro = new BuffetManagement.Negócio.Cliente().Create(cliente);
            Assert.AreEqual(true, cadastro);
        }
    }
}