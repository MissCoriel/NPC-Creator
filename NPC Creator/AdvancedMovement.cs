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
    public partial class AdvancedMovement : Form
    {
        List<string> movementData = new List<string>();
        public string loopMove = "false";
        public AdvancedMovement()
        {
            InitializeComponent();
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
            if(moveY.Value != 0)
            {
                moveX.Enabled = false;
            }
            if(moveY.Value == 0)
            {
                moveX.Enabled = true;
            }

        }

        private void AdvancedMovement_Load(object sender, EventArgs e)
        {
            if(File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"));
                npcList.Items.Remove("farmer");
            }
            if(!File.Exists(Environment.CurrentDirectory + "\\Save Data\\TempEventInformation\\tempEventActorData.txt"))
            {
                npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));

            }


        }

        private void AddtoList_Click(object sender, EventArgs e)
        {
            string command = $"{moveX.Value} {moveY.Value}";
            movementData.Add(command);
            movementList.Items.Add(command);
            moveX.Value = 0;
            moveY.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movementData.Remove(movementList.SelectedItem.ToString());
            movementList.Items.Remove(movementList.SelectedItem);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            movementList.Items.Clear();
            movementData.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(movementList.Items.Count != 0)
            {
                string parse = $"advancedMove {npcList.Text} {loopMove} " + string.Join(" ", movementData);
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addCommandtoList(parse);
                this.Close();

            }
            else
            {
                MessageBox.Show("You have no movements in the list!", "Advanced Move.. to Nowhere!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                loopMove = "true";
            }
            if(checkBox1.Checked == false)
            {
                loopMove = "false";
            }
        }
    }
}
