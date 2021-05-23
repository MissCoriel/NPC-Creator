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
    public partial class MoveViewport : Form
    {
        public MoveViewport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"viewport move {panX.Value} {panY.Value} {waitTime.Value}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
