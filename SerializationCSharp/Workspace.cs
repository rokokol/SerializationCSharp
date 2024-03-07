using System;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using VideoShop;

namespace SerializationCSharp
{
    public partial class Workspace : Form
    {
        public Workspace()
        {
            InitializeComponent();
            Closed += delegate { MainForm.FORM.Show(); };
            FormClosing += Worlspace_FormClosing;
            categories.BeforeSelect += categories_BeforeSelect;
        }

        public static bool DeserializeObject<T>(string path, out T result) where T : class
        {
            try
            {
                string ext = Path.GetExtension(path);
                if (ext == ".json" || ext == ".jsn")
                {
                    string json = File.ReadAllText(path);
                    result = JsonSerializer.Deserialize<T>(json);
                }
                else if (ext == ".xml")
                {
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        result = xmlSerializer.Deserialize(fs) as T;
                    }
                }
                else
                {
                    MessageBox.Show("Unknown file extensoin",
                        "Unknown file extensoin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    
                    result = default;
                    return false;
                }

                return true;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message,
                    "IO Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message,
                    "JSON Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.Message,
                    "XML Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            result = default;
            return false;
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

        private void addShopTool_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (DeserializeObject(openFileDialog.FileName, out Shop shop))
            {
                MessageBox.Show("Successfully opened",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TreeNode node = new TreeNode(shop.Name);
                categories.Nodes["Shops"].Nodes.Add(node);
                node.Tag = shop;
            }
        }

        private void addWorkerTool_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (DeserializeObject(openFileDialog.FileName, out Worker worker))
            {
                MessageBox.Show("Successfully opened",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TreeNode node = new TreeNode(worker.Name);
                categories.Nodes["Workers"].Nodes.Add(node);
                node.Tag = worker;
            }
        }

        private void addGoodTool_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (DeserializeObject(openFileDialog.FileName, out Good good))
            {
                MessageBox.Show("Successfully opened",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TreeNode node = new TreeNode(good.Name);
                categories.Nodes["Goods"].Nodes.Add(node);
                node.Tag = good;
            }
        }

        private static TreeNode ToShopNode(Shop shop)
        {
            TreeNode shopNode = new TreeNode(shop.Name);
            
            TreeNode nameNode = new TreeNode("Name");
            TreeNode priceNode = new TreeNode("Price");
            TreeNode ratingNode = new TreeNode("Rating");
            TreeNode goodsNode = new TreeNode("Goods");
            TreeNode workersNode = new TreeNode("Workers");
                
            nameNode.Nodes.Add(new TreeNode(shop.Name));
            priceNode.Nodes.Add(new TreeNode(shop.Price.ToString(CultureInfo.InvariantCulture)));
            ratingNode.Nodes.Add(new TreeNode(shop.Rating.ToString()));
            
            foreach (var good in shop.Goods)
            {
                goodsNode.Nodes.Add(ToGoodNode(good));
            }
            
            foreach (var worker in shop.Workers)
            {
                workersNode.Nodes.Add(ToWorkerNode(worker));
            }

            shopNode.Nodes.Add(nameNode);
            shopNode.Nodes.Add(priceNode);
            shopNode.Nodes.Add(ratingNode);
            shopNode.Nodes.Add(goodsNode);
            shopNode.Nodes.Add(workersNode);

            return shopNode;
        }

        private static TreeNode ToGoodNode(Good good)
        {
            TreeNode goodNode = new TreeNode(good.Name);
            
            TreeNode nameNode = new TreeNode("Name");
            TreeNode priceNode = new TreeNode("Price");
            TreeNode ratingNode = new TreeNode("Rating");
            
            nameNode.Nodes.Add(new TreeNode(good.Name));
            priceNode.Nodes.Add(new TreeNode(good.Price.ToString(CultureInfo.InvariantCulture)));
            ratingNode.Nodes.Add(new TreeNode(good.Rating.ToString()));
            
            goodNode.Nodes.Add(nameNode);
            goodNode.Nodes.Add(priceNode);
            goodNode.Nodes.Add(ratingNode);
            
            return goodNode;
        }
        
        private static TreeNode ToWorkerNode(Worker worker)
        {
            TreeNode workerNode = new TreeNode(worker.Name);
            
            TreeNode nameNode = new TreeNode("Name");
            TreeNode salaryNode = new TreeNode("Rating");
            TreeNode iqNode = new TreeNode("IQ");
            TreeNode isSingleNode = new TreeNode("Is single");
            
            nameNode.Nodes.Add(new TreeNode(worker.Name));
            iqNode.Nodes.Add(new TreeNode(worker.Iq.ToString()));
            salaryNode.Nodes.Add(new TreeNode(worker.Salary.ToString(CultureInfo.InvariantCulture)));
            isSingleNode.Nodes.Add(new TreeNode(worker.IsSingle.ToString()));
            
            workerNode.Nodes.Add(nameNode);
            workerNode.Nodes.Add(iqNode);
            workerNode.Nodes.Add(salaryNode);
            workerNode.Nodes.Add(isSingleNode);
            
            return workerNode;
        }
        
        private void categories_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            string name = e.Node.Parent?.Name;
            
            if (name == "Shops")
            {
                contentView.Nodes.Clear();
                contentView.Nodes.Add(ToShopNode((Shop)e.Node.Tag));
            } 
            else if (name == "Workers")
            {
                contentView.Nodes.Clear();
                contentView.Nodes.Add(ToWorkerNode((Worker)e.Node.Tag));
            }
            else if (name == "Goods")
            {
                contentView.Nodes.Clear();
                contentView.Nodes.Add(ToGoodNode((Good)e.Node.Tag));
            }
        }
    }
}