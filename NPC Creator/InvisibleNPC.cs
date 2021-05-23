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
    public partial class InvisibleNPC : Form
    {
        public InvisibleNPC()
        {
            InitializeComponent();
        }

        private void InvisibleNPC_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"v {npcList.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
