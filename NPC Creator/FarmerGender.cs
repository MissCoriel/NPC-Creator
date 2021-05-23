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
    public partial class FarmerGender : Form
    {
        public FarmerGender()
        {
            InitializeComponent();
        }

        private void AddMale_Click(object sender, EventArgs e)
        {
            string parse = "g male";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }

        private void AddFemale_Click(object sender, EventArgs e)
        {
            string parse = "g female";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
