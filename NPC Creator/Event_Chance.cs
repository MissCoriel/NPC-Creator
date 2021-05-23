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
    public partial class Event_Chance : Form
    {
        public Event_Chance()
        {
            InitializeComponent();
        }

        private void addCommand_Click(object sender, EventArgs e)
        {
            double percentileConvert = (double)percentChance.Value / 100;
            string parse = $"r {percentileConvert}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
