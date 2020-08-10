using System.Collections.Generic;

namespace Datasource {
    public class Item {

        public Item()
        {

        }

        public Item(string itemType, List<ItemProperty> properties) {
            this.ItemType = itemType;
            this.Properties = properties;
        }
        public string ItemType { get; set; }
        public List<ItemProperty> Properties { get; set; }

    }
}