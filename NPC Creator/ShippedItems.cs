using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creator
{
    public partial class ShippedItems : Form
    {
        List<string> shippingManifest = new List<string>();
        public ShippedItems()
        {
            InitializeComponent();
        }
        class ItemDescription
        {
            public ItemDescription(string name, string id)
            {
                Name = name;
                Id = id;
            }
            public string Name;
            public string Id;
            public override string ToString()
            {
                return Name;
            }
        }

        private void ShippedItems_Load(object sender, EventArgs e)
        {
            string populateItem = File.ReadAllText(Environment.CurrentDirectory + "\\Common Data\\ItemList.json");
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemList.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }
        }

        private void AddtoList_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(itemList.Text))
            {
                var item = (ItemDescription)itemList.SelectedItem;
                string sendtoList = $"{item.Id} {shipAmount.Value}";
                shippingList.Items.Add(sendtoList);
            }
            else
            {
                MessageBox.Show("Please complete all fields!", "Ship what?  Nothing?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            shippingList.Items.Remove(shippingList.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            shippingList.Items.Clear();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            foreach(var set in shippingList.Items)
            {
                string entry = set.ToString();
                shippingManifest.Add(entry);
            }
            string parse = "s " + string.Join(" ", shippingManifest);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
