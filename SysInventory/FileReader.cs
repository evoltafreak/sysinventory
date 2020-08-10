using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Datasource;

namespace SysInventory
{
    public class FileReader
    {

        public List<List<ItemProperty>> readFile(string path)
        {

            List<ItemProperty> list = new List<ItemProperty>();
            string text = System.IO.File.ReadAllText(@path);
            JObject jObject = JObject.Parse(text);
            JsonFile jsonFile = new JsonFile();

            List<List<ItemProperty>> newList2 = new List<List<ItemProperty>>();


            JToken[] values = jObject["values"].ToArray();
            foreach(JToken arr in values)
            {
                List<ItemProperty> newList = new List<ItemProperty>();
                JToken[] values2 = arr.ToArray();
                foreach(JToken arr2 in values2)
                {
                    ItemProperty itemProperty = new ItemProperty(arr2["Name"].ToString(), arr2["Value"].ToString());
                    newList.Add(itemProperty);
                }

                newList2.Add(newList);

            }
      
            return newList2;
        }

    }
}
