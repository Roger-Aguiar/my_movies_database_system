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
    public partial class FormMovies : Form
    {
        public FormMovies()
        {
            InitializeComponent();
        }

        private void FormMovies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_moviesDataSet11.genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.my_moviesDataSet11.genres);
            // TODO: This line of code loads data into the 'my_moviesDataSet.actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.my_moviesDataSet.actors);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actorsTableAdapter.FillBy(this.my_moviesDataSet.actors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actorsTableAdapter.FillBy1(this.my_moviesDataSet.actors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void selectActorsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actorsTableAdapter.SelectActors(this.my_moviesDataSet.actors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void getActorsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.actorsTableAdapter.GetActors(this.my_moviesDataSet.actors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            labelActors.Visible = true;
            listBoxActors.Visible = true;
            buttonCancel.Visible = true;
            toolStripButtonAdd.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonUpdate.Enabled = false;
            toolStripButtonSave.Enabled = true;                       
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            labelActors.Visible = false;
            listBoxActors.Visible = false;
            buttonCancel.Visible = false;
            toolStripButtonAdd.Enabled = true;
            toolStripButtonDelete.Enabled = true;
            toolStripButtonUpdate.Enabled = true;
            toolStripButtonSave.Enabled = false;
        }

        private void buttonAddGenres_Click(object sender, EventArgs e)
        {
            
        }
    }
}
