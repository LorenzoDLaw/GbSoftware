using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manga
{
    public class Dao
    {
        private static Dao _instace;
        //Singleton pattern
        public static Dao INSTACE
        {
            get
            {

                if (_instace == null)
                {
                    _instace = new Dao();
                }
                return _instace;
            }
        }

        private SqlConnection _connection;
        public SqlConnection Connection { get { return _connection; } }

        private Dao()
        {
            _connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDb; Database=MangaData; Integrated Security=true");
            _connection.Open();
        }

    }
}
