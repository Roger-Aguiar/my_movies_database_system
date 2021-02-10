///Name:         Roger Silva Santos Aguiar
///Function:     This class implements the operations with the Genres table
///Initial date: February 6, 2021
///Last update:  February 8, 2021
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
        public void Insert(string genre, DateTime registerDate)
        {
            string sql_query = "INSERT INTO genres(genre, registerDate)VALUES(@genre, @registerDate)";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@genre", genre);                
                cmd.Parameters.AddWithValue("@registerDate", registerDate);
                
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            MessageBox.Show("Operation has been completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete(int id)
        {
            string sql_query = "DELETE FROM genres WHERE idGenre = @id";
            Delete(id, sql_query);
            MessageBox.Show("Operation has been completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Update(int idGenre, string genre, DateTime registerDate)
        {
            string sql_query = "UPDATE genres SET genre = @genre, registerDate = @registerDate WHERE idGenre = @idGenre;";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@idGenre", idGenre);
                cmd.Parameters.AddWithValue("@genre", genre);                
                cmd.Parameters.AddWithValue("@registerDate", registerDate);
               
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

        public DataSet LoadTable()
        {
            string sql_query = "SELECT idGenre AS Id, genre AS Genre, registerDate AS Registered FROM genres ORDER BY genre; ";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
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
                    idGenre = Convert.ToInt32(reader["idGenre"]);
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

        public string GetGenre(int idGenre)
        {
            string genre = null;
            string sql_query = "SELECT genre FROM genres WHERE idGenre = @idGenre";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                cmd.Parameters.AddWithValue("@idGenre", idGenre);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    genre = reader["genre"].ToString();
                }
                else
                {
                    genre = null;
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return genre;
        }

        public List<string> SelectGenres()
        {
            List<string> genres = new List<string>();

            string sql_query = "SELECT genre FROM genres";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql_query, connection_string);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    genres.Add(row["genre"].ToString());
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return genres;
        }
    }
}
