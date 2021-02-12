///Name:         Roger Silva Santos Aguiar
///Function:     This is the menu form, it has the buttons to open the other forms.
///Initial date: February 11, 2021
///Last update:  February 11, 2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoviesApplication
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddNewActor_Click(object sender, EventArgs e)
        {
            var actors = new Forms.FormActors();
            actors.Show();
        }

        private void buttonAddNewMovie_Click(object sender, EventArgs e)
        {
            var movies = new Forms.FormMovies();
            movies.Show();
        }

        private void buttonAddNewGenre_Click(object sender, EventArgs e)
        {
            var genres = new Forms.FormGenres();
            genres.Show();
        }

        private void buttonDisplayActors_Click(object sender, EventArgs e)
        {
            var actorsView = new Forms.FormActorsView();
            actorsView.Show();
        }

        private void buttonDisplayMovies_Click(object sender, EventArgs e)
        {
            var moviesView = new Forms.FormMoviesView();
            moviesView.Show();
        }
    }
}
