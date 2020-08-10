using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datasource;
using System.Web.Script.Serialization;
using System.Net.NetworkInformation;
using System.Security.Principal;

namespace SysInventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<Item> items = Data.Read();
            String json = "";
            foreach (var item in items)
            {
                Console.WriteLine(item.ItemType);
  
                foreach (var prop in item.Properties)
                {
                    //Console.WriteLine($"       {prop.Name}: {prop.Value}");
                    Console.WriteLine(ToJSON(prop));
                    json += ToJSON(prop);
                    json += "\r\n,";
                }
                
            }
            ItemProperty itemProperty = new ItemProperty("timestamp", DateTime.Now.ToString());
            string file = "{\r\n\"timestamp\": " + ToJSON(itemProperty) + ",\r\n";
            file += "\"values\": [";
            file += json + ",\r\n";
            file = file.Substring(0, file.Length - 5);
            file += "]\r\n}";
            writeTextFile(file);
            LblScan.Text = "Scan erfolgreich abgeschlossen.";
        }

        private string ToJSON(ItemProperty obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(obj);
        }

        private void writeJSON()
        {
            /*string json = JsonConvert.SerializeObject(_data.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"C:\Users\joshu\Desktop\test.txt", json);*/
        }

        private void writeTextFile(string json)
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllText(@"C:\Users\joshu\Desktop\" + GetSID() + ".json", json);

        }

        public PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

        private string GetSID()
        {
            string sid = WindowsIdentity.GetCurrent().User.ToString();
            return sid.Replace("-", "");
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CmdCompare_Click(object sender, EventArgs e)
        {
            /*FileReader fileReader = new FileReader();
            List<List<ItemProperty>> list = fileReader.readFile(fileUploadOne.Path);
            List<ItemProperty> foundList = new List<ItemProperty>();

            for (int i = 0;i < list.Count; i++)
            {
                if (list[i].Name.Equals("timestamp"))
                {
                    LblListBox1.Text += list[i].Value;
                    LblListBox2.Text += list2[i].Value;
                    continue;
                }
                for (int j = 0; j < list2.Count; j++)
                {

                    if (list[i].Name.Equals(list2[j].Name))
                    {
                        if (!list[i].Value.Equals(list2[j].Value))
                        {
                            Lbox1.Items.Add(list[i].Name + ": " + list[i].Value);
                            Lbox2.Items.Add(list2[i].Name + ": " + list2[i].Value);
                            foundList.Add(list[i]);
                            foundList.Add(list2[i]);
                        }
                    }
                }
            }*/



        }

        private void AddHits(List<ItemProperty> foundList)
        {
            foreach(ItemProperty item in foundList)
            {
                Lbox1.Items.Add(item.Value);
            }
        }

        private FileUpload fileUploadOne = new FileUpload();
        private FileUpload fileUploadTwo = new FileUpload();

        private List<List<ItemProperty>> loadedList;

        private void CmdUploadFileOne_Click(object sender, EventArgs e)
        {
            
            LblScanFileOne.Text += fileUploadOne.uploadFile("Erste Scan-Datei hochladen", this.fileUploadTwo.Path);
            FileReader fileReader = new FileReader();
            loadedList = fileReader.readFile(fileUploadOne.Path);
        }

        private void CmdFilter_Click(object sender, EventArgs e)
        {

            if(loadedList != null)
            {
                LBoxScanList.Items.Clear();
                int i = 1;
                foreach (List<ItemProperty> list in loadedList)
                {
                    foreach (ItemProperty item in list)
                    {
                        if (item.Name.Equals("timestamp"))
                        {
                            DateTime dateTime = Convert.ToDateTime(item.Value).Date;
                            if (DatePicker.Value.Date.Equals(dateTime))
                            {
                                LBoxScanList.Items.Add("Scan " + i + ": " + Convert.ToDateTime(item.Value));
                                i++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Scan-Datei aus.");
            }


        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {

            if(LBoxFilteredScanList.Items.Count == 2)
            {
                MessageBox.Show("Es dürfen maximal zwei Scans ausgewählt werden.");
            }else
            {

                foreach(ListBox.ObjectCollection item in LBoxFilteredScanList.Items)
                {
                    if (item.Equals(LBoxScanList.SelectedItem))
                    {
                        MessageBox.Show("Es darf nicht dasselbe Element hinzugefügt werden.");
                    }
                }

                LBoxFilteredScanList.Items.Add(LBoxScanList.SelectedItem);
            }
        }

        private void CmdRemove_Click(object sender, EventArgs e)
        {
            LBoxFilteredScanList.Items.RemoveAt(LBoxFilteredScanList.SelectedIndex);
        }
    }
}
