using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_ProjetoLivraria.Models
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private List<Livro> _livros;

        public LivroRepositorio()
        {
            InicializaDados();
        }

        private void InicializaDados()
        {
            _livros = DalHelper.GetLivros();
        }

        public IEnumerable<Livro> All
        {
            get
            {
                return _livros;
            }
        }

        public void Delete(int id)
        {
            _livros.Remove(this.Find(id));
        }

        public Livro Find(int id)
        {
            return DalHelper.GetLivro(id);
        }

        public void Insert(Livro livro)
        {
            if (livro == null)
            {
                throw new ArgumentNullException("livro");
            }
            DalHelper.InsertLivro(livro);
        }

        public void Update(Livro livro)
        {
            if (livro == null)
            {
                throw new ArgumentNullException("livro");
            }
            DalHelper.UpdateLivro(livro);
        }
    }
}