namespace MyPhotosUI
{
    partial class Dashboard
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
            this.panelPictureBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.properties = new System.Windows.Forms.ListView();
            this.columnProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.top = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureBox)).BeginInit();
            this.panel.SuspendLayout();
            this.flow.SuspendLayout();
            this.top.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPictureBox.InitialImage = null;
            this.panelPictureBox.Location = new System.Drawing.Point(4, 3);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(244, 153);
            this.panelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.panelPictureBox.TabIndex = 0;
            this.panelPictureBox.TabStop = false;
            this.panelPictureBox.WaitOnLoad = true;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.buttonRemove);
            this.panel.Controls.Add(this.buttonEdit);
            this.panel.Controls.Add(this.properties);
            this.panel.Controls.Add(this.panelPictureBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(629, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(255, 421);
            this.panel.TabIndex = 1;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(178, 162);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 39);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemoveImage_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.White;
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(4, 162);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(168, 39);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit Properties";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // properties
            // 
            this.properties.BackColor = System.Drawing.Color.WhiteSmoke;
            this.properties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProperty,
            this.columnValue});
            this.properties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.properties.HideSelection = false;
            this.properties.Location = new System.Drawing.Point(4, 206);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(244, 201);
            this.properties.TabIndex = 1;
            this.properties.UseCompatibleStateImageBehavior = false;
            this.properties.View = System.Windows.Forms.View.Details;
            // 
            // columnProperty
            // 
            this.columnProperty.Text = "Property";
            this.columnProperty.Width = 100;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Value";
            this.columnValue.Width = 140;
            // 
            // flow
            // 
            this.flow.AutoSize = true;
            this.flow.BackColor = System.Drawing.Color.White;
            this.flow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow.Controls.Add(this.top);
            this.flow.Controls.Add(this.list);
            this.flow.Controls.Add(this.warning);
            this.flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow.Location = new System.Drawing.Point(0, 0);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(629, 421);
            this.flow.TabIndex = 2;
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.WhiteSmoke;
            this.top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.top.Controls.Add(this.flowLayoutPanel2);
            this.top.Controls.Add(this.flowLayoutPanel1);
            this.top.Location = new System.Drawing.Point(3, 3);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(618, 90);
            this.top.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.searchBox);
            this.flowLayoutPanel2.Controls.Add(this.buttonSearch);
            this.flowLayoutPanel2.Controls.Add(this.buttonFilter);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(465, 84);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(454, 29);
            this.searchBox.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(3, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 39);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFilter.ForeColor = System.Drawing.Color.White;
            this.buttonFilter.Location = new System.Drawing.Point(134, 38);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(125, 39);
            this.buttonFilter.TabIndex = 3;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(265, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Manage Properties";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonManageProperties_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonVideo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(474, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(135, 84);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Gold;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 74);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "📸";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.Color.Orange;
            this.buttonVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVideo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVideo.Location = new System.Drawing.Point(70, 3);
            this.buttonVideo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(65, 74);
            this.buttonVideo.TabIndex = 2;
            this.buttonVideo.Text = "🎥";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonAddVideo_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(3, 99);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(618, 270);
            this.list.TabIndex = 1;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_MouseClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 200;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 300;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(3, 372);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 13);
            this.warning.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 421);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.panel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelPictureBox)).EndInit();
            this.panel.ResumeLayout(false);
            this.flow.ResumeLayout(false);
            this.flow.PerformLayout();
            this.top.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox panelPictureBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private System.Windows.Forms.FlowLayoutPanel top;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        protected System.Windows.Forms.ListView list;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView properties;
        private System.Windows.Forms.ColumnHeader columnProperty;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label warning;
    }
}

