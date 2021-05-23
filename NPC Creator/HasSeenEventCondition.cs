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
    public partial class HasSeenEventCondition : Form
    {
        List<string> eventCollection = new List<string>();
        public HasSeenEventCondition()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            foreach (var item in eventList.Items)
            {
                string entry = item.ToString();
                eventCollection.Add(entry);
            }
            string parse = "e " + string.Join(" ", eventCollection);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            eventList.Items.Add(eventID.Value);
            eventID.Value = 0;
        }

        private void DelSelected_Click(object sender, EventArgs e)
        {
            eventList.Items.Remove(eventList.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            eventList.Items.Clear();
        }
    }
}
