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
    public partial class Dialogue_Prerequisite : Form
    {
        public Dialogue_Prerequisite()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"$p {responseID.Value}#{dialogTrue.Text}|{dialogFalse.Text}";
            dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            mw.FrontRunningCommands(parse);
            this.Close();
        }
    }
}
