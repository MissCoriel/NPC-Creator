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
    public partial class MailALetterInterface : Form
    {
        public MailALetterInterface()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(letterID.Text))
            {
                string parse = $"x {letterID.Text}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();
                mw.addCommandtoList("null");
                MessageBox.Show("The Event Command section has a null command.\nThis is necessary and you should not add any event commands after.", "Event Complete!", MessageBoxButtons.OK);
            }
        }
    }
}
