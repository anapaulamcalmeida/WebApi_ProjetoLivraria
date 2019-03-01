using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_ProjetoLivraria.Models;


namespace WebApi_ProjetoLivraria.Controllers
{
    public class LivroController : ApiController
    {
        private readonly ILivroRepositorio _livroRepositorio;

        public LivroController ()
        {
            _livroRepositorio = new LivroRepositorio();
        }

        // GET: api/Livro
        [HttpGet]
        public IEnumerable<Livro> List()
        {
            return _livroRepositorio.All;
        }
        
        // GET: api/Livro/5
        public Livro GetLivro(int id)
        {
            var livro = _livroRepositorio.Find(id);

            if (livro == null)
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            }
            return livro;
        }

        // POST: api/Livro
        [HttpPost()]
        public void Post([FromBody]Livro livro)
        {
            _livroRepositorio.Insert(livro);
        }

        // PUT: api/Livro/5
        [HttpPut()]
        public void Put(int id, [FromBody]Livro livro)
        {
            livro.Id = id;
            _livroRepositorio.Update(livro);
        }

        // DELETE: api/Livro/5
        [HttpDelete()]
        public void Delete(int id)
        {
            _livroRepositorio.Delete(id);
        }
    }
}
