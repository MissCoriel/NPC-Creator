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
    public partial class PasteEvent : Form
    {
        public PasteEvent()
        {
            InitializeComponent();
        }

        private void Commit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(eventRaw.Text))
            {
                Event_Studio mw = (Event_Studio)Application.OpenForms["Event_Studio"];
                mw.pasteEventtoList(eventRaw.Text);
                this.Close();

            }
        }
    }
}
