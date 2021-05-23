namespace NPC_Creator
{
    partial class Dialogue_File_Without_Project
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
            this.dialogName = new System.Windows.Forms.TextBox();
            this.commitName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before you begin, You must give a name so NPC Creator can Parse certain data:";
            // 
            // dialogName
            // 
            this.dialogName.Location = new System.Drawing.Point(134, 35);
            this.dialogName.Name = "dialogName";
            this.dialogName.Size = new System.Drawing.Size(139, 20);
            this.dialogName.TabIndex = 1;
            // 
            // commitName
            // 
            this.commitName.Location = new System.Drawing.Point(167, 71);
            this.commitName.Name = "commitName";
            this.commitName.Size = new System.Drawing.Size(75, 23);
            this.commitName.TabIndex = 2;
            this.commitName.Text = "Begin";
            this.commitName.UseVisualStyleBackColor = true;
            this.commitName.Click += new System.EventHandler(this.commitName_Click);
            // 
            // Dialogue_File_Without_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 106);
            this.ControlBox = false;
            this.Controls.Add(this.commitName);
            this.Controls.Add(this.dialogName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Dialogue_File_Without_Project";
            this.Text = "Start Dialogue Without Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dialogName;
        private System.Windows.Forms.Button commitName;
    }
}