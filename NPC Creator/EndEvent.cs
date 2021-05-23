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
    public partial class EndEvent : Form
    {
        public string parse;
        public EndEvent()
        {
            InitializeComponent();
        }

        private void EndEvent_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
        }

        private void specialEnd_CheckedChanged(object sender, EventArgs e)
        {
            if(specialEnd.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            if(specialEnd.Checked == false)
            {
                groupBox1.Enabled = false;
            }
        }

        private void endBed_CheckedChanged(object sender, EventArgs e)
        {
            if(endBed.Checked == true)
            {
                endDialogue.Enabled = false;
                endInvisible.Enabled = false;
                endNewDay.Enabled = false;
                endWarpOut.Enabled = false;
                endCoords.Enabled = false;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
            if(endBed.Checked == true)
            {
                endDialogue.Enabled = true;
                endInvisible.Enabled = true;
                endNewDay.Enabled = true;
                endWarpOut.Enabled = true;
                endCoords.Enabled = true;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;

            }
        }

        private void endNewDay_CheckedChanged(object sender, EventArgs e)
        {
            if(endNewDay.Checked == true)
            {
                endDialogue.Enabled = false;
                endInvisible.Enabled = false;
                endBed.Enabled = false;
                endWarpOut.Enabled = false;
                endCoords.Enabled = false;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
            if(endNewDay.Checked == false)
            {
                endDialogue.Enabled = true;
                endInvisible.Enabled = true;
                endBed.Enabled = true;
                endWarpOut.Enabled = true;
                endCoords.Enabled = true;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
        }

        private void endDialogue_CheckedChanged(object sender, EventArgs e)
        {
            if (endDialogue.Checked == true)
            {
                endNewDay.Enabled = false;
                endInvisible.Enabled = false;
                endBed.Enabled = false;
                endWarpOut.Enabled = true;
                endCoords.Enabled = false;
                npcList.Enabled = true;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = true;
            }
            if(endDialogue.Checked == false)
            {
                endNewDay.Enabled = true;
                endInvisible.Enabled = true;
                endBed.Enabled = true;
                endWarpOut.Enabled = true;
                endCoords.Enabled = true;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
        }

        private void endWarpOut_CheckedChanged(object sender, EventArgs e)
        {
            if (!endDialogue.Checked == true && !endInvisible.Checked == true)
            {
                if (endWarpOut.Checked == true)
                {
                    endDialogue.Enabled = true;
                    endInvisible.Enabled = true;
                    endBed.Enabled = false;
                    endCoords.Enabled = false;
                }
                if (endWarpOut.Checked == false)
                {
                    endDialogue.Enabled = true;
                    endInvisible.Enabled = true;
                    endBed.Enabled = true;
                    endCoords.Enabled = true;
                }

            }
            
        }

        private void endInvisible_CheckedChanged(object sender, EventArgs e)
        {
            if(endInvisible.Checked == true)
            {
                endNewDay.Enabled = false;
                endBed.Enabled = false;
                endWarpOut.Enabled = true;
                endDialogue.Enabled = false;
                endCoords.Enabled = false;
                npcList.Enabled = true;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
            if(endInvisible.Checked == false)
            {
                endNewDay.Enabled = true;
                endBed.Enabled = true;
                endWarpOut.Enabled = true;
                endCoords.Enabled = true;
                endDialogue.Enabled = true;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
            }
        }

        private void endCoords_CheckedChanged(object sender, EventArgs e)
        {
            if(endCoords.Checked == true)
            {
                endDialogue.Enabled = false;
                endInvisible.Enabled = false;
                endBed.Enabled = false;
                endWarpOut.Enabled = false;
                npcList.Enabled = false;
                endX.Enabled = true;
                endY.Enabled = true;
                dialogueBox.Enabled = false;
                endNewDay.Enabled = false;
            }
            if(endCoords.Checked == false)
            {
                endDialogue.Enabled = true;
                endInvisible.Enabled = true;
                endBed.Enabled = true;
                endWarpOut.Enabled = true;
                npcList.Enabled = false;
                endX.Enabled = false;
                endY.Enabled = false;
                dialogueBox.Enabled = false;
                endNewDay.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(specialEnd.Checked == false)
            {
                parse = "end";
            }
            if(endNewDay.Checked == true)
            {
                parse = "end newDay";
            }
            if (endBed.Checked == true)
            {
                parse = "end bed";
            }
            if(endDialogue.Checked == true && endWarpOut.Checked == false)
            {
                parse = $"end dialogue {npcList.Text} \"{dialogueBox.Text}\"";
            }
            if (endDialogue.Checked == true && endWarpOut.Checked == true)
            {
                parse = $"end dialogueWarpOut {npcList.Text} \"{dialogueBox.Text}\"";
            }
            if (endWarpOut.Checked == true && endDialogue.Checked == false || endWarpOut.Checked == true && endInvisible.Checked == true)
            {
                parse = "end warpOut";
            }
            if(endInvisible.Checked == true && endWarpOut.Checked == false)
            {
                parse = $"end invisible {npcList.Text}";
            }
            if (endInvisible.Checked == true && endWarpOut.Checked == true)
            {
                parse = $"end invisibleWarpOut {npcList.Text}";
            }
            if(endCoords.Checked == true)
            {
                parse = $"end position {endX.Value} {endY.Value}";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
