using System;
using System.Windows.Forms;
using Datasource;
using SysInventory.Helper;
using SysInventory.Model;

namespace SysInventory.View
{
    public partial class ScanDetail : Form
    {

        public int Index { get; set; }
        public InventoryController InventoryController { get; set; }

        public ScanDetail()
        {
            InitializeComponent();
        }

        private void ScanDetail_Shown(object sender, EventArgs e)
        {
            TxtScan.Text = "";
            foreach (Item item in InventoryController.DataList[Index].ItemList)
            {
                foreach (ItemProperty prop in item.Properties)
                {
                    TxtScan.Text += prop.Name + ": " + prop.Value + "\r\n";
                }
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            InventoryController.DataList.RemoveAt(Index);
            InventoryController.MainForm.GetBox().Items.Clear();
            string json = JsonHelper.ToJson(InventoryController.DataList);
            JsonHelper.writeJSON(this.InventoryController.ScanPath, json);
        }
    }
}
