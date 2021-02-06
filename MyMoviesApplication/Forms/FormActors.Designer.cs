
namespace MyMoviesApplication.Forms
{
    partial class FormActors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActors));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxActor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCredits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLinkImdb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewActors = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabelRowsIdentification = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTimePickerLastUpdate);
            this.panel1.Controls.Add(this.dateTimePickerRegisterDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxActor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCredits);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxLinkImdb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxActorId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 174);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(395, 134);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(160, 26);
            this.dateTimePickerLastUpdate.TabIndex = 4;
            // 
            // dateTimePickerRegisterDate
            // 
            this.dateTimePickerRegisterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRegisterDate.Location = new System.Drawing.Point(121, 134);
            this.dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            this.dateTimePickerRegisterDate.Size = new System.Drawing.Size(160, 26);
            this.dateTimePickerRegisterDate.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Update:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Register Date:";
            // 
            // textBoxActor
            // 
            this.textBoxActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActor.Location = new System.Drawing.Point(121, 38);
            this.textBoxActor.Name = "textBoxActor";
            this.textBoxActor.Size = new System.Drawing.Size(434, 26);
            this.textBoxActor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Actor:";
            // 
            // textBoxCredits
            // 
            this.textBoxCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredits.Location = new System.Drawing.Point(121, 70);
            this.textBoxCredits.Name = "textBoxCredits";
            this.textBoxCredits.Size = new System.Drawing.Size(434, 26);
            this.textBoxCredits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credits:";
            // 
            // textBoxLinkImdb
            // 
            this.textBoxLinkImdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLinkImdb.Location = new System.Drawing.Point(121, 102);
            this.textBoxLinkImdb.Name = "textBoxLinkImdb";
            this.textBoxLinkImdb.Size = new System.Drawing.Size(434, 26);
            this.textBoxLinkImdb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Link IMDB:";
            // 
            // textBoxActorId
            // 
            this.textBoxActorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxActorId.Location = new System.Drawing.Point(121, 6);
            this.textBoxActorId.Name = "textBoxActorId";
            this.textBoxActorId.ReadOnly = true;
            this.textBoxActorId.Size = new System.Drawing.Size(100, 26);
            this.textBoxActorId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actor ID:";
            // 
            // dataGridViewActors
            // 
            this.dataGridViewActors.AllowUserToAddRows = false;
            this.dataGridViewActors.AllowUserToDeleteRows = false;
            this.dataGridViewActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActors.Location = new System.Drawing.Point(12, 208);
            this.dataGridViewActors.Name = "dataGridViewActors";
            this.dataGridViewActors.ReadOnly = true;
            this.dataGridViewActors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActors.Size = new System.Drawing.Size(562, 230);
            this.dataGridViewActors.TabIndex = 5;
            this.dataGridViewActors.SelectionChanged += new System.EventHandler(this.DataGridViewActors_SelectionChanged);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigator.Size = new System.Drawing.Size(586, 25);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabelRowsIdentification
            // 
            this.toolStripLabelRowsIdentification.Name = "toolStripLabelRowsIdentification";
            this.toolStripLabelRowsIdentification.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabelRowsIdentification.Text = "toolStripLabel1";
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
            // FormActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.dataGridViewActors);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormActors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actors";
            this.Shown += new System.EventHandler(this.FormActors_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxActorId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCredits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLinkImdb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegisterDate;
        private System.Windows.Forms.DataGridView dataGridViewActors;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRowsIdentification;
    }
}