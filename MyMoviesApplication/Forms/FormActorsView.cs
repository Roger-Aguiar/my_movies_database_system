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
    public partial class FormActorsView : Form
    {
        private Classes.ActorsView view = new Classes.ActorsView();

        public FormActorsView()
        {
            InitializeComponent();
            LoadView();
        }

        public void LoadView()
        {
            DataSet dataSet = view.LoadActorsView();
            dataGridViewTable.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void linkLabelImdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            System.Diagnostics.Process.Start(dataGridViewTable.Rows[dataGridViewTable.CurrentRow.Index].Cells[2].Value.ToString());
        }
    }
}
