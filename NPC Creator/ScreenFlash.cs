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
    public partial class ScreenFlash : Form
    {
        public ScreenFlash()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            liveLabel.Text = $"{trackBar1.Value}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double trueValue = trackBar1.Value * .01;
            string parse = $"screenFlash {trueValue}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
