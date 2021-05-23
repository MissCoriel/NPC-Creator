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
    public partial class FriendshipPoints : Form
    {
        List<string> friendshipCollection = new List<string>();
        public FriendshipPoints()
        {
            InitializeComponent();
        }

        private void FriendshipPoints_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
        }

        private void AddtoList_Click(object sender, EventArgs e)
        {
            int heartsToFriendship = (int)heartAmount.Value * 250;
            string addtoList = $"{npcList.Text} {heartsToFriendship}";
            npcDatum.Items.Add(addtoList);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            npcDatum.Items.Remove(npcDatum.SelectedItem);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            npcDatum.Items.Clear();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            foreach (var item in npcDatum.Items)
            {
                string entry = item.ToString();
                friendshipCollection.Add(entry);
            }
            string parse = "f " + string.Join(" ", friendshipCollection);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();


        }
    }
}
