///Name:         Roger Silva Santos Aguiar
///Function:     Methods and events of the Actors form 
///Initial date: February 3, 2021
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
    public partial class FormActors : Form
    {        
        private readonly Classes.Actors actors = new Classes.Actors();
       
        //*********************************************************************************************************
        //Private methods
        private void ClearControls()
        {
            textBoxActorId.Clear();
            textBoxActor.Clear();
            textBoxCredits.Clear();
            textBoxLinkImdb.Clear();
            textBoxActor.Focus();
        }

        private void LoadActorsTable()
        {
            DataSet dataSet = actors.LoadActorsTable();
            dataGridViewActors.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void LinkDataGridViewToFields()
        {
            if(dataGridViewActors.Rows.Count > 0)
            {
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewActors.CurrentRow.Index + 1) + " } of " + dataGridViewActors.Rows.Count;

                textBoxActorId.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[0].Value.ToString();
                textBoxActor.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[1].Value.ToString();
                textBoxCredits.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[2].Value.ToString();
                textBoxLinkImdb.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[3].Value.ToString();
                dateTimePickerRegisterDate.Value = Convert.ToDateTime(dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[4].Value.ToString());
                dateTimePickerLastUpdate.Value = Convert.ToDateTime(dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[5].Value.ToString());
            }                                   
        }

        //**************************************************************************************************************
        //Events

        public FormActors()
        {
            InitializeComponent();
            LoadActorsTable();           
        }
                       
        private void DataGridViewActors_SelectionChanged(object sender, EventArgs e)
        {
            LinkDataGridViewToFields();
        }                

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            ClearControls();
            toolStripButtonAdd.Enabled = false;
            toolStripButtonUpdate.Enabled = false;
            toolStripButtonDelete.Enabled = false;
            toolStripButtonSave.Enabled = true;
            dateTimePickerRegisterDate.Value = DateTime.Now;
            dateTimePickerLastUpdate.Value = DateTime.Now;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            string actorName = actors.SelectActorName(textBoxActor.Text);
            
            if(actorName != textBoxActor.Text.ToLower())
            {
                actors.InsertRow(textBoxActor.Text, Convert.ToInt32(textBoxCredits.Text), textBoxLinkImdb.Text, dateTimePickerRegisterDate.Value, dateTimePickerRegisterDate.Value);
                LoadActorsTable();
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewActors.CurrentRow.Index + 1) + " } of " + dataGridViewActors.Rows.Count;
                toolStripButtonAdd.Enabled = true;
                toolStripButtonUpdate.Enabled = true;
                toolStripButtonDelete.Enabled = true;
                toolStripButtonSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("You have already registered this actor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadActorsTable();
            }            
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Are you sure that you want to delete this row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(question == DialogResult.Yes)
            {
                actors.DeleteRow(Convert.ToInt32(textBoxActorId.Text));
                MessageBox.Show("Operation has been completed!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadActorsTable();
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewActors.CurrentRow.Index + 1) + 
                                                        " } of " + dataGridViewActors.Rows.Count;
            }           
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            actors.Update(Convert.ToInt32(textBoxActorId.Text), textBoxActor.Text, Convert.ToInt32(textBoxCredits.Text), textBoxLinkImdb.Text, dateTimePickerRegisterDate.Value, dateTimePickerLastUpdate.Value);
            LoadActorsTable();
            toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewActors.CurrentRow.Index + 1) + " } of " + dataGridViewActors.Rows.Count;
        }
               
        private void FormActors_Shown(object sender, EventArgs e)
        {
            if (dataGridViewActors.Rows.Count > 0)
            {
                toolStripLabelRowsIdentification.Text = "{ " + Convert.ToInt32(dataGridViewActors.CurrentRow.Index + 1) + " } of " + dataGridViewActors.Rows.Count;
            }
            else
            {
                toolStripLabelRowsIdentification.Text = "{ 0 } of 0";
            }            
        }
    }
}
