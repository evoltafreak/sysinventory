using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Datasource;
using SysInventory.Helper;
using SysInventory.View;

namespace SysInventory
{
    public partial class MainForm : Form
    {
        public InventoryController InventoryController { get; set; }
        public MainForm()
        {
            InitializeComponent();
            InventoryController = new InventoryController();
        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = LBoxFilteredScanList.Items;
            List<string> nameList = InventoryController.compareItemProperties(list);



            for(int i = 0;i < nameList.Count;i++)
            {
                if(i == 0 || i == 1)
                {
                    LblListBox1.Text = "Erster Scan " + nameList[0].Substring(11, 19);
                    LblListBox2.Text = "Zweiter Scan " + nameList[1].Substring(11, 19);
                    continue;
                }
                if(i % 2 == 0)
                {
                    Lbox1.Items.Add(nameList[i]);
                }else
                {
                    Lbox2.Items.Add(nameList[i]);
                }
            }


        }

        private void CmdUploadFile_Click(object sender, EventArgs e)
        {
            InventoryController.loadList();
            LblScanOpenPath.Text = "Pfad: " + InventoryController.ScanPath;
        }

        private void CmdFilter_Click(object sender, EventArgs e)
        {

            if(InventoryController.LoadedList != null)
            {
                LBoxScanList.Items.Clear();
                int i = 1;
                foreach (List<ItemProperty> list in InventoryController.LoadedList)
                {
                    foreach (ItemProperty item in list)
                    {
                        if (item.Name.Equals("timestamp"))
                        {
                            DateTime dateTime = Convert.ToDateTime(item.Value).Date;
                            if (DatePicker.Value.Date.Equals(dateTime))
                            {
                                LBoxScanList.Items.Add(Convert.ToDateTime(item.Value) + " (Scan " + i + ")");
                                i++;
                            }
                        }
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

            if(LBoxScanList.SelectedIndex != -1)
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
                        if(LBoxFilteredScanList.Items.Count == 2)
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
                string json = JsonHelper.createJSONStructure();
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
            ScanDetail scanDetail = new ScanDetail();
            scanDetail.Index = LBoxScanList.SelectedIndex;
            scanDetail.InventoryContoller = InventoryController;
            scanDetail.Show();
            

        }
    }
}
