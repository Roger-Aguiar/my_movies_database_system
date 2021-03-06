﻿
namespace MyMoviesApplication.Forms
{
    partial class FormMovies
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovies));
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabelRowsIdentification = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLinkImdb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewSelectedActors = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.labelActors = new System.Windows.Forms.Label();
            this.listBoxActors = new System.Windows.Forms.ListBox();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelRowsIdentification,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonAdd,
            this.toolStripButtonSave,
            this.toolStripButtonDelete,
            this.toolStripButtonUpdate});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator.Size = new System.Drawing.Size(944, 25);
            this.bindingNavigator.TabIndex = 2;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabelRowsIdentification
            // 
            this.toolStripLabelRowsIdentification.Name = "toolStripLabelRowsIdentification";
            this.toolStripLabelRowsIdentification.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabelRowsIdentification.Text = "toolStripLabel1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "Add new";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Register";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Delete row";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "Update row";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxLinkImdb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listViewSelectedActors);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxGenres);
            this.panel1.Controls.Add(this.labelActors);
            this.panel1.Controls.Add(this.listBoxActors);
            this.panel1.Controls.Add(this.dateTimePickerLastUpdate);
            this.panel1.Controls.Add(this.dateTimePickerRegisterDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxOriginalTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 237);
            this.panel1.TabIndex = 3;
            // 
            // textBoxLinkImdb
            // 
            this.textBoxLinkImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkImdb.Location = new System.Drawing.Point(112, 131);
            this.textBoxLinkImdb.Name = "textBoxLinkImdb";
            this.textBoxLinkImdb.Size = new System.Drawing.Size(313, 26);
            this.textBoxLinkImdb.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Link IMDB:";
            // 
            // listViewSelectedActors
            // 
            this.listViewSelectedActors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectedActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSelectedActors.FullRowSelect = true;
            this.listViewSelectedActors.HideSelection = false;
            this.listViewSelectedActors.HoverSelection = true;
            this.listViewSelectedActors.Location = new System.Drawing.Point(736, 36);
            this.listViewSelectedActors.Name = "listViewSelectedActors";
            this.listViewSelectedActors.Size = new System.Drawing.Size(173, 183);
            this.listViewSelectedActors.TabIndex = 19;
            this.listViewSelectedActors.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedActors.View = System.Windows.Forms.View.List;
            this.listViewSelectedActors.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Genre:";
            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.DisplayMember = "idGenre";
            this.comboBoxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(112, 163);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(313, 28);
            this.comboBoxGenres.TabIndex = 4;
            this.comboBoxGenres.ValueMember = "idGenre";
            // 
            // labelActors
            // 
            this.labelActors.AutoSize = true;
            this.labelActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActors.Location = new System.Drawing.Point(427, 6);
            this.labelActors.Name = "labelActors";
            this.labelActors.Size = new System.Drawing.Size(139, 20);
            this.labelActors.TabIndex = 16;
            this.labelActors.Text = "Select the actor(s)";
            this.labelActors.Visible = false;
            // 
            // listBoxActors
            // 
            this.listBoxActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxActors.FormattingEnabled = true;
            this.listBoxActors.ItemHeight = 20;
            this.listBoxActors.Location = new System.Drawing.Point(431, 35);
            this.listBoxActors.Name = "listBoxActors";
            this.listBoxActors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxActors.Size = new System.Drawing.Size(297, 184);
            this.listBoxActors.Sorted = true;
            this.listBoxActors.TabIndex = 7;
            this.listBoxActors.Visible = false;
            this.listBoxActors.Click += new System.EventHandler(this.listBoxActors_Click);
            this.listBoxActors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxActors_KeyDown);
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(325, 197);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerLastUpdate.TabIndex = 6;
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(112, 197);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerRegisterDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Update:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Register Date:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(112, 99);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 26);
            this.textBoxYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // textBoxOriginalTitle
            // 
            this.textBoxOriginalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOriginalTitle.Location = new System.Drawing.Point(112, 67);
            this.textBoxOriginalTitle.Name = "textBoxOriginalTitle";
            this.textBoxOriginalTitle.Size = new System.Drawing.Size(313, 26);
            this.textBoxOriginalTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Original title:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(112, 35);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(313, 26);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(112, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 26);
            this.textBoxId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id movie:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(235, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 24);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(11, 274);
            this.dataGridViewTable.MultiSelect = false;
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTable.Size = new System.Drawing.Size(921, 177);
            this.dataGridViewTable.TabIndex = 9;
            this.dataGridViewTable.SelectionChanged += new System.EventHandler(this.dataGridViewTable_SelectionChanged);
            // 
            // FormMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Shown += new System.EventHandler(this.FormMovies_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRowsIdentification;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOriginalTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxActors;
        private System.Windows.Forms.Label labelActors;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGenres;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.ListView listViewSelectedActors;
        private System.Windows.Forms.TextBox textBoxLinkImdb;
        private System.Windows.Forms.Label label8;
    }
}