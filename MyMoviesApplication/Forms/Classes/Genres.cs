///Name:         Roger Silva Santos Aguiar
///Function:     This class implements the operations with the Genres table
///Initial date: February 6, 2021
///Last update:  February 6, 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MyMoviesApplication.Forms.Classes
{
    public class Genres: DatabaseService
    {
        public void Insert(string sql_query)
        {

        }

        public void Delete(int id)
        {

        }

        public void Update(int id)
        {

        }

        public int GetIdGenre(string genre)
        {
            int idGenre;
            string sql_query = "SELECT idGenre FROM genres WHERE genre = @genre";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    reader.Read();
                    idGenre = reader.GetInt32(0);
                }
                else
                {
                    idGenre = 0;
                }
                connection.Close();
            }    
            catch(Exception)
            {
                throw;
            }
            return idGenre;
        }
    }
}
