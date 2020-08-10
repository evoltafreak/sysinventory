using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SysInventory.Helper;
using SysInventory.View;
using SysInventory.Model;

namespace SysInventory
{
    public partial class MainForm : Form
    {
        public InventoryController InventoryController { get; set; }
        
        public ListBox GetBox()
        {
            return this.LBoxFilteredScanList;
        }
        public MainForm()
        {
            InitializeComponent();
            InventoryController = new InventoryController();
            InventoryController.MainForm = this;
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            Lbox1.Items.Clear();
            Lbox2.Items.Clear();
            ListBox.ObjectCollection list = LBoxFilteredScanList.Items;
            List<string> nameList = InventoryController.compareItemProperties(list);
            LblListBox1.Text = "Erster Scan " + list[0].ToString().Substring(0, 19);
            LblListBox2.Text = "Zweiter Scan " + list[1].ToString().Substring(0, 19);
            for (int i = 0; i < nameList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Lbox1.Items.Add(nameList[i]);
                }
                else
                {
                    Lbox2.Items.Add(nameList[i]);
                }
            }


        }

        private void CmdUploadFile_Click(object sender, EventArgs e)
        {
            InventoryController.loadList();
            if(InventoryController.ScanPath != null)
            {
                LblScanOpenPath.Text = "Pfad: " + InventoryController.ScanPath;
                CmdFilter.Enabled = true;
                DatePicker.Enabled = true;
                CmdAdd.Enabled = true;
                CmdRemove.Enabled = true;
                CmdShow.Enabled = true;
                CmdHistory.Enabled = true;
            }
        }

        private void CmdFilter_Click(object sender, EventArgs e)
        {

            if (InventoryController.DataList != null)
            {
                LBoxScanList.Items.Clear();
                int i = 1;
                foreach (SysInventoryData data in InventoryController.DataList)
                {
                    if (DatePicker.Value.Date.Equals(data.Timestamp.Date))
                    {
                        LBoxScanList.Items.Add(Convert.ToDateTime(data.Timestamp.ToString()) + " (Scan " + data.Sid + ")");
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Scan-Datei aus.", "Scan-Datei auswählen");
            }


        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {

            if (LBoxScanList.SelectedIndex != -1)
            {
                if (LBoxFilteredScanList.Items.Count == 2)
                {
                    MessageBox.Show("Es dürfen maximal zwei Scans ausgewählt werden.");
                }
                else
                {
                    bool check = true;
                    foreach (var item in LBoxFilteredScanList.Items)
                    {
                        if (item.ToString().Equals(LBoxScanList.SelectedItem))
                        {
                            MessageBox.Show("Es darf nicht dasselbe Element hinzugefügt werden.", "Nicht erlaubt");
                            check = false;
                        }
                    }
                    if (check)
                    {
                        LBoxFilteredScanList.Items.Add(LBoxScanList.SelectedItem);
                        if (LBoxFilteredScanList.Items.Count == 2)
                        {
                            CmdCompare.Enabled = true;
                        }
                    }

                }
            }

        }

        private void CmdRemove_Click(object sender, EventArgs e)
        {
            if (LBoxFilteredScanList.SelectedIndex != -1)
            {
                LBoxFilteredScanList.Items.RemoveAt(LBoxFilteredScanList.SelectedIndex);
                CmdCompare.Enabled = false;
            }
        }

        private void CmdScan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                string filePath = folderPath + "\\" + OSHelper.GetSID() + ".json";
                string json = JsonHelper.createJSONStructure(filePath);
                JsonHelper.writeJSON(filePath, json);
                MessageBox.Show("Scan erfolgreich abgeschlossen.\r\nOutput: " + filePath, "Scan erfolgreich");
                LblScanSavePath.Text = "Pfad: " + filePath;
            }
            else
            {
                MessageBox.Show("Scan fehlgeschlagen", "Scan fehlgeschlagen");
            }

        }

        private void CmdShow_Click(object sender, EventArgs e)
        {
            if (LBoxScanList.SelectedIndex != -1)
            {
                ScanDetail scanDetail = new ScanDetail();
                scanDetail.Index = LBoxScanList.SelectedIndex;
                scanDetail.InventoryController = InventoryController;
                scanDetail.Show();
            }
        }

        private void CmdHistory_Click(object sender, EventArgs e)
        {
            if (InventoryController.DataList != null)
            {
                HistoryDetail historyDetail = new HistoryDetail();
                historyDetail.InventoryContoller = InventoryController;
                historyDetail.Show();
            }
        }
    }
}
