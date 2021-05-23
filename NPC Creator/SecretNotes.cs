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
    public partial class SecretNotes : Form
    {
        public SecretNotes()
        {
            InitializeComponent();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if(secretNoteID.Value > 25 && secretNoteID.Value < 1001)
            {
                MessageBox.Show("Vanilla secret note values are 1-25 and 1001-1011.\nIf you do not intend to mod new secret notes, this may be an impossible condition.", "A secret message from the guild.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string parse = $"S {secretNoteID.Value}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addConditiontoList(parse);
            this.Close();

        }
    }
}
