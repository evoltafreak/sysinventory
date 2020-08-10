namespace Datasource {
    public class ItemProperty {
        public ItemProperty(string name, object value) {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }
        public object Value { get; set; }
    }
}
