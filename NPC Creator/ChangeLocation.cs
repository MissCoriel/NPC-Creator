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
    public partial class ChangeLocation : Form
    {
        public ChangeLocation()
        {
            InitializeComponent();
        }

        private void ChangeLocation_Load(object sender, EventArgs e)
        {
            locationsList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\ValidLocations.txt"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parse = $"changeLocation {locationsList.Text}";
            Conditions mw = (Conditions)Application.OpenForms["Conditions"];
            mw.addCommandtoList(parse);
            this.Close();

        }
    }
}
