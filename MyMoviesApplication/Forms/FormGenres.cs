///Name:         Roger Silva Santos Aguiar
///Function:     Events of the FormGenres
///Initial date: February 10, 2021
///Last update:  February 10, 2021
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
    public partial class FormGenres : Form
    {
        private Classes.Genres genre = new Classes.Genres();

        public FormGenres()
        {
            InitializeComponent();
            LoadGenresTable();
        }

        //********************************************************************************************************
        //Private methods
                
        private void LoadGenresTable()
        {
            DataSet dataSet = genre.LoadTable();
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;            
        }

        private void LinkDataGridViewToFields()
        {
            if (dataGridViewTable.Rows.Count > 0)
            {
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewTable.CurrentRow.Index + 1) + " } of " + dataGridViewTable.Rows.Count;

                textBoxIdGenre.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[0].Value.ToString();
                textBoxGenre.Text = dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[1].Value.ToString();                
                dateTimePickerRegisterDate.Value = Convert.ToDateTime(dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[2].Value.ToString());                
            }
            else
            {
                toolStripLabelRowsIdentification.Text = "{ 0 } of 0";
            }
        }

        private void ClearControls()
        {
            textBoxIdGenre.Clear();
            textBoxGenre.Clear();
            dateTimePickerRegisterDate.Value = DateTime.Now;
            textBoxGenre.Focus();
        }

        private void ChangeStateButtonsBeforeSave()
        {
            toolStripButtonAdd.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonUpdate.Enabled = false;
            toolStripButtonSave.Enabled = true;           
        }

        private void ChangeStateButtonsAfterSave()
        {
            toolStripButtonAdd.Enabled = true;
            toolStripButtonDelete.Enabled = true;
            toolStripButtonUpdate.Enabled = true;
            toolStripButtonSave.Enabled = false;
        }

        //*********************************************************************************************************
        //Events

        private void FormGenres_Shown(object sender, EventArgs e)
        {                  
            LinkDataGridViewToFields();
        }

        private void dataGridViewTable_SelectionChanged(object sender, EventArgs e)
        {
            LinkDataGridViewToFields();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            ChangeStateButtonsBeforeSave();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            string lowerGenre = genre.SelectGenreToLower(textBoxGenre.Text);

            if (lowerGenre != textBoxGenre.Text.ToLower())
            {
                genre.Insert(textBoxGenre.Text, dateTimePickerRegisterDate.Value);
                ChangeStateButtonsAfterSave();
                LoadGenresTable();
                LinkDataGridViewToFields();
            }
            else
            {
                MessageBox.Show("You have already registered this genre!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStateButtonsAfterSave();
                LoadGenresTable();
                LinkDataGridViewToFields();
            }            
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Are you sure that you want to delete this row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(question == DialogResult.Yes)
            {
                genre.Delete(Convert.ToInt32(textBoxIdGenre.Text));
                LoadGenresTable();
                LinkDataGridViewToFields();
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            genre.Update(Convert.ToInt32(textBoxIdGenre.Text), textBoxGenre.Text, dateTimePickerRegisterDate.Value);
            LoadGenresTable();
            LinkDataGridViewToFields();
        }
    }
}
