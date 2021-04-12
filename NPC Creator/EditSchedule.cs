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
    public partial class EditSchedule : Form
    {
        public EditSchedule(string editDialog)
        {
            InitializeComponent();
            editLine.Text = editDialog;
        }

        private void updateList_Click(object sender, EventArgs e)
        {
            Schedule_Dialogue mw = (Schedule_Dialogue)Application.OpenForms["Schedule_Dialogue"];
            mw.updateList(editLine.Text);
            this.Close();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
