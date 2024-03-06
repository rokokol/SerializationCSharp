using System;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using VideoShop;

namespace SerializationCSharp
{
    public partial class MainForm : Form
    {
        public static MainForm FORM { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            FORM = this;
            // var options = new JsonSerializerOptions
            // {
            //     WriteIndented = true
            // };
            // File.WriteAllText("../../shop.json", JsonSerializer.Serialize(sp, options));
            // string json = File.ReadAllText("../../Source/shop.json");
            // Worker lol = JsonSerializer.Deserialize<Worker>(json);
            // MessageBox.Show(JsonSerializer.Serialize(lol, options));
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            //     return;
            //
            // string filename = openFileDialog.FileName;
            // string fileText = System.IO.File.ReadAllText(filename);
            // MessageBox.Show("File opened");
            Workspace workspace = new Workspace();
            workspace.Show();
            Hide();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered by Ilyusha", "About tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}