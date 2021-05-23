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
    public partial class TimeFrame : Form
    {
        public TimeFrame()
        {
            InitializeComponent();
        }

        private void minTime_ValueChanged(object sender, EventArgs e)
        {
            int timeCreation = (int)minTime.Value / 100;
            int timeCalc = timeCreation * 100;
            int actualTime = (int)minTime.Value - timeCalc;
            //MessageBox.Show($"{timeCreation}: {actualTime}", "Time");
            if (actualTime > 50)
            {
                minTime.Value = timeCalc + 100;
                if (minTime.Value > 2600)
                {
                    minTime.Value = 2600;
                }
            }

        }

        private void maxTime_ValueChanged(object sender, EventArgs e)
        {
            int timeCreation = (int)maxTime.Value / 100;
            int timeCalc = timeCreation * 100;
            int actualTime = (int)maxTime.Value - timeCalc;
            //MessageBox.Show($"{timeCreation}: {actualTime}", "Time");
            if (actualTime > 50)
            {
                maxTime.Value = timeCalc + 100;
                if (maxTime.Value > 2600)
                {
                    maxTime.Value = 2600;
                }
            }

        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if(minTime.Value < maxTime.Value)
            {
                string parse = $"t {minTime.Value} {maxTime.Value}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }
            if(minTime.Value == maxTime.Value)
            {
                MessageBox.Show("Minimum Time and Maximum Time cannot be the same value.", "If you're on time you're late.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(minTime.Value > maxTime.Value)
            {
                MessageBox.Show("Minimum Time cannot be greater than Maximum Time!", "Back to the Future", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
