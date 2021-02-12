///Name:         Roger Silva Santos Aguiar
///Function:     To make the operations with the movies view
///Initial date: February 12, 2021
///Last update:  February 12, 2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoviesApplication.Forms
{
    public partial class FormMoviesView : Form
    {
        private readonly Classes.ClassMoviesView moviesView = new Classes.ClassMoviesView();
        private readonly Classes.Genres genre = new Classes.Genres();
        private readonly Classes.Actors actors = new Classes.Actors();
        private readonly Classes.Movies movie = new Classes.Movies();

        public FormMoviesView()
        {
            InitializeComponent();
            LoadView();
        }

        public void LoadMoviesByActor()
        {            
            DataSet dataSet = moviesView.LoadMoviesByActor(comboBoxActors.SelectedValue.ToString());
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
            labelNumberOfRows.Text = "Number of rows: " + dataGridViewTable.Rows.Count.ToString();
        }

        public void LoadActorsByMovie()
        {
            DataSet dataSet = moviesView.LoadActorsByMovie(comboBoxMovies.Text);
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
            labelNumberOfRows.Text = "Number of rows: " + dataGridViewTable.Rows.Count.ToString();
        }

        public void LoadMoviesByGenre()
        {
            int idGenre = genre.GetIdGenre(comboBoxGenres.SelectedItem.ToString());

            DataSet dataSet = moviesView.LoadMoviesByGenre(idGenre);
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
            labelNumberOfRows.Text = "Number of rows: " + dataGridViewTable.Rows.Count.ToString();
        }
        public void LoadMoviesByGenreAndActor()
        {
            int idGenre = genre.GetIdGenre(comboBoxGenres.SelectedItem.ToString());

            DataSet dataSet = moviesView.LoadMoviesByGenreAndActor(idGenre, comboBoxActors.Text);
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
            labelNumberOfRows.Text = "Number of rows: " + dataGridViewTable.Rows.Count.ToString();
        }

        public void LoadView()
        {            
            labelNumberOfRows.Text = "Number of rows: " + dataGridViewTable.Rows.Count.ToString();
            FillComboBoxActors();
            FillComboBoxGenres();
            FillComboBoxMovies();
        }

        private void FillComboBoxMovies()
        {
            List<string> moviesTitle = movie.SelectMovieTitle();
            comboBoxMovies.DataSource = moviesTitle;
        }

        private void FillComboBoxActors()
        {
            List<string> actorsName = actors.SelectActors();
            comboBoxActors.DataSource = actorsName;
        }

        private void FillComboBoxGenres()
        {
            List<string> genres = genre.SelectGenres();
            comboBoxGenres.DataSource = genres;
        }

        private void buttonDisplayMoviesByActor_Click(object sender, EventArgs e)
        {
            LoadMoviesByActor();
        }

        private void buttonDisplayMoviesByGenre_Click(object sender, EventArgs e)
        {
            LoadMoviesByGenre();
        }

        private void buttonDisplayMoviesByActorAndGenre_Click(object sender, EventArgs e)
        {
            LoadMoviesByGenreAndActor();
        }

        private void buttonDisplayActorsByMovie_Click(object sender, EventArgs e)
        {
            LoadActorsByMovie();
        }

        private void linkLabelLinkImdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(dataGridViewTable.Rows.Count != 0)
            {
                System.Diagnostics.Process.Start(dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[1].Value.ToString());
            }
            else
            {
                MessageBox.Show("You did not select any movie, please, select one!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
