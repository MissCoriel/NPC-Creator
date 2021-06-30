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
    public partial class ChangeToTempMap : Form
    {
        int pan;
        public ChangeToTempMap()
        {
            InitializeComponent();
        }

        private void panCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"changeToTemporaryMap {textBox1.Text}";
            if(panCheck.Checked == true)
            {
                parse = parse + " 1";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
