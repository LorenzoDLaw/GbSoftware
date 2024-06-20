using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga.Repository
{
    public class PersoneRepository
    {
        public List<Persone> GetAll()
        {
            List<Persone> peopleList = new List<Persone>();

            string query = "SELECT * FROM Persona";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = query;
            SqlDataReader reader;
            using (reader = commnad.ExecuteReader())
            {
                while (reader.Read())
                {
                    peopleList.Add(new Persone()
                    {
                        Id = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Cognome = reader.GetString(2),
                        Citta = reader.GetString(3),
                        Anno = reader.GetInt32(4),
                    });
                }
            }
            return peopleList;
        }


        public List<Persone> GetByNome()
        {
            List<Persone> persona = new List<Persone>();

            string query = "SELECT DISTINCT id, Nome FROM Persona";
            SqlCommand command = Dao.INSTACE.Connection.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader;
            using (reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    persona.Add(new Persone()
                    {
                        Id= reader.GetInt32(0),
                        Nome = reader.GetString(1),
                    });
                }
            }
            return persona;
        }



        public void NewPersona(Persone persona)
        {
            string queryNewManga = "INSERT INTO Persona(Nome, Cognome, Citta, Anno) VALUES  (@Nome, @Cognome, @Citta, @Anno)";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryNewManga;
            commnad.Parameters.AddWithValue("@Nome", persona.Nome);
            commnad.Parameters.AddWithValue("@Cognome", persona.Cognome);
            commnad.Parameters.AddWithValue("@Citta", persona.Citta);
            commnad.Parameters.AddWithValue("@Anno", persona.Anno);

            commnad.ExecuteNonQuery();
        }

        public void UpdatePersona(Persone persona)
        {
            string queryUpdate = "UPDATE Persona SET Nome= @Nome, Cognome = @Cognome, Citta = @Citta, Anno = @Anno WHERE Id = @Id";
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryUpdate;
            commnad.Parameters.AddWithValue("@Id", persona.Id);
            commnad.Parameters.AddWithValue("@Nome", persona.Nome);
            commnad.Parameters.AddWithValue("@Cognome", persona.Cognome);
            commnad.Parameters.AddWithValue("@Citta", persona.Citta);
            commnad.Parameters.AddWithValue("@Anno", persona.Anno);

            commnad.ExecuteNonQuery();
        }
        public void DeletePersona(int id)
        {
            string queryDelete = "DELETE FROM Persona WHERE Id = @Id";
            SqlParameter paramId = new SqlParameter("@id", id);
            SqlCommand commnad = Dao.INSTACE.Connection.CreateCommand();
            commnad.CommandText = queryDelete;
            commnad.Parameters.AddWithValue("@Id", id);
            commnad.ExecuteNonQuery();
        }
    }
}
