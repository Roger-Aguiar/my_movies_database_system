///Name:         Roger Silva Santos Aguiar
///Function:     It implements all the operations with the Movies table
///Initial date: February 6, 2021
///Last update:  February 10, 2021

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
            string sql_query = "INSERT INTO movies(title, originalTitle, year, linkIMDB, registerDate, lastUpdate, idGenre)VALUES(@title, @originalTitle, @year, @linkIMDB, @registerDate, @lastUpdate, @idGenre)";
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
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Update(int idMovie, string title, string originalTitle, string year, string linkIMDB, DateTime registerDate, DateTime lastUpdate, int idGenre)
        {
            string sql_query = "UPDATE movies SET title = @title, originalTitle = @originalTitle, year = @year, linkIMDB = @linkIMDB, registerDate = @registerDate, lastUpdate = @lastUpdate, idGenre = @idGenre WHERE idMovie = @idMovie;";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@idMovie", idMovie);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@originalTitle", originalTitle);
                cmd.Parameters.AddWithValue("@linkIMDB", linkIMDB);
                cmd.Parameters.AddWithValue("@year", year);
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

        public void Delete(int id)
        {
            string sql_query = "DELETE FROM movies WHERE idMovie = @id";
            Delete(id, sql_query);
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

        public int SelectIdGenre(string title)
        {
            int idGenre;

            string sql_query = "SELECT idGenre FROM movies WHERE title = @title";
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
                    idGenre = reader.GetInt32(0);
                }
                else
                {
                    idGenre = 0;
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return idGenre;
        }

        public DataSet LoadTable()
        {
            string sql_query = "SELECT idMovie AS Id, title AS Title, originalTitle AS Original_title, year AS Year, linkIMDB AS Link, registerDate AS Registered, lastUpdate AS Updated FROM movies ORDER BY title; ";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }
    }//End class
}
