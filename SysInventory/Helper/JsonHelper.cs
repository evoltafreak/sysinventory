using System;
using System.Collections.Generic;
using Datasource;
using System.Web.Script.Serialization;
using SysInventory.Model;

namespace SysInventory.Helper
{
    public class JsonHelper
    {

        // Generate json string from SysInventoryData list
        public static string ToJson(List<SysInventoryData> sysInventoryDataList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(sysInventoryDataList);
        }

        public static string createJSONStructure(string path)
        {

            // Read computer data over datasource dll
            List<Item> itemList = Data.Read();

            // Count keys
            HashSet<string> itemTypeSet = new HashSet<string>();
            foreach (Item item in itemList)
            {
                itemTypeSet.Add(item.ItemType);
            }

            // Set counter per item type
            Dictionary<string, int> itemTypeDict = new Dictionary<string, int>();
            foreach (string set in itemTypeSet)
            {
                itemTypeDict.Add(set, 0);
            }

            // Set timestamp for values
            foreach (Item item in itemList)
            {
                itemTypeDict[item.ItemType] += 1;
                foreach (ItemProperty prop in item.Properties)
                {
                    prop.Name += item.ItemType + "_" + itemTypeDict[item.ItemType];
                }
            }

            // Read existing JSON values as file if exists
            List<SysInventoryData> dataList = new List<SysInventoryData>();
            if (System.IO.File.Exists(path))
            {
                List<SysInventoryData> fileItemList = FileHelper.readFile(path);
                foreach (SysInventoryData data in fileItemList)
                {
                    dataList.Add(data);
                }
            }

            // Create SysInventory data list
            SysInventoryData sysInventoryData = new SysInventoryData();
            sysInventoryData.Sid = OSHelper.GetSID();
            sysInventoryData.Timestamp = DateTime.Now;
            sysInventoryData.ItemList = itemList;
            dataList.Add(sysInventoryData);

            return JsonHelper.ToJson(dataList);
        }

        public static void writeJSON(string path, string json)
        {
            System.IO.File.WriteAllText(@path, json);
        }
    }
}
