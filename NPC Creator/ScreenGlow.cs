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
    public partial class ScreenGlow : Form
    {
        public ScreenGlow()
        {
            InitializeComponent();
        }

        private void ScreenGlow_Load(object sender, EventArgs e)
        {
            colorSample.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"glow {redBar.Value} {greenBar.Value} {blueBar.Value}";
            if (checkBox1.Checked == true)
            {
                parse = parse + " true";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();


        }

        private void redBar_Scroll(object sender, EventArgs e)
        {
            redVal.Text = $"{redBar.Value}";
            colorSample.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);

        }

        private void greenBar_Scroll(object sender, EventArgs e)
        {
            greenVal.Text = $"{greenBar.Value}";
            colorSample.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);

        }

        private void blueBar_Scroll(object sender, EventArgs e)
        {
            blueVal.Text = $"{blueBar.Value}";
            colorSample.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);

        }
    }
}
