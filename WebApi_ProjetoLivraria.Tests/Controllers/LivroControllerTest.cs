using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_ProjetoLivraria;
using WebApi_ProjetoLivraria.Models;
using WebApi_ProjetoLivraria.Controllers;

namespace WebApi_ProjetoLivraria.Tests.Controllers
{
    class LivroControllerTest
    {

        [TestClass]
        public class TestSimpleProductController
        {
            [TestMethod]
            public void GetAllLivros_ShouldReturnAllLivros()
            {
                //var testLivros = GetTestLivros();
                //var controller = new LivroController();

                //var result = controller.List() as List<Livro>;
                //Assert.AreEqual(testLivros.Count, result.Count);
            }

            private List<Livro> GetTestLivros()
            {
                var testLivros = new List<Livro>();
                testLivros.Add(new Livro { ISBN = "978-85-94318-08-0", Autor = "Luis Felipe Pondé", Nome = "Marketing Existecial", Preco = 20 });
                testLivros.Add(new Livro { ISBN = "978-85-94318-08-2", Autor = "Dr. Howard Chilton", Nome = "Criando bebês",Preco = 25 });
               
                return testLivros;
            }

        }
    }
}


