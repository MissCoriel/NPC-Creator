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
    public partial class CreateTemporarySprite : Form
    {
        private double realBarValue;
        public CreateTemporarySprite()
        {
            InitializeComponent();
        }

        private void layerBr_Scroll(object sender, EventArgs e)
        {
            //convert bar value
            realBarValue = (double)layerBr.Value / 100;
            layerLabel.Text = $"Layer: {realBarValue}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"temporarySprite {spriteX.Value} {spriteY.Value} {rowInTexture.Value} {animationLength.Value} {animationInterval.Value} false {realBarValue}";
            if(flipAnimation.Checked == true)
            {
                parse = $"temporarySprite {spriteX.Value} {spriteY.Value} {rowInTexture.Value} {animationLength.Value} {animationInterval.Value} true {realBarValue}";
            }
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
