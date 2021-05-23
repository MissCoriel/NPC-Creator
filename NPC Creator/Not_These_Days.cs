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
    
    public partial class Not_These_Days : Form
    {
        public List<string> dayListCollection = new List<string>();
        public Not_These_Days()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            foreach(var item in dayList.CheckedItems)
            {
                string day = item.ToString();
                if (day == "Monday")
                    day = "Mon";
                if (day == "Tuesday")
                    day = "Tue";
                if (day == "Wednesday")
                    day = "Wed";
                if (day == "Thursday")
                    day = "Thu";
                if (day == "Friday")
                    day = "Fri";
                if (day == "Saturday")
                    day = "Sat";
                if (day == "Sunday")
                    day = "Sun";
                dayListCollection.Add(day);

            }
            string parse = "d " + string.Join(" ", dayListCollection);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
