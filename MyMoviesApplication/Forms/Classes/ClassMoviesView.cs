///Name:         Roger Silva Santos Aguiar
///Function:     It implements the views for movies view
///Initial date: February 12, 2021
///Last update:  February 12, 2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MyMoviesApplication.Forms.Classes
{
    public class ClassMoviesView: DatabaseService
    {
        public DataSet LoadActorsView()
        {
            string sql_query = "SELECT * FROM movies_by_actor;";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }

        public DataSet LoadMoviesByActor(string actor)
        {
            string sql_query = "SELECT Title, Link FROM movies_by_actor WHERE Actor = '" + actor + "'";            
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }

        public DataSet LoadActorsByMovie(string movie)
        {
            string sql_query = "SELECT Actor, Link" +
                               " FROM actors_by_movie" +
                               " WHERE Title = '" + movie + "' ORDER BY Actor;";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }

        public DataSet LoadMoviesByGenre(int idGenre)
        {
            string sql_query = "SELECT Title, Link FROM movies_by_genre WHERE Id_genre = " + idGenre;
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }

        public DataSet LoadMoviesByGenreAndActor(int idGenre, string actor)
        {
            string sql_query = "SELECT Title, Original_title, Link FROM movies_by_genre_and_actor WHERE Id_genre = " + 
                                idGenre + " AND Actor = '" + actor + "'";
            DataSet dataSet = LoadData(sql_query);
            return dataSet;
        }

        public List<string> SelectActors()
        {
            List<string> actors = new List<string>();

            string sql_query = "SELECT actorName FROM actors";
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
                    actors.Add(row["actorName"].ToString());
                }

                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return actors;
        }                
    }
}
