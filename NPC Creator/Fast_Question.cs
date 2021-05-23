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
    public partial class Fast_Question : Form
    {
        public Fast_Question()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"$y '{question.Text}_{firstAnswer.Text}_{firstResponse.Text}_{secondAnswer.Text}_{secondResponse.Text}'";
            dialogueBoutique command = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            command.FrontRunningCommands(parse);
            this.Close();
        }
    }
}
