///Name:         Roger Silva Santos Aguiar
///Function:     This class implements the operations of Actors_has_Movies table
///Initial date: February 7, 2021
///Last update:  February 7, 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyMoviesApplication.Forms.Classes
{
    public class ActorsHasMovies: DatabaseService
    {
        public void Insert(int idActor, int idMovie)
        {
            string sql_query = "INSERT INTO actors_has_movies(idActor, idMovie)VALUES(@idActor, @idMovie)";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@idActor", idActor);
                cmd.Parameters.AddWithValue("@idMovie", idMovie);               
                cmd.ExecuteNonQuery();
                connection.Close();                               
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
