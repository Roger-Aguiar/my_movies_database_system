
namespace MyMoviesApplication.Forms
{
    partial class FormActorsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActorsView));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.linkLabelImdb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of actors";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AllowUserToResizeRows = false;
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTable.Size = new System.Drawing.Size(468, 286);
            this.dataGridViewTable.TabIndex = 1;
            // 
            // linkLabelImdb
            // 
            this.linkLabelImdb.AutoSize = true;
            this.linkLabelImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelImdb.Location = new System.Drawing.Point(12, 62);
            this.linkLabelImdb.Name = "linkLabelImdb";
            this.linkLabelImdb.Size = new System.Drawing.Size(129, 20);
            this.linkLabelImdb.TabIndex = 2;
            this.linkLabelImdb.TabStop = true;
            this.linkLabelImdb.Text = "Visit link at IMDB";
            this.linkLabelImdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelImdb_LinkClicked);
            // 
            // FormActorsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 377);
            this.Controls.Add(this.linkLabelImdb);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormActorsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actors View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.LinkLabel linkLabelImdb;
    }
}