using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Repository
{
    public class MangaRepository
    {
        public List<Manga> GetAll()
        {
            List<Manga> mangaList = new List<Manga>();

            string query = "SELECT * FROM Manga";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = query;
            SqlDataReader reader;
            using (reader = commnad.ExecuteReader())
            {
                while (reader.Read())
                {
                    mangaList.Add(new Manga()
                    {
                        Id = reader.GetInt32(0),
                        Titolo = reader.GetString(1),
                        Tipo = (EnumManga)reader.GetInt32(2),
                        Prezzo = reader.GetDouble(3),
                        NumeroPagine = reader.GetInt32(4),
                    });
                }
            }
            return mangaList;
        }
        //executenonquery
        public Manga? GetById(string id)
        {
            Manga manga = null;
            string query = "SELECT * FROM Manga WHERE id = @id";
            SqlParameter paramId = new SqlParameter("@id", id);
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.Parameters.Add(paramId);
            commnad.CommandText = query;
            SqlDataReader reader = commnad.ExecuteReader();
            while (reader.Read())
            {
                manga = new Manga()
                {
                    Id = reader.GetInt32(0),
                    Titolo = reader.GetString(1),
                    Tipo = (EnumManga)reader.GetInt32(2),
                    Prezzo = reader.GetDouble(3),
                    NumeroPagine = reader.GetInt32(4),
                };
            }
            return manga;
        }

        public void NewManga(Manga manga)
        {
            string queryNewManga = "INSERT INTO Manga(Titolo, tipo, Prezzo, NumPagine) VALUES  (@Titolo, @Tipo, @Prezzo, @NumeroPagine)";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryNewManga;
            commnad.Parameters.AddWithValue("@Titolo", manga.Titolo);
            commnad.Parameters.AddWithValue("@Tipo", (int)manga.Tipo);
            commnad.Parameters.AddWithValue("@Prezzo", manga.Prezzo);
            commnad.Parameters.AddWithValue("@NumeroPagine", manga.NumeroPagine);

            commnad.ExecuteNonQuery();
        }

        public void UpdateManga(Manga manga)
        {
            string queryUpdate = "UPDATE Manga SET Titolo = @Titolo, Tipo = @Tipo, Prezzo = @Prezzo, NumPagine = @NumeroPagine WHERE Id = @Id";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryUpdate;
            commnad.Parameters.AddWithValue("@Id", manga.Id);
            commnad.Parameters.AddWithValue("@Titolo", manga.Titolo);
            commnad.Parameters.AddWithValue("@Tipo", (int)manga.Tipo);
            commnad.Parameters.AddWithValue("@Prezzo", manga.Prezzo);
            commnad.Parameters.AddWithValue("@NumeroPagine", manga.NumeroPagine);

            commnad.ExecuteNonQuery();
        }
        public void DeleteManga(int id)
        {
            string queryDelete = "DELETE FROM Manga WHERE Id = @Id";
            SqlParameter paramId = new SqlParameter("@id", id);
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryDelete;

            // Parameter
            commnad.Parameters.AddWithValue("@Id", id);
            commnad.ExecuteNonQuery();
        }
    }
}
