namespace NPC_Creator
{
    partial class Check_State
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
            this.stateList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trueDialog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.falseDialog = new System.Windows.Forms.TextBox();
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What should we check for?";
            // 
            // stateList
            // 
            this.stateList.FormattingEnabled = true;
            this.stateList.Items.AddRange(new object[] {
            "Bus is repaired",
            "Joja Mart is still in business",
            "Community Center is Complete",
            "Kent has Returned"});
            this.stateList.Location = new System.Drawing.Point(15, 36);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(121, 21);
            this.stateList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dialogue if True:";
            // 
            // trueDialog
            // 
            this.trueDialog.Location = new System.Drawing.Point(15, 109);
            this.trueDialog.Name = "trueDialog";
            this.trueDialog.Size = new System.Drawing.Size(640, 20);
            this.trueDialog.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dialogue if False:";
            // 
            // falseDialog
            // 
            this.falseDialog.Location = new System.Drawing.Point(15, 191);
            this.falseDialog.Name = "falseDialog";
            this.falseDialog.Size = new System.Drawing.Size(640, 20);
            this.falseDialog.TabIndex = 5;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(279, 252);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 6;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // Check_State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 287);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.falseDialog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trueDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stateList);
            this.Controls.Add(this.label1);
            this.Name = "Check_State";
            this.Text = "Check State";
            this.Load += new System.EventHandler(this.Check_State_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stateList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trueDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox falseDialog;
        private System.Windows.Forms.Button AddCommand;
    }
}