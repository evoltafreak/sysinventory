using System.Windows.Forms;
namespace SysInventory
{
    public class FileUpload
    {

        public string Path { get; set; }

        public string uploadFile(string title, string pathTwo)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = title,

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (checkFile(openFileDialog1.FileName, pathTwo))
                {
                    string path = openFileDialog1.FileName;
                    Path = path;
                    return path;
                }
                MessageBox.Show("Die zwei zu vergleichenden Dateien dürfen nicht identisch sein.");
                return "";
            }
            return "";

        }

        public bool checkFile(string pathOne, string pathTwo)
        {
            return !pathOne.Equals(pathTwo);
        }

    }
}
