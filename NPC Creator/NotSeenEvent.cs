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
    public partial class NotSeenEvent : Form
    {
        List<string> evenCollection = new List<string>();
        public NotSeenEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            eventList.Items.Add(eventID.Value);
            eventID.Value = 0;
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            eventList.Items.Remove(eventList.SelectedItem);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            eventList.Items.Clear();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            foreach(var item in eventList.Items)
            {
                string entry = item.ToString();
                evenCollection.Add(entry);
            }
            string parse = "k " + string.Join(" ", evenCollection);
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
