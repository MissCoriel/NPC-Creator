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
    public partial class Add_Items : Form
    {
        public string itemLoad = Environment.CurrentDirectory + "\\Common Data\\ItemList.json";
        public Add_Items()
        {
            InitializeComponent();
        }
        private IEnumerable<string> GetItems(ListBox listbox)
        {
            foreach (object entry in listbox.Items)
                yield return entry.ToString();
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


        private void Add_Items_Load(object sender, EventArgs e)
        {
            //Populate Item list for Gift Taste
            string populateItem = File.ReadAllText(itemLoad);
            var parseJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(populateItem);
            foreach (KeyValuePair<string, string> pair in parseJson)
            {
                itemList.Items.Add(new ItemDescription(pair.Key, pair.Value));
            }


        }

        private void addItem_Click(object sender, EventArgs e)
        {
            var item = (ItemDescription)itemList.SelectedItem;
            addItemList.Items.Add(item.Id);
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            addItemList.Items.Remove(addItemList.SelectedItem);
        }

        private void addCommand_Click(object sender, EventArgs e)
        {
            string parse = "[" + string.Join(" ", this.GetItems(addItemList)) + "]";
            dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            mw.InsertingCommand(parse);
            this.Close();
        }
    }
}
