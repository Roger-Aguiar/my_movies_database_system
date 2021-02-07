///Name:         Roger Silva Santos Aguiar
///Function:     It implements all the operations with the Movies table
///Initial date: February 6, 2021
///Last update:  February 7, 2021

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
    public class Movies: DatabaseService
    {
        public void Insert(string title, string originalTitle, string year, string linkIMDB, DateTime registerDate, DateTime lastUpdate, int idGenre)
        {
            string sql_query = "INSERT INTO movies(title, originalTitle, year, linkIMDB, registerDate, lastUpdate, idGenre)VALUES(@title, @originalTitle, @year, @linkIMDB, @registerDate, @lastUpdate, @idgGenre)";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@originalTitle", originalTitle);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@linkIMDB", linkIMDB);
                cmd.Parameters.AddWithValue("@registerDate", registerDate);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);
                cmd.Parameters.AddWithValue("@idGenre", idGenre);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Operation has been completed!", "Information",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }

        public void LoadTable()
        {

        }

        public int SelectIdMovie(string title)
        {
            int idMovie;

            string sql_query = "SELECT idMovie FROM movies WHERE title = @title";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    idMovie = reader.GetInt32(0);
                }
                else
                {
                    idMovie = 0;
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return idMovie;
        }
    }//End class
}
