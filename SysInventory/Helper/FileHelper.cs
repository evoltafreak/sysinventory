using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Datasource;
using System.Windows.Forms;
using SysInventory.Model;

namespace SysInventory.Helper
{
    public class FileHelper
    {
        public static string openFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Scan-Datei laden",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        public static List<SysInventoryData> readFile(string path)
        {
            // Read file as string
            string json = System.IO.File.ReadAllText(@path);

            // Parse file to JObject
            try
            {
                JArray jArray = JArray.Parse(json);
                return createScanList(jArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JSON entspricht nicht der erwarteten Struktur.", "JSON");
            }
            return null;
        }

        private static List<SysInventoryData> createScanList(JArray jArray)
        {
            List<SysInventoryData> dataList = new List<SysInventoryData>();
            foreach (JToken token in jArray)
            {

                SysInventoryData data = new SysInventoryData();
                List<Item> itemList = new List<Item>();
                data.Sid = token["Sid"].ToString();
                data.Timestamp = Convert.ToDateTime(token["Timestamp"].ToString());
                JToken[] jArray2 = token["ItemList"].ToArray();

                foreach (var token2 in jArray2)
                {

                    Item item = new Item();
                    item.ItemType = token2["ItemType"].ToString();
                    item.Properties = new List<ItemProperty>();
                    JToken[] properties = token2["Properties"].ToArray();

                    foreach (JToken prop in properties)
                    {
                        ItemProperty itemProperty = new ItemProperty(prop["Name"].ToString(), prop["Value"].ToString());
                        item.Properties.Add(itemProperty);
                    }
                    itemList.Add(item);
                }
                data.ItemList = itemList;
                dataList.Add(data);
            }

            return dataList;
        }

    }
}
