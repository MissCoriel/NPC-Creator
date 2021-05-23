using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator
{
    public partial class Choose_Season : Form
    {
        public Choose_Season()
        {
            InitializeComponent();
        }

        private void Choose_Season_Load(object sender, EventArgs e)
        {
            seasonList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\seasons.txt"));
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(seasonList.Text))
            {
                MessageBox.Show("You need to select a season!", "Is is hot in here?  Or just me?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string parse = $"z {seasonList.Text}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }
        }
    }
}
