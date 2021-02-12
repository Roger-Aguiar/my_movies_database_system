///Name:         Roger Silva Santos Aguiar
///Function:     Actors table operation
///Initial date: February 4, 2021
///Last update:  February 12, 2021
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
    public class Actors: DatabaseService
    {
        public void InsertRow(string actorName, int credits, string linkIMDB, DateTime registerDate, DateTime lastUpdate)
        {
            string sql_query = "INSERT INTO actors(actorName, credits, linkIMDB, registerDate, lastUpdate)VALUES(@actorName, @credits, @linkIMDB, @registerDate, @lastUpdate)";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@actorName", actorName);
                cmd.Parameters.AddWithValue("@credits", credits);
                cmd.Parameters.AddWithValue("@linkIMDB", linkIMDB);
                cmd.Parameters.AddWithValue("@registerDate", registerDate);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);
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

        public void DeleteRow(int id)
        {
            string sql_query = "DELETE FROM actors WHERE idActor = @id";
            Delete(id, sql_query);
        }

        public void Update(int idActor, string actorName, int credits, string linkIMDB, DateTime registerDate, DateTime lastUpdate)
        {
            string sql_query = "UPDATE actors SET actorName = @actorName, credits = @credits, linkIMDB = @linkIMDB, registerDate = @registerDate, lastUpdate = @lastUpdate WHERE idActor = @idActor;";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@idActor", idActor);
                cmd.Parameters.AddWithValue("@actorName", actorName);
                cmd.Parameters.AddWithValue("@credits", credits);
                cmd.Parameters.AddWithValue("@linkIMDB", linkIMDB);
                cmd.Parameters.AddWithValue("@registerDate", registerDate);
                cmd.Parameters.AddWithValue("@lastUpdate", lastUpdate);
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

        public int SelectIdActor(string actorName)
        {
            int idActor;

            string sql_query = "SELECT idActor FROM actors WHERE actorName = @actorName";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                cmd.Parameters.AddWithValue("@actorName", actorName);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    idActor = reader.GetInt32(0);
                }
                else
                {
                    idActor = 0;
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return idActor;
        }

        public List<string> SelectActors()
        {
            List<string> actorsName = new List<string>();

            string sql_query = "SELECT actorName FROM actors ORDER BY actorName";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql_query, connection_string);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach(DataRow row in table.Rows)
                {
                    actorsName.Add(row["actorName"].ToString());
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return actorsName;
        }

        public string SelectActorName(string actor)
        {
            string actorName;
            string sql_query = "SELECT LOWER(actorName) FROM actors WHERE actorName = @actor";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                cmd.Parameters.AddWithValue("@actor", actor);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    actorName = reader.GetString(0);
                }
                else
                {
                    actorName = "";
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return actorName;
        }

        public DataSet LoadActorsTable()
        {
            string sql_query = "SELECT idActor AS Id, actorName AS Actor, credits AS Credits, linkIMDB AS Link, registerDate AS Registered, lastUpdate AS Updated FROM actors ORDER BY actorName; ";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }
    }
}
