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
    public partial class EditDialogue : Form
    {
        public EditDialogue(string editDialog)
        {
            InitializeComponent();
            editLine.Text = editDialog;
        }

        private void EditDialogue_Load(object sender, EventArgs e)
        {
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateList_Click(object sender, EventArgs e)
        {
            dialogueBoutique mw = (dialogueBoutique)Application.OpenForms["dialogueBoutique"];
            mw.updateList(editLine.Text);
            this.Close();
        }
    }
}
