﻿using System;
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
    public partial class NotMarriedToNPC : Form
    {
        public NotMarriedToNPC()
        {
            InitializeComponent();
        }

        private void NotMarriedToNPC_Load(object sender, EventArgs e)
        {
            npcList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + "\\Common Data\\NPCNames.txt"));
            npcList.Items.Remove("Jas");
            npcList.Items.Remove("Vincent");
            npcList.Items.Remove("Leo");
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            if (npcList.Text == "Jas" || npcList.Text == "Vincent" || npcList.Text == "Leo")
            {
                MessageBox.Show("This Mod tool does not allow Child Marriage or Dating.\nYou are unable to use Jas, Vincent, or Leo", "Calling Dateline NPC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                npcList.Text = "";
            }
            else
            {
                string parse = $"o {npcList.Text}";
                Conditions mw = (Conditions)Application.OpenForms["Conditions"];
                mw.addConditiontoList(parse);
                this.Close();

            }
        }
    }
}
