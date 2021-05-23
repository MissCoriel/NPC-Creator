namespace NPC_Creator
{
    partial class NotSeenMail
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
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Mail ID did the Farmer not see?";
            // 
            // mailID
            // 
            this.mailID.Location = new System.Drawing.Point(52, 37);
            this.mailID.Name = "mailID";
            this.mailID.Size = new System.Drawing.Size(100, 20);
            this.mailID.TabIndex = 1;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(64, 63);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // NotSeenMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 94);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.mailID);
            this.Controls.Add(this.label1);
            this.Name = "NotSeenMail";
            this.Text = "NotSeenMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailID;
        private System.Windows.Forms.Button AddCommand;
    }
}