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
    public partial class Dialogue_File_Without_Project : Form
    {
        public Dialogue_File_Without_Project()
        {
            InitializeComponent();
        }

        private void commitName_Click(object sender, EventArgs e)
        {
            Form check = Application.OpenForms["scheduleStudio"];
            if (check == null)
            {
                dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
                mw.DialogIndependant(dialogName.Text);
                this.Close();

            }
            else
            {
                scheduleStudio mw = (scheduleStudio)Application.OpenForms["scheduleStudio"];
                mw.DialogIndependant(dialogName.Text);
                this.Close();

            }
        }
    }
}
