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
    public partial class MakeInvisible : Form
    {
        public MakeInvisible()
        {
            InitializeComponent();
        }

        private void areaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(areaCheck.Checked == true)
            {
                areaX.Enabled = true;
                areaY.Enabled = true;
            }
            if(areaCheck.Checked == false)
            {
                areaX.Enabled = false;
                areaY.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"makeInvisible {originX.Value} {originY.Value}";
            if (areaCheck.Checked == true)
            {
                parse = $"makeInvisible {originX.Value} {originY.Value} {areaX.Value} {areaY.Value}";
            }
            if(areaCheck.Checked == false)
            {
                parse = $"makeInvisible {originX.Value} {originY.Value}";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
