///Name:         Roger Silva Santos Aguiar
///Function:     It manipulates all the events of the FormMovies
///Initial date: February 6, 2021
///Last update:  February 9, 2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMoviesApplication.Forms.Classes;

namespace MyMoviesApplication.Forms
{
    public partial class FormMovies : Form
    {
        private readonly Classes.Genres genre = new Genres();
        private readonly Classes.Actors actor = new Actors();
        private readonly Classes.Movies movie = new Movies();
        private readonly Classes.ActorsHasMovies actors_has_movies = new ActorsHasMovies();

        private List<string> actors = new List<string>();

        public FormMovies()
        {
            InitializeComponent();
            LoadMoviesTable();
        }

        private void ChangePropertiesOfControlsAfterAdd()
        {
            Size = new Size(960, 500);
            listViewSelectedActors.Visible = true;            
            labelActors.Visible = true;
            listBoxActors.Visible = true;
            buttonCancel.Visible = true;
            toolStripButtonAdd.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonUpdate.Enabled = false;
            toolStripButtonSave.Enabled = true;
            dateTimePickerRegisterDate.Value = DateTime.Now;
            dateTimePickerLastUpdate.Value = DateTime.Now;
            textBoxId.Clear();
            textBoxTitle.Clear();
            textBoxOriginalTitle.Clear();
            textBoxLinkImdb.Clear();
            textBoxYear.Clear();
            
            textBoxTitle.Focus();
        }

        private void ChangePropertiesOfControlsAfterSave()
        {
            Size = new Size(770, 500);
            listViewSelectedActors.Visible = false;
            listViewSelectedActors.Clear();
            labelActors.Visible = false;
            listBoxActors.Visible = false;
            buttonCancel.Visible = false;
            toolStripButtonAdd.Enabled = true;
            toolStripButtonDelete.Enabled = true;
            toolStripButtonUpdate.Enabled = true;
            toolStripButtonSave.Enabled = false;
        }

        private void DisplayNumberOfRows()
        {
            if (dataGridViewTable.Rows.Count > 0)
            {
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewTable.CurrentRow.Index + 1) + " } of " + dataGridViewTable.Rows.Count;
            }
            else
            {
                toolStripLabelRowsIdentification.Text = "{ 0 } of 0";
            }
        }

        private int GetIdActor(string actorName)
        {
            int idActor = actor.SelectIdActor(actorName);
            return idActor;
        }

        private void LoadMoviesTable()
        {
            DataSet dataSet = movie.LoadTable();
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void LinkDataGridViewToFields()
        {
            if (dataGridViewTable.Rows.Count > 0)
            {
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewTable.CurrentRow.Index + 1) + " } of " + dataGridViewTable.Rows.Count;

                textBoxId.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[0].Value.ToString();
                textBoxTitle.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[1].Value.ToString();
                textBoxOriginalTitle.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[2].Value.ToString();
                textBoxYear.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[3].Value.ToString();
                textBoxLinkImdb.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[4].Value.ToString();

                int idGenre = movie.SelectIdGenre(textBoxTitle.Text);
                comboBoxGenres.Text = genre.GetGenre(idGenre);

                dateTimePickerRegisterDate.Value = Convert.ToDateTime(dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[5].Value.ToString());
                dateTimePickerLastUpdate.Value = Convert.ToDateTime(dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[6].Value.ToString());
            }
        }

        private void FillListBox()
        {
            List<string> actorsName = actor.SelectActors();
            listBoxActors.DataSource = actorsName;
        }

        private void FillComboBoxGenres()
        {
            List<string> genres = genre.SelectGenres();
            comboBoxGenres.DataSource = genres;
        }
        //**********************************************************************************************************
        //Events
               
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            ChangePropertiesOfControlsAfterAdd();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {    
            if(actors.Count == 0)
            {
                MessageBox.Show("You did not select the actor(s)! Please, select the one(s) from the list box before saving!", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idGenre = genre.GetIdGenre(comboBoxGenres.SelectedItem.ToString());

                movie.Insert(textBoxTitle.Text, textBoxOriginalTitle.Text, textBoxYear.Text, textBoxLinkImdb.Text, dateTimePickerRegisterDate.Value, dateTimePickerLastUpdate.Value, (idGenre));

                int idMovie = movie.SelectIdMovie(textBoxTitle.Text);

                foreach (object actorName in actors)
                {
                    int idActor = GetIdActor(actorName.ToString());
                    actors_has_movies.Insert(idActor, idMovie);
                }

                MessageBox.Show("Operation has been completed!", "Information",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChangePropertiesOfControlsAfterSave();
                LoadMoviesTable();
                actors.Clear();
            }            
        }
               
        private void FormMovies_Shown(object sender, EventArgs e)
        {           
            FillListBox();
            FillComboBoxGenres();
            Size = new Size(770, 500);
            DisplayNumberOfRows();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChangePropertiesOfControlsAfterSave();
        }
                
        private void listBoxActors_Click(object sender, EventArgs e)
        {
            listViewSelectedActors.Items.Add(listBoxActors.Text);
            actors.Add(listBoxActors.Text);
        }
                
        private void listBoxActors_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listViewSelectedActors.Items.Add(listBoxActors.Text);
                actors.Add(listBoxActors.Text);
            }
        }

        private void dataGridViewTable_SelectionChanged(object sender, EventArgs e)
        {
            LinkDataGridViewToFields();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Are you sure that you want to delete this row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                actors_has_movies.Delete(Convert.ToInt32(textBoxId.Text));
                movie.Delete(Convert.ToInt32(textBoxId.Text));
                MessageBox.Show("Operation has been completed!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadMoviesTable();
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewTable.CurrentRow.Index + 1) +
                                                        " } of " + dataGridViewTable.Rows.Count;
            }
        }
    }
}
