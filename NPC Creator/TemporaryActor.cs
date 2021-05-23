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
    public partial class TemporaryActor : Form
    {
        public string breathing;
        public TemporaryActor()
        {
            InitializeComponent();
        }

        private void TemporaryActor_Load(object sender, EventArgs e)
        {

        }


        private void isBreathing_CheckedChanged(object sender, EventArgs e)
        {
            if(isBreathing.Checked == true)
            {
                breathing = "true";
            }
            else
            {
                breathing = "false";
            }
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            string parse = $"addTemoraryActor {actorName.Text} {dimX.Value} {dimY.Value} {actorX.Value} {actorY.Value} {actorFacing.Value} {breathing}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
