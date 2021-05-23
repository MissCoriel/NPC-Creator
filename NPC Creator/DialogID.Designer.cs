namespace NPC_Creator
{
    partial class DialogID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dialogSelect = new System.Windows.Forms.ComboBox();
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type in the Dialogue ID.";
            // 
            // dialogSelect
            // 
            this.dialogSelect.FormattingEnabled = true;
            this.dialogSelect.Items.AddRange(new object[] {
            "cc_Begin",
            "cc_Boulder",
            "cc_Bridge",
            "cc_Bus",
            "cc_Complete",
            "cc_Greenhouse",
            "cc_Minecart",
            "dumped_Girls",
            "dumped_Guys",
            "Introduction",
            "joja_Begin",
            "pamHouseUpgrade",
            "pamHouseUpgradeAnonymous",
            "secondChance_Girls",
            "secondChance_Guys",
            "shaneSaloon1",
            "shaneSaloon2",
            "willyCrabs"});
            this.dialogSelect.Location = new System.Drawing.Point(15, 37);
            this.dialogSelect.Name = "dialogSelect";
            this.dialogSelect.Size = new System.Drawing.Size(163, 21);
            this.dialogSelect.TabIndex = 1;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(56, 69);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // DialogID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 104);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.dialogSelect);
            this.Controls.Add(this.label1);
            this.Name = "DialogID";
            this.Text = "DialogID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dialogSelect;
        private System.Windows.Forms.Button AddCommand;
    }
}