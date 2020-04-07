using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyPhotos;
using FileIO = System.IO.File;
using File = MyPhotos.File;


namespace MyPhotosUI
{
    public partial class PropertiesManager : Form
    {
        /*        DbService DbService;*/
        Service.InterfaceWCFClient DbService;
        List<Data> Datas = new List<Data> { };
        Dashboard Dashboard = null;
        public PropertiesManager(Form dashboard)
        {
            InitializeComponent();
            this.DbService = new Service.InterfaceWCFClient();
  /*          this.DbService = new DbService();*/
            this.Dashboard = dashboard as Dashboard;
            DisplayService_BindList();

        }

        private void PropertiesManager_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Closing...");
            this.Dashboard.Query = "";
            /* this.Dashboard.FileActive = null;
             this.Dashboard.DisplayService_BindPanel();*/
        }



            private void DataService_Load()
        {
            this.Datas = DbService.GetDatas().ToList();
        }


        private void list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.list.Items.Count; i++)
            {
                ListViewItem item = this.list.Items[i];
                if (item.Bounds.Contains(e.Location))
                {
                    if (this.Datas[i].IsEditable == false) return;

                    const string message = "Are you sure that you would like to remove this property?";
                    const string caption = "Property Removal";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DbService.RemoveDataById(this.Datas[i].DataId);
                        DisplayService_BindList();


                    }

                }
            }

        }


        private void DisplayService_BindList()
        {
            this.DataService_Load();
            this.list.Items.Clear();
            foreach (Data d in this.Datas)
            {
                ListViewItem item = new ListViewItem(d.DataId.ToString());
                item.SubItems.Add(d.Label);
                item.SubItems.Add(d.IsSearchable ? "Yes" : "No");
                item.SubItems.Add(d.IsEditable ? "Yes" : "No");
                this.list.Items.Add(item);

            }
        }

        private void buttonPropertyCreate_Click(object sender, EventArgs e)
        {
            string label = this.propertyLabel.Text;
            bool isSearchable = this.propertyIsSearchable.Checked;

            if(label.Length > 0)
            {
                DbService.CreateData(label, isSearchable);
                DisplayService_BindList();
                this.propertyLabel.Clear();
                this.propertyIsSearchable.Checked = true;
            }
        }
    }
}
