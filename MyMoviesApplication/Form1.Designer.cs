
namespace MyMoviesApplication
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddNewGenre = new System.Windows.Forms.Button();
            this.buttonAddNewMovie = new System.Windows.Forms.Button();
            this.buttonAddNewActor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDisplayGenres = new System.Windows.Forms.Button();
            this.buttonDisplayMovies = new System.Windows.Forms.Button();
            this.buttonDisplayActors = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonAddNewGenre);
            this.panel1.Controls.Add(this.buttonAddNewMovie);
            this.panel1.Controls.Add(this.buttonAddNewActor);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonAddNewGenre
            // 
            resources.ApplyResources(this.buttonAddNewGenre, "buttonAddNewGenre");
            this.buttonAddNewGenre.Name = "buttonAddNewGenre";
            this.buttonAddNewGenre.UseVisualStyleBackColor = true;
            this.buttonAddNewGenre.Click += new System.EventHandler(this.buttonAddNewGenre_Click);
            // 
            // buttonAddNewMovie
            // 
            resources.ApplyResources(this.buttonAddNewMovie, "buttonAddNewMovie");
            this.buttonAddNewMovie.Name = "buttonAddNewMovie";
            this.buttonAddNewMovie.UseVisualStyleBackColor = true;
            this.buttonAddNewMovie.Click += new System.EventHandler(this.buttonAddNewMovie_Click);
            // 
            // buttonAddNewActor
            // 
            resources.ApplyResources(this.buttonAddNewActor, "buttonAddNewActor");
            this.buttonAddNewActor.Name = "buttonAddNewActor";
            this.buttonAddNewActor.UseVisualStyleBackColor = true;
            this.buttonAddNewActor.Click += new System.EventHandler(this.buttonAddNewActor_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonDisplayGenres);
            this.panel2.Controls.Add(this.buttonDisplayMovies);
            this.panel2.Controls.Add(this.buttonDisplayActors);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonDisplayGenres
            // 
            resources.ApplyResources(this.buttonDisplayGenres, "buttonDisplayGenres");
            this.buttonDisplayGenres.Name = "buttonDisplayGenres";
            this.buttonDisplayGenres.UseVisualStyleBackColor = true;
            // 
            // buttonDisplayMovies
            // 
            resources.ApplyResources(this.buttonDisplayMovies, "buttonDisplayMovies");
            this.buttonDisplayMovies.Name = "buttonDisplayMovies";
            this.buttonDisplayMovies.UseVisualStyleBackColor = true;
            this.buttonDisplayMovies.Click += new System.EventHandler(this.buttonDisplayMovies_Click);
            // 
            // buttonDisplayActors
            // 
            resources.ApplyResources(this.buttonDisplayActors, "buttonDisplayActors");
            this.buttonDisplayActors.Name = "buttonDisplayActors";
            this.buttonDisplayActors.UseVisualStyleBackColor = true;
            this.buttonDisplayActors.Click += new System.EventHandler(this.buttonDisplayActors_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonExit);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddNewActor;
        private System.Windows.Forms.Button buttonAddNewGenre;
        private System.Windows.Forms.Button buttonAddNewMovie;
        private System.Windows.Forms.Button buttonDisplayGenres;
        private System.Windows.Forms.Button buttonDisplayMovies;
        private System.Windows.Forms.Button buttonDisplayActors;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
    }
}

