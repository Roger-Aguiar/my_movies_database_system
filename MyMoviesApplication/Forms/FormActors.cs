///Name:         Roger Silva Santos Aguiar
///Function:     Methods and events of the Actors form 
///Initial date: February 3, 2021
///Last update:  February 5, 2021
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
            textBoxActorId.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxActor.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxCredits.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxLinkImdb.Text = dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[3].Value.ToString();
            dateTimePickerRegisterDate.Value = Convert.ToDateTime(dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[4].Value.ToString());
            dateTimePickerLastUpdate.Value = Convert.ToDateTime(dataGridViewActors.Rows[dataGridViewActors.CurrentRow.Index].Cells[5].Value.ToString());
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
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            actors.InsertRow(textBoxActor.Text, Convert.ToInt32(textBoxCredits.Text), textBoxLinkImdb.Text, dateTimePickerRegisterDate.Value, dateTimePickerRegisterDate.Value);
            LoadActorsTable();            
        }

        private void toolStripButtonRow_Click(object sender, EventArgs e)
        {
            actors.DeleteRow(Convert.ToInt32(textBoxActorId.Text));
            LoadActorsTable();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            actors.Update(Convert.ToInt32(textBoxActorId.Text), textBoxActor.Text, Convert.ToInt32(textBoxCredits.Text), textBoxLinkImdb.Text, dateTimePickerRegisterDate.Value, dateTimePickerLastUpdate.Value);
            LoadActorsTable();
        }
    }
}
