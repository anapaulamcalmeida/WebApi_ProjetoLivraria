using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.WebPages;


namespace WebApi_ProjetoLivraria.Models
{
    public class DalHelper 
    {
        

        protected static string GetStringConexao()
        {
            return ConfigurationManager.ConnectionStrings["conexaoSQLServer"].ConnectionString;
        }

        public static List<Livro> GetLivros()
        {
            List<Livro> _livros = new List<Livro>();


            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select ID, ISBN, AUTOR, NOME, PRECO, DATAPUBLICACAO = convert(varchar(10),DATAPUBLICACAO,103), IMAGEMCAPA from LIVRO", con))

                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                List<byte[]> listImagemCapa = new  List<byte[]>();

                                var livro = new Livro();
                                livro.Id = Convert.ToInt32(dr["Id"]);
                                livro.ISBN = dr["ISBN"].ToString();
                                livro.Autor = dr["Autor"].ToString();
                                livro.Nome = dr["Nome"].ToString();
                                livro.Preco = Convert.ToDecimal(dr["Preco"]);

                                if (dr["DataPublicacao"] != null && !dr["DataPublicacao"].ToString().Trim().IsEmpty())
                                {
                                    livro.DataPublicacao = dr["DataPublicacao"].ToString();
                                }

                                if (dr["ImagemCapa"] != null && !dr["ImagemCapa"].ToString().Trim().IsEmpty())
                                {
                                    listImagemCapa.Add((byte[])dr["ImagemCapa"]);
                                    livro.ImagemCapa = listImagemCapa;
                                }
                             
                                _livros.Add(livro);
                            }
                        }
                        return _livros;
                    }
                }
            }
        }

        public static Livro GetLivro(int id)
        {
            Livro livro = null;
            
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select ID, ISBN, AUTOR, NOME, PRECO, DATAPUBLICACAO = convert(varchar(10),DATAPUBLICACAO,103), IMAGEMCAPA from LIVRO where ID = " + id, con))

                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                List<byte[]> listImagemCapa = new List<byte[]>();

                                livro = new Livro();
                                livro.Id = Convert.ToInt32(dr["Id"]);
                                livro.ISBN = dr["ISBN"].ToString();
                                livro.Autor = dr["Autor"].ToString();
                                livro.Nome = dr["Nome"].ToString();
                                livro.Preco = Convert.ToDecimal(dr["Preco"]);

                                if (dr["DataPublicacao"] != null && !dr["DataPublicacao"].ToString().Trim().IsEmpty())
                                {
                                    livro.DataPublicacao = dr["DataPublicacao"].ToString();
                                }

                                if (dr["ImagemCapa"] != null && !dr["ImagemCapa"].ToString().Trim().IsEmpty())
                                {
                                    listImagemCapa.Add((byte[])dr["ImagemCapa"]);
                                    livro.ImagemCapa = listImagemCapa;
                                }                               
                            }
                        }
                        return livro;
                    }
                }
            }

        }

        public static int InsertLivro(Livro livro)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "Insert into LIVRO (ISBN, Autor, Nome, Preco, DataPublicacao, ImagemCapa) values (@ISBN, @Autor, @Nome, @Preco, @DataPublicacao)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);
                    cmd.Parameters.AddWithValue("@Autor", livro.Autor);
                    cmd.Parameters.AddWithValue("@Nome", livro.Nome);
                    cmd.Parameters.AddWithValue("@Preco", livro.Preco);
                    cmd.Parameters.AddWithValue("@DataPublicacao", livro.DataPublicacao);
                    cmd.Parameters.AddWithValue("@ImagemCapa", livro.ImagemCapa);
                                       
                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }

        public static int UpdateLivro(Livro livro)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "update LIVRO set ISBN=@ISBN, Autor=@Autor, Nome=@Nome, Preco=@Preco, DataPublicacao=@DataPublicacao where ID = " + livro.Id;

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ISBN", livro.ISBN);
                    cmd.Parameters.AddWithValue("@Autor", livro.Autor);
                    cmd.Parameters.AddWithValue("@Nome", livro.Nome);
                    cmd.Parameters.AddWithValue("@Preco", livro.Preco);
                    cmd.Parameters.AddWithValue("@DataPublicacao", livro.DataPublicacao);
                    cmd.Parameters.AddWithValue("@ImagemCapa", livro.ImagemCapa);

                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }

        public static int DeleteLivro(int id)
        {
            int reg = 0;
            using (SqlConnection con = new SqlConnection(GetStringConexao()))
            {
                string sql = "delete from LIVRO where ID = " + id;

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Id", id   );
                    
                    con.Open();
                    reg = cmd.ExecuteNonQuery();
                    con.Close();
                }
                return reg;
            }
        }
    }
}