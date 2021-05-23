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
    public partial class NPCSpeak : Form
    {
        public NPCSpeak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "@");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "#$b#");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialogBody.Text = dialogBody.Text.Insert(dialogBody.SelectionStart, "^");
        }

        private void NPCSpeak_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string parse = $"speak {npcList.Text} \"{dialogBody.Text}\"";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
