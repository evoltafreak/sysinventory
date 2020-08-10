using System.Collections.Generic;
using System;

namespace Datasource {
    public class Item {
        public Item(string itemType, List<ItemProperty> properties) {
            this.ItemType = itemType;
            this.Properties = properties;
        }

        public string ItemType { get; }
        public List<ItemProperty> Properties { get; }

        public DateTime timestamp;

    }
}