using System;
using System.Windows.Forms;

namespace SerializationCSharp
{
    public partial class MainForm : Form
    {
        public static MainForm FORM { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            FORM = this;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
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