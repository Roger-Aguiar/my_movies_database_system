///Name:         Roger Silva Santos Aguiar
///Function:     It manipulates all the events of the FormMovies
///Initial date: February 6, 2021
///Last update:  February 6, 2021
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

        private List<string> actors = new List<string>();

        public FormMovies()
        {
            InitializeComponent();
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
               
        //**********************************************************************************************************
        //Events

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
            ChangePropertiesOfControlsAfterAdd();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            ChangePropertiesOfControlsAfterSave();
            int idActor;
            int idGenre = genre.GetIdGenre(comboBoxGenres.SelectedText);
            
            foreach(object actorName in actors)
            {
                idActor = GetIdActor(actorName.ToString());
            }
       
        }
               
        private void FormMovies_Shown(object sender, EventArgs e)
        {
            DisplayNumberOfRows();
            Size = new Size(770, 500);
            actors.Clear();
            listViewSelectedActors.Clear();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChangePropertiesOfControlsAfterSave();
        }

        private void ListBoxActors_SelectedIndexChanged(object sender, EventArgs e)
        {            
            actors.Add(listBoxActors.Text);
            //listViewSelectedActors.Items.Add(listBoxActors.Text);
        }

        private void listBoxActors_Click(object sender, EventArgs e)
        {
            listViewSelectedActors.Items.Add(listBoxActors.Text);
        }
                
        private void listBoxActors_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listViewSelectedActors.Items.Add(listBoxActors.Text);
            }
        }
    }
}
