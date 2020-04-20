using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using MyPhotos;
using FileIO = System.IO.File;
using File = MyPhotos.File;

namespace MyPhotosUI
{
    public partial class FilePropertiesManager : Form
    {

        /* DbService DbService;*/
        Service.InterfaceWCFClient DbService;
        Dashboard Dashboard = null;
        Guid FileId;
        File File = null;
        List<Data> Datas = new List<Data> { };
        bool Changes = false;


        public FilePropertiesManager(Form dashboard, Guid id)
        {
            InitializeComponent();
            this.DbService = new Service.InterfaceWCFClient();
            this.Dashboard = dashboard as Dashboard;
            this.FileId = id;
            DisplayService_BindList();
        }

        private void FilePropertiesManager_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing...");

            this.Dashboard.Query = "";
            this.Dashboard.DisplayService_BindList();

        }


        private void DataService_Load()
        {
            this.File = DbService.GetFileById(this.FileId);
            this.File.FileDatas = DbService.GetFileDatasByFileId(this.FileId);
            this.Datas = DbService.GetDatas().ToList();
        }

        private void DisplayService_BindList()
        {
            this.DataService_Load();
            this.warning.Text = "";

            if (this.File == null)
            {
                Image image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "../../Asset/nodata_m.png"));
                this.panelPictureBox.Image = image;
            }
            else
            {

                try
                {
                    this.panelPictureBox.Image = new Bitmap(this.File.Path);


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("---");
                    this.warning.Text = "Warning: File renamed or location has changed.";

                    Image image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "../../Asset/nodata_r.png"));
                    this.panelPictureBox.Image = image;
                }

                try
                {
 
                   


                    if (this.File.FileDatas == null) return;
                    this.properties.RowCount = this.File.FileDatas.Count();
                    this.properties.ColumnCount = 1;
                    this.properties.Controls.Clear();

                    this.properties.RowStyles.Clear();

                    foreach (Data d in this.Datas)
                    {
                        Label label = new Label();
                        label.Text = d.Label;

                        TextBox textBox = new TextBox();
                       
                        FileData fileData = this.File.FileDatas.FirstOrDefault(fd => fd.DataId == d.DataId);
                        if (fileData != null) textBox.Text = fileData.Value;
                        if (!d.IsEditable) textBox.Enabled = false;


                        TableLayoutPanel rowLayout = new TableLayoutPanel();
                        rowLayout.ColumnCount = 2;
                        rowLayout.RowCount = 1;

                        rowLayout.Controls.Add(label,0,0);
                        rowLayout.Controls.Add(textBox,1,0);


                     

                        this.properties.Controls.Add(rowLayout);
                        this.properties.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
                        this.properties.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            var controls = this.properties.Controls;
            foreach(TableLayoutPanel row in controls)
            {
                string label = row.Controls[0].Text;
                string value = row.Controls[1].Text;

                DbService.UpdateFileDataByFileIdAndLabel(this.FileId, label, value);
            }

            this.Changes = true;
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to remove this file?";
            const string caption = "File Removal";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DbService.RemoveFileById(this.FileId);
                this.Changes = true;
                this.Dashboard.FileActive = null;
                this.Close();


            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Changes = false;
            this.Close();
        }
    }
}
