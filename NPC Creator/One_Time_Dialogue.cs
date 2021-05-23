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
    public partial class One_Time_Dialogue : Form
    {
        public One_Time_Dialogue()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"$1 {mailID.Text}#{oneTime.Text}#$e#{otherwiseDialog.Text}";
            dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            mw.FrontRunningCommands(parse);
            this.Close();
        }
    }
}
