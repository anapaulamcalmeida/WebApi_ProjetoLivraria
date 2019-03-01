using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_ProjetoLivraria.Controllers;


namespace WebApi_ProjetoLivraria.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
