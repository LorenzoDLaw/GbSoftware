using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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


        public void NewManga(Manga manga)
        {
            string queryNewManga = "INSERT INTO Manga(Titolo, tipo, Prezzo, NumPagine, IdPersona) VALUES  (@Titolo, @Tipo, @Prezzo, @NumeroPagine, @IdPersona)";
            PersoneRepository personeRepository = new PersoneRepository();
            personeRepository.GetAll();
            SqlCommand command = Dao.INSTACE.Connection.CreateCommand();
            command.CommandText = queryNewManga;
            command.Parameters.AddWithValue("@Titolo", manga.Titolo);
            command.Parameters.AddWithValue("@Tipo", manga.Tipo);
            command.Parameters.AddWithValue("@Prezzo", manga.Prezzo);
            command.Parameters.AddWithValue("@NumeroPagine", manga.NumeroPagine);
            command.Parameters.AddWithValue("@IdPersona", );

            command.ExecuteNonQuery();
        }




        public void UpdateManga(Manga manga)
        {
            string queryUpdate = "UPDATE Manga SET Titolo= @Titolo, Tipo = @Tipo, Prezzo = @Prezzo, NumPagine= @NumeroPagine WHERE Id = @Id";
            SqlCommand command = Dao.INSTACE.Connection.CreateCommand();
            command.CommandText = queryUpdate;
            //command.Parameters.AddWithValue("@Id", manga.Id);
            command.Parameters.AddWithValue("@Titolo", manga.Titolo);
            command.Parameters.AddWithValue("@Tipo", (int)manga.Tipo);
            command.Parameters.AddWithValue("@Prezzo", manga.Prezzo);
            command.Parameters.AddWithValue("@NumeroPagine", manga.NumeroPagine);

            command.ExecuteNonQuery();
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
