using System;
using System.Collections.Generic;
using Datasource;

namespace SysInventory.Model
{
    public class SysInventoryData
    {
        public string Sid { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Item> ItemList { get; set; }
    }
}
