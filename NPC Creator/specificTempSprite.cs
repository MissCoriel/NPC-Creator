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
    public partial class specificTempSprite : Form
    {
        public specificTempSprite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"specificTemporarySprite {spriteList.Text} {spriteParams.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
