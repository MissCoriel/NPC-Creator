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
    public partial class FarmerXY : Form
    {
        public FarmerXY()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if(groupBox1.Enabled == false)
            {
                string parse = $"a {farmerX.Value} {farmerY.Value}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }
        }
    }
}
