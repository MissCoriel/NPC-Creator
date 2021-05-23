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
    public partial class WhoisPresent : Form
    {
        public WhoisPresent()
        {
            InitializeComponent();
        }

        private void WhoisPresent_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(npcList.Text))
            {
                string parse = $"p {npcList.Text}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }
            else
            {
                MessageBox.Show("You cannot have an empty condition.\nSelect or type a NPC name.", "Who we looking for?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
