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
    public partial class WeatherCondition : Form
    {
        string weather;
        public WeatherCondition()
        {
            InitializeComponent();
        }

        private void sunnyDay_CheckedChanged(object sender, EventArgs e)
        {
            if(sunnyDay.Checked == true)
            {
                rainyDay.Checked = false;
                weather = "sunny";
            }
            
        }

        private void rainyDay_CheckedChanged(object sender, EventArgs e)
        {
            if(rainyDay.Checked == true)
            {
                sunnyDay.Checked = false;
                weather = "rainy";
            }
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            string parse = $"w {weather}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
