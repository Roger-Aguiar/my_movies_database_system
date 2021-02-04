///Name:         Roger Silva Santos Aguiar
///Function:     Actors table operation
///Initial date: February 4, 2021
///Last update:  February 4, 2021
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

        public void Delete(int idActor)
        {
            string sql_query = "DELETE FROM actors WHERE idActor = @idActor";
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@idActor", idActor);                
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

        public DataSet LoadActorsTable()
        {
            string sql_query = "SELECT * FROM actors";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }


    }
}
