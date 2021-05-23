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
    public partial class NotSeenMail : Form
    {
        public NotSeenMail()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"l {mailID.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
