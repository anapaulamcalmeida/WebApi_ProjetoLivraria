using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi_ProjetoLivraria.Models;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_ProjetoLivraria.Tests.Models
{
    [TestClass]
    class LivroTest
    {

        [TestMethod]
        public void Livro_Should_Not_Be_Valid_When_Some_Properties_Incorrect()
        {

            //Arrange
            Livro livro = new Livro()
            {
                ISBN = "978-85-94318-09-1",
                Autor = "Franz Kafka",
                Nome = "A metamorfose"
            };

            // Act
            bool isValid = livro.IsValid;

            //Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Livro_Should_Be_Valid_When_All_Properties_Correct()
        {

            //Arrange
            Livro livro = new Livro
            {

                ISBN = "978-85-94318-09-1",
                Autor = "Franz Kafka",
                Nome = "A metamorfose",
                Preco = 19,
                DataPublicacao = "07/12/2007"
            };

            // Act
            bool isValid = livro.IsValid;

            //Assert
            Assert.IsTrue(isValid);
        }
    }
}
