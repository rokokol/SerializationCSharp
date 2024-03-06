using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializationCSharp
{
    public partial class Workspace : Form
    {
        public Workspace()
        {
            InitializeComponent();
            Closed += delegate { MainForm.FORM.Show(); };
            FormClosing += Worlspace_FormClosing;
        }

        private bool DesirealizeObject(string path, out object result)
        {
            try
            {
                string ext = Path.GetExtension(path);
                if (ext == "json")
                {
                    string json = File.ReadAllText(path);
                    result = JsonSerializer.Deserialize<object>(json);
                }
                else if (ext == "xml")
                {
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(object));
                        result = xmlSerializer.Deserialize(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Unknown file extensoin",
                        "Unknown file extensoin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    
                    result = null;
                    return false;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message,
                    "IO Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                result = null;
                return false;
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message,
                    "JSON Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
                result = null;
                return false;
            }

            return true;
        }
        
        private void Worlspace_FormClosing(Object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you sure want to leave?", 
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        
        private void exitTool_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you sure want to leave?", 
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}