using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Datasource;
using SysInventory.Model;

namespace SysInventory.View
{
    public partial class HistoryDetail : Form
    {
        public InventoryController InventoryContoller { get; set; }
        public HistoryDetail()
        {
            InitializeComponent();
        }

        private void HistoryDetail_Shown(object sender, EventArgs e)
        {
            foreach (SysInventoryData data in InventoryContoller.DataList)
            {
                foreach (Item item in data.ItemList)
                {
                    foreach (ItemProperty prop in item.Properties)
                    {
                        LBox1.Items.Add(prop.Name);
                    }
                }
            }
        }

        private void CmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdShowHistory_Click(object sender, EventArgs e)
        {
            LBox2.Items.Clear();
            if (LBox1.SelectedIndex != -1)
            {
                List<string> nameList = InventoryContoller.filterDataListByKey(LBox1.SelectedItem.ToString());
                foreach(string name in nameList)
                {
                    LBox2.Items.Add(name);
                }
            }
        }


    }
}
