using System.Collections.Generic;
using System.Windows.Forms;
using Datasource;
using SysInventory.Helper;
using SysInventory.Model;

namespace SysInventory
{
    public class InventoryController
    {

        public string ScanPath { get; set; }
        public List<SysInventoryData> DataList { get; set; }

        public MainForm MainForm { get; set; }

        public List<string> compareItemProperties(ListBox.ObjectCollection lboxList)
        {
            int index1 = 0;
            int index2 = 0;
            int i = 0;
            int j = 0;
            foreach (var lbox in lboxList)
            {
                foreach (SysInventoryData data in DataList)
                {
                    string val = lbox.ToString().Substring(0, 19);
                    if (data.Timestamp.ToString().Equals(val))
                    {
                        if (j == 0)
                        {
                            index1 = j;
                        }
                        else
                        {
                            index2 = j;
                        }
                    }
                    i++;
                }
                j++;
            }


            List<ItemProperty> firstList = new List<ItemProperty>();
            List<ItemProperty> secondList = new List<ItemProperty>();
            foreach (Item item in DataList[index1].ItemList)
            {
                foreach (ItemProperty prop in item.Properties)
                {
                    firstList.Add(prop);
                }
            }
            firstList.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (Item item in DataList[index2].ItemList)
            {
                foreach (ItemProperty prop in item.Properties)
                {
                    secondList.Add(prop);
                }
            }
            secondList.Sort((x, y) => x.Name.CompareTo(y.Name));

            List<string> nameList = new List<string>();

            for (int x = 0; x < firstList.Count; x++)
            {
                for (int y = 0; y < secondList.Count; y++)
                {
                    if (firstList[x].Name.Equals(secondList[y].Name))
                    {
                        if (!firstList[x].Value.Equals(secondList[y].Value))
                        {
                            nameList.Add(firstList[x].Name + ": " + firstList[x].Value);
                            nameList.Add(secondList[x].Name + ": " + secondList[x].Value);
                        }
                    }
                }
            }

            return nameList;

        }

        public List<string> filterDataListByKey(string key)
        {
            List<string> nameList = new List<string>();
            foreach (SysInventoryData data in DataList)
            {
                foreach (Item item in data.ItemList)
                {
                    foreach (ItemProperty prop in item.Properties)
                    {
                        if (prop.Name.Equals(key))
                        {
                            nameList.Add(data.Timestamp + " - " + prop.Name + ": " + prop.Value);
                            break;
                        }
                    }
                }
            }
            return nameList;
        }

        public void loadList()
        {
            string path = FileHelper.openFilePath();          
            if (path != null)
            {
                DataList = FileHelper.readFile(path);
                ScanPath = path;
                MessageBox.Show("JSON-Datei ist valide.", "JSON");
            }

        }

    }
}
