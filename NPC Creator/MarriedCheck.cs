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
    public partial class MarriedCheck : Form
    {
        public MarriedCheck()
        {
            InitializeComponent();
        }

        private void MarriedCheck_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            npcList.Items.Remove("Jas");
            npcList.Items.Remove("Vincent");
            npcList.Items.Remove("Leo");

        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if (npcList.Text == "Jas" || npcList.Text == "Vincent" || npcList.Text == "Leo")
            {
                MessageBox.Show("This Mod Tool tries to prevent all instances of Dating/Marriage to children.\nYou are prevented from using Jas, Vincent, or Leo!", "Why don't you take a seat?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string parse = $"O {npcList.Text}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }

        }
    }
}
