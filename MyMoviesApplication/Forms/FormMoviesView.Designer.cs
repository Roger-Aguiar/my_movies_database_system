
namespace MyMoviesApplication.Forms
{
    partial class FormMoviesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMoviesView));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDisplayMoviesByGenre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxActors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberOfRows = new System.Windows.Forms.Label();
            this.buttonDisplayMoviesByActor = new System.Windows.Forms.Button();
            this.buttonDisplayMoviesByActorAndGenre = new System.Windows.Forms.Button();
            this.buttonDisplayActorsByMovie = new System.Windows.Forms.Button();
            this.comboBoxMovies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelLinkImdb = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of movies";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(12, 321);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTable.Size = new System.Drawing.Size(571, 265);
            this.dataGridViewTable.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDisplayMoviesByActorAndGenre);
            this.panel1.Controls.Add(this.buttonDisplayMoviesByGenre);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.labelNumberOfRows);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 239);
            this.panel1.TabIndex = 3;
            // 
            // buttonDisplayMoviesByGenre
            // 
            this.buttonDisplayMoviesByGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayMoviesByGenre.Location = new System.Drawing.Point(378, 100);
            this.buttonDisplayMoviesByGenre.Name = "buttonDisplayMoviesByGenre";
            this.buttonDisplayMoviesByGenre.Size = new System.Drawing.Size(171, 30);
            this.buttonDisplayMoviesByGenre.TabIndex = 3;
            this.buttonDisplayMoviesByGenre.Text = "Click here to display";
            this.buttonDisplayMoviesByGenre.UseVisualStyleBackColor = true;
            this.buttonDisplayMoviesByGenre.Click += new System.EventHandler(this.buttonDisplayMoviesByGenre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisplayActorsByMovie);
            this.groupBox1.Controls.Add(this.comboBoxMovies);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxGenres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxActors);
            this.groupBox1.Controls.Add(this.buttonDisplayMoviesByActor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(137, 59);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(229, 28);
            this.comboBoxGenres.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select a genre:";
            // 
            // comboBoxActors
            // 
            this.comboBoxActors.FormattingEnabled = true;
            this.comboBoxActors.Location = new System.Drawing.Point(137, 25);
            this.comboBoxActors.Name = "comboBoxActors";
            this.comboBoxActors.Size = new System.Drawing.Size(229, 28);
            this.comboBoxActors.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select an actor:";
            // 
            // labelNumberOfRows
            // 
            this.labelNumberOfRows.AutoSize = true;
            this.labelNumberOfRows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNumberOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfRows.Location = new System.Drawing.Point(3, 10);
            this.labelNumberOfRows.Name = "labelNumberOfRows";
            this.labelNumberOfRows.Size = new System.Drawing.Size(2, 22);
            this.labelNumberOfRows.TabIndex = 0;
            // 
            // buttonDisplayMoviesByActor
            // 
            this.buttonDisplayMoviesByActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayMoviesByActor.Location = new System.Drawing.Point(372, 23);
            this.buttonDisplayMoviesByActor.Name = "buttonDisplayMoviesByActor";
            this.buttonDisplayMoviesByActor.Size = new System.Drawing.Size(171, 30);
            this.buttonDisplayMoviesByActor.TabIndex = 2;
            this.buttonDisplayMoviesByActor.Text = "Click here to display";
            this.buttonDisplayMoviesByActor.UseVisualStyleBackColor = true;
            this.buttonDisplayMoviesByActor.Click += new System.EventHandler(this.buttonDisplayMoviesByActor_Click);
            // 
            // buttonDisplayMoviesByActorAndGenre
            // 
            this.buttonDisplayMoviesByActorAndGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayMoviesByActorAndGenre.Location = new System.Drawing.Point(6, 189);
            this.buttonDisplayMoviesByActorAndGenre.Name = "buttonDisplayMoviesByActorAndGenre";
            this.buttonDisplayMoviesByActorAndGenre.Size = new System.Drawing.Size(549, 38);
            this.buttonDisplayMoviesByActorAndGenre.TabIndex = 5;
            this.buttonDisplayMoviesByActorAndGenre.Text = "Display movies by actor and genre";
            this.buttonDisplayMoviesByActorAndGenre.UseVisualStyleBackColor = true;
            this.buttonDisplayMoviesByActorAndGenre.Click += new System.EventHandler(this.buttonDisplayMoviesByActorAndGenre_Click);
            // 
            // buttonDisplayActorsByMovie
            // 
            this.buttonDisplayActorsByMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayActorsByMovie.Location = new System.Drawing.Point(372, 93);
            this.buttonDisplayActorsByMovie.Name = "buttonDisplayActorsByMovie";
            this.buttonDisplayActorsByMovie.Size = new System.Drawing.Size(171, 30);
            this.buttonDisplayActorsByMovie.TabIndex = 5;
            this.buttonDisplayActorsByMovie.Text = "Click here to display";
            this.buttonDisplayActorsByMovie.UseVisualStyleBackColor = true;
            this.buttonDisplayActorsByMovie.Click += new System.EventHandler(this.buttonDisplayActorsByMovie_Click);
            // 
            // comboBoxMovies
            // 
            this.comboBoxMovies.FormattingEnabled = true;
            this.comboBoxMovies.Location = new System.Drawing.Point(137, 93);
            this.comboBoxMovies.Name = "comboBoxMovies";
            this.comboBoxMovies.Size = new System.Drawing.Size(229, 28);
            this.comboBoxMovies.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select a movie:";
            // 
            // linkLabelLinkImdb
            // 
            this.linkLabelLinkImdb.AutoSize = true;
            this.linkLabelLinkImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLinkImdb.Location = new System.Drawing.Point(16, 298);
            this.linkLabelLinkImdb.Name = "linkLabelLinkImdb";
            this.linkLabelLinkImdb.Size = new System.Drawing.Size(129, 20);
            this.linkLabelLinkImdb.TabIndex = 6;
            this.linkLabelLinkImdb.TabStop = true;
            this.linkLabelLinkImdb.Text = "Visit link at IMDB";
            this.linkLabelLinkImdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLinkImdb_LinkClicked);
            // 
            // FormMoviesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 598);
            this.Controls.Add(this.linkLabelLinkImdb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMoviesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumberOfRows;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxActors;
        private System.Windows.Forms.Button buttonDisplayMoviesByActor;
        private System.Windows.Forms.Button buttonDisplayMoviesByGenre;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDisplayMoviesByActorAndGenre;
        private System.Windows.Forms.Button buttonDisplayActorsByMovie;
        private System.Windows.Forms.ComboBox comboBoxMovies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelLinkImdb;
    }
}