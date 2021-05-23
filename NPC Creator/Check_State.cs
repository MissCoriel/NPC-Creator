using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class Check_State : Form
    {
        public Check_State()
        {
            InitializeComponent();
        }

        private void Check_State_Load(object sender, EventArgs e)
        {

        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parameter = "";
            if(stateList.Text == "Bus is repaired")
            {
                parameter = "bus";
            }
            if (stateList.Text == "Joja Mart is still in business")
            {
                parameter = "joja";
            }
            if (stateList.Text == "Community Center is Complete")
            {
                parameter = "cc";
            }
            if(stateList.Text == "Kent has Returned")
            {
                parameter = "kent";
            }
            string assembledDialogue = $"$d {parameter}#{trueDialog.Text}|{falseDialog.Text}";
            dialogueBoutique parse = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            parse.FrontRunningCommands(assembledDialogue);
            this.Close();
        }
    }
}
