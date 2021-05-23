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
    public partial class Create_Question : Form
    {
        private string parse;
        public Create_Question()
        {
            InitializeComponent();
        }

        private void Create_Question_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
                npcList.Items.Remove("farmer");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            }

        }

        private void enableFork_CheckedChanged(object sender, EventArgs e)
        {
            if (enableFork.Checked == true)
            {
                forkData.Enabled = true;
            }
            if(enableFork.Checked == false)
            {
                forkData.Enabled = false;
            }
        }

        private void enableThird_CheckedChanged(object sender, EventArgs e)
        {
            if(enableThird.Checked == true)
            {
                thirdAnswer.Enabled = true;
                thirdFP.Enabled = true;
                thirdKey.Enabled = true;
                thirdResponseID.Enabled = true;
                thirdSub.Enabled = true;
            }
            if(enableThird.Checked == false)
            {
                thirdAnswer.Enabled = false;
                thirdFP.Enabled = false;
                thirdKey.Enabled = false;
                thirdResponseID.Enabled = false;
                thirdSub.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(enableThird.Checked == true)
            {
                parse = $"speak {npcList.Text} \"$q {firstResponse.Value} null#{askQuestion.Text}#$r {firstResponse.Value} {firstFP.Value} {firstKey.Text}#{firstAnswer.Text}#$r {secondResponseID.Value} {secondFP.Value} {secondKey.Text}#{secondAnswer.Text}#$r {thirdResponseID.Value} {thirdFP.Value} {thirdKey.Text}#{thirdAnswer.Text}\"";
            }
            if (enableThird.Checked == false)
            {
                parse = $"speak {npcList.Text} \"$q {firstResponse.Value} null#{askQuestion.Text}#$r {firstResponse.Value} {firstFP.Value} {firstKey.Text}#{firstAnswer.Text}#$r {secondResponseID.Value} {secondFP.Value} {secondKey.Text}#{secondAnswer.Text}\"";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            if(enableFork.Checked == true)
            {
                string first = $"fork {firstResponse.Value} {firstSub.Text}";
                string second = $"fork {secondResponseID.Value} {secondSub.Text}";
                if(enableThird.Checked == true)
                {
                    string third = $"fork {thirdResponseID.Value} {thirdSub.Text}";
                    mw.addCommandtoList(third);
                }
                mw.addCommandtoList(first);
                mw.addCommandtoList(second);
            }
            this.Close();
        }
    }
}
