using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_ProjetoLivraria.Models
{
    public interface ILivroRepositorio
    {
        IEnumerable<Livro> All { get; }
        Livro Find(int id);
        void Insert(Livro item);
        void Update(Livro item);
        void Delete(int id);
    }
}
