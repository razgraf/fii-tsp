namespace MyPhotosUI
{
    partial class PropertiesManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.propertyLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.propertyIsSearchable = new System.Windows.Forms.CheckBox();
            this.buttonPropertyCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsSearchable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.columnEditable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Property";
            // 
            // propertyLabel
            // 
            this.propertyLabel.Location = new System.Drawing.Point(10, 57);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(168, 20);
            this.propertyLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Searchable";
            // 
            // propertyIsSearchable
            // 
            this.propertyIsSearchable.AutoSize = true;
            this.propertyIsSearchable.Checked = true;
            this.propertyIsSearchable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.propertyIsSearchable.Location = new System.Drawing.Point(199, 60);
            this.propertyIsSearchable.Name = "propertyIsSearchable";
            this.propertyIsSearchable.Size = new System.Drawing.Size(122, 17);
            this.propertyIsSearchable.TabIndex = 4;
            this.propertyIsSearchable.Text = "Can be used as filter";
            this.propertyIsSearchable.UseVisualStyleBackColor = true;
            // 
            // buttonPropertyCreate
            // 
            this.buttonPropertyCreate.BackColor = System.Drawing.Color.Gold;
            this.buttonPropertyCreate.Location = new System.Drawing.Point(370, 41);
            this.buttonPropertyCreate.Name = "buttonPropertyCreate";
            this.buttonPropertyCreate.Size = new System.Drawing.Size(100, 38);
            this.buttonPropertyCreate.TabIndex = 5;
            this.buttonPropertyCreate.Text = "Create";
            this.buttonPropertyCreate.UseVisualStyleBackColor = false;
            this.buttonPropertyCreate.Click += new System.EventHandler(this.buttonPropertyCreate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonPropertyCreate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.propertyIsSearchable);
            this.panel1.Controls.Add(this.propertyLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 7;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnLabel,
            this.columnIsSearchable,
            this.columnEditable});
            this.list.FullRowSelect = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 96);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(484, 281);
            this.list.TabIndex = 8;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseDoubleClick);
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnLabel
            // 
            this.columnLabel.Width = 200;
            // 
            // columnIsSearchable
            // 
            this.columnIsSearchable.Text = "Is Searchable";
            this.columnIsSearchable.Width = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Info: Double click property for options";
            // 
            // columnEditable
            // 
            this.columnEditable.Text = "Is Editable";
            this.columnEditable.Width = 80;
            // 
            // PropertiesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list);
            this.Controls.Add(this.panel1);
            this.Name = "PropertiesManager";
            this.Text = "PropertiesManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropertiesManager_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox propertyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox propertyIsSearchable;
        private System.Windows.Forms.Button buttonPropertyCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnLabel;
        private System.Windows.Forms.ColumnHeader columnIsSearchable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnEditable;
    }
}