namespace NPC_Creator
{
    partial class One_Time_Dialogue
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
            this.mailID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oneTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otherwiseDialog = new System.Windows.Forms.TextBox();
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give this an ID (This can be used in event preconditions as a Mail ID):";
            // 
            // mailID
            // 
            this.mailID.Location = new System.Drawing.Point(15, 25);
            this.mailID.Name = "mailID";
            this.mailID.Size = new System.Drawing.Size(100, 20);
            this.mailID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "One-time dialogue:";
            // 
            // oneTime
            // 
            this.oneTime.Location = new System.Drawing.Point(15, 92);
            this.oneTime.Name = "oneTime";
            this.oneTime.Size = new System.Drawing.Size(624, 20);
            this.oneTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Otherwise, show this Dialogue:";
            // 
            // otherwiseDialog
            // 
            this.otherwiseDialog.Location = new System.Drawing.Point(15, 169);
            this.otherwiseDialog.Name = "otherwiseDialog";
            this.otherwiseDialog.Size = new System.Drawing.Size(624, 20);
            this.otherwiseDialog.TabIndex = 5;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(274, 218);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 6;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // One_Time_Dialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 257);
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.otherwiseDialog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oneTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailID);
            this.Controls.Add(this.label1);
            this.Name = "One_Time_Dialogue";
            this.Text = "One Time Dialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oneTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otherwiseDialog;
        private System.Windows.Forms.Button AddCommand;
    }
}