using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_ProjetoLivraria.Models
{
    public class Livro
    {
        [Key]
        public Int32 Id { get; set; }
        public String ISBN { get; set; }
        public String Autor { get; set; }
        public String Nome { get; set; }
        public Decimal Preco { get; set; }
        public String DataPublicacao { get; set; }
        public List<byte[]> ImagemCapa { get; set; }
        public bool IsValid { get; set; }
    }
}