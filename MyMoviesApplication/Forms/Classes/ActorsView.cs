///Name: Roger Silva Santos Aguiar
///Function: It displays the actors view
///Initial date: February 12, 2021
///Last update: February 12, 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyMoviesApplication.Forms.Classes
{
    public class ActorsView: DatabaseService
    {
        public DataSet LoadActorsView()
        {
            string sql_query = "SELECT * FROM Actors_in_table ORDER BY Actor";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }
    }
}
