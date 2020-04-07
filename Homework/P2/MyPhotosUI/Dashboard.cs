using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MyPhotos;
using FileIO = System.IO.File;
using File = MyPhotos.File;

namespace MyPhotosUI
{
    public partial class Dashboard : Form
    {
        /*DbService DbService;*/
        Service.InterfaceWCFClient DbService;

        List<File> Files = new List<File> { };
        List<Data> Datas = new List<Data> { };
        public File FileActive { get; set; } = null;

        public string Query = "";

        public Dashboard()
        {

            InitializeComponent();
            this.DbService = new Service.InterfaceWCFClient(); 
       /*     this.DbService = new DbService();*/

            this.panel.Padding = new System.Windows.Forms.Padding(5);
            this.flow.Padding = new System.Windows.Forms.Padding(5);

            DisplayService_BindList();
            DisplayService_BindPanel();

            this.buttonFilter.Enabled = false;
            this.buttonFilter.BackColor = Color.Gainsboro;
            this.buttonVideo.Enabled = false;
            this.buttonVideo.BackColor = Color.Gainsboro;

            /*this.DbService.InitDb();*/

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void DataService_Load()
        {
            if (this.Query == null || this.Query.Length == 0)
                this.Files = DbService.GetFiles().ToList();
            else this.Files = DbService.GetFilteredFiles(f => f.Name.Contains(this.Query)).ToList();
            this.Datas = DbService.GetDatas().ToList();
        }



        private void list_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.list.Items != null)
            {
                for (int i = 0; i < this.list.Items.Count; i++)
                {
                    ListViewItem item = this.list.Items[i];
                    if (item.Bounds.Contains(e.Location))
                    {
                        this.FileActive = Files[i];
                        DisplayService_BindPanel();

                    }
                }
            }

        }

        public void DisplayService_BindPanel()
        {
            this.properties.Items.Clear();

            this.warning.Text = "";

            if (this.FileActive == null)
            {
                Image image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"../../Asset/nodata_m.png"));
                this.panelPictureBox.Image = image;
            }
            else
            {
                try
                {
                    List<FileData> fileDatas = DbService.GetFileDatasByFileId(this.FileActive.FileId).ToList();
                    this.panelPictureBox.Image = new Bitmap(this.FileActive.Path);


                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    this.warning.Text = "Warning: File renamed or location has changed.";

                    Image image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "../../Asset/nodata_r.png"));
                    this.panelPictureBox.Image = image;
                }

                try
                {
                 

                    if (this.FileActive.FileDatas != null)
                    {
                        foreach (FileData fd in this.FileActive.FileDatas)
                        {
                            ListViewItem item = new ListViewItem(fd.Data.Label);
                            item.SubItems.Add(fd.Value);
                            this.properties.Items.Add(item);
                        }
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void DisplayService_BindList()
        {
            this.DataService_Load();
            this.list.Items.Clear();
            if (this.Files == null) return;
            foreach (File f in this.Files)
            {
                ListViewItem item = new ListViewItem(f.Name);
                item.SubItems.Add(f.Path);


                this.list.Items.Add(item);
            }
        }

        private void buttonAddVideo_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ValidateNames = true;
            dialog.Multiselect = true;

            dialog.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            dialog.Filter += "|PNG Portable Network Graphics (*.png)|" + "*.png";
            dialog.Filter += "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|" + "*.jpg;*.jpeg;*.jfif";
            dialog.Filter += "|BMP Windows Bitmap (*.bmp)|" + "*.bmp";
            dialog.Filter += "|TIF Tagged Imaged File Format (*.tif *.tiff)|" + "*.tif;*.tiff";
            dialog.Filter += "|GIF Graphics Interchange Format (*.gif)|" + "*.gif";

           
            var response = dialog.ShowDialog();
            if (response == DialogResult.OK)
            {
                foreach(string fileName in dialog.FileNames)
                {
                       
                    try
                    {
                        FileInfo info = new FileInfo(fileName);
                        File file = DbService.CreateFile(info.Name, info.FullName);
                        Data dataSize = this.Datas.Single(d => d.Label == "size");
                        if (dataSize != null)
                        {
                            DbService.CreateFileData(file, dataSize, info.Length.ToString());
                        }

                        Data dataDimension = this.Datas.Single(d => d.Label == "dimension");
                        if (dataDimension != null)
                        {
                            Bitmap placeholder = new Bitmap(fileName);
                            DbService.CreateFileData(file, dataDimension, placeholder.Width + " x " + placeholder.Height);
                        }

              
                        

                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine(exception);
                        MessageBox.Show(exception.Message, "Error when adding file to our directory.");
                    }
                }

                this.Query = "";
                DisplayService_BindList();
                this.FileActive = null;
                DisplayService_BindPanel();
            }
            

        }

        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            if(this.FileActive != null)
            {
                DbService.RemoveFileById(this.FileActive.FileId);
                MessageBox.Show(this.FileActive.Name, "File removed from directory listing.");

                this.FileActive = null;
                DisplayService_BindList();
                DisplayService_BindPanel();
            }

         
        }


        private void buttonManageProperties_Click(object sender, EventArgs e)
        {
            PropertiesManager manager = new PropertiesManager(this);
            manager.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.FileActive != null)
            {
                FilePropertiesManager manager = new FilePropertiesManager(this, this.FileActive.FileId);
                manager.Show();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = this.searchBox.Text;
            this.Query = query;

            DisplayService_BindList();
        }
    }   
}
