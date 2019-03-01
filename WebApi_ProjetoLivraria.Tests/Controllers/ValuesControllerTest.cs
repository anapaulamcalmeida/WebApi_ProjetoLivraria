using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_ProjetoLivraria.Controllers;

namespace WebApi_ProjetoLivraria.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Organizar
            //ValuesController controller = new ValuesController();

            // Agir
            //IEnumerable<string> result = controller.Get(5);

            // Declarar
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Organizar
            //ValuesController controller = new ValuesController();

            // Agir
            //string result = controller.Get(5).ToString();

            // Declarar
            //Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
        }

        [TestMethod]
        public void Put()
        {
        }


        [TestMethod]
        public void Delete()
        {
        }
    }

    internal class ValuesController
    {
        internal IEnumerable<string> Get(int v)
        {
            throw new NotImplementedException();
        }
    }
}
