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
    public partial class Chance_Command : Form
    {
        public Chance_Command()
        {
            InitializeComponent();
        }

        private void addCommand_Click(object sender, EventArgs e)
        {
            double chanceDecimal = (double)chancePercentile.Value / 100;
            string parseCommand = $"$c {chanceDecimal}#";
            dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            mw.FrontRunningCommands(parseCommand);
            MessageBox.Show("Command set!\nBe sure to place a break between the chance dialogue and what will be said if failed chance.", "Command Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
