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
    public partial class ChangeActorSprites : Form
    {
        public string useBoth = "false";
        public ChangeActorSprites()
        {
            InitializeComponent();
        }

        private void ChangeActorSprites_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
                npcList.Items.Remove("farmer");
            }
            else
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }

        private void doBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (doBoth.Checked == true)
            {
                useBoth = "true";
            }
            if (doBoth.Checked == false)
            {
                useBoth = "false";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Command requires a file with the filename <npc>_<sheet>.png in the appropriate areas.\nFor instance, 'Maru Hostpital' will use Maru_Hospital.png in Characters and Portraits.", "A little help.", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"changeSprite {npcList.Text} {textBox1.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            if(doBoth.Checked == true)
            {
                string parsePort = $"changePortrait {npcList.Text} {textBox1.Text}";
                Conditions mx = (Conditions)Application.OpenForms["Conditions"];
                mx.addCommandtoList(parsePort);

            }
            this.Close();

        }
    }
}
