using Newtonsoft.Json;
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

namespace NPC_Creator
{
    public partial class HasItem : Form
    {
        public HasItem()
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

        private void HasItem_Load(object sender, EventArgs e)
        {
            string populateItem = File.ReadAllText(Environment.CurrentDirectory + "\\Common Data\\ItemList.json");
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemList.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }

        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemList.SelectedItem;
            string parse = $"i {item.Id}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
