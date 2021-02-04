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
        private readonly Classes.DatabaseService execute_command = new Classes.DatabaseService();

        public FormActors()
        {
            InitializeComponent();
            LoadActorsTable();
        }
                       
        private void DataGridViewActors_SelectionChanged(object sender, EventArgs e)
        {
            LinkDataGridViewToFields();
        }

        //*********************************************************************************************************
        //Methods

        private void LoadActorsTable()
        {
            string sql_query = "SELECT * FROM actors";
            DataSet dataSet = execute_command.LoadData(sql_query);
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
    }
}
