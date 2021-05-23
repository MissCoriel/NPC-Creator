using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class MoveActor : Form
    {
        private string contOK = "true";
        private string parse;
        public MoveActor()
        {
            InitializeComponent();
        }

        private void MoveActor_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.Add("farmer");
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }

        private void moveX_ValueChanged(object sender, EventArgs e)
        {
            if(moveX.Value != 0)
            {
                moveY.Enabled = false;
            }
            if(moveX.Value == 0)
            {
                moveY.Enabled = true;
            }
        }

        private void moveY_ValueChanged(object sender, EventArgs e)
        {
            if (moveY.Value != 0)
            {
                moveX.Enabled = false;
            }
            if (moveY.Value == 0)
            {
                moveX.Enabled = true;
            }

        }

        private void isContinue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parse = $"move {npcList.Text} {moveX.Value} {moveY.Value} {numericUpDown3.Value}";
            if (isContinue.Checked == true)
            {
                parse = parse + " true";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
