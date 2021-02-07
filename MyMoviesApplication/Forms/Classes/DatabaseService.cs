///Name:         Roger Silva Santos Aguiar 
///Function:     This is the connection class
///Initial date: February 3, 2021
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
    public class DatabaseService
    {
        protected string GetStringConnection()
        {
            string MyConnectionString = "Server=localhost;Database=my_movies2;Uid=root;Pwd=983453069";
            return MyConnectionString;
        }

        protected void Delete(int id, string sql_query)
        {
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;

                cmd.Parameters.AddWithValue("@id", id);
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

        protected DataSet LoadData(string sql_query)
        {
            string connection_string = GetStringConnection();
            MySqlConnection connection = new MySqlConnection(connection_string);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql_query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                connection.Close();
                return dataSet;
            }
            catch(Exception)
            {
                throw;
            }                 
        }//End LoadData()        
    }
}
