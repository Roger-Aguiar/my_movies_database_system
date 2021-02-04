///Name:         Roger Silva Santos Aguiar 
///Function:     This is the connection class
///Initial date: February 2, 2021
///Last update:  February 2, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyMoviesApplication.Forms.Classes
{
    public class DatabaseService
    {
        private string GetStringConnection()
        {
            string MyConnectionString = "Server=localhost;Database=my_movies;Uid=root;Pwd=983453069";
            return MyConnectionString;
        }

        public DataSet LoadData(string sql_query)
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

        public void InsertRow(string sql_query)
        {

        }
        
    }
}
