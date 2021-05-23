namespace NPC_Creator
{
    partial class Dialogue_Prerequisite
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
            this.responseID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dialogTrue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dialogFalse = new System.Windows.Forms.TextBox();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.responseID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the Response ID to look for?";
            // 
            // responseID
            // 
            this.responseID.Location = new System.Drawing.Point(15, 36);
            this.responseID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.responseID.Name = "responseID";
            this.responseID.Size = new System.Drawing.Size(120, 20);
            this.responseID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dialogue if Found:";
            // 
            // dialogTrue
            // 
            this.dialogTrue.Location = new System.Drawing.Point(15, 98);
            this.dialogTrue.Name = "dialogTrue";
            this.dialogTrue.Size = new System.Drawing.Size(506, 20);
            this.dialogTrue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dialogue if not Found:";
            // 
            // dialogFalse
            // 
            this.dialogFalse.Location = new System.Drawing.Point(15, 166);
            this.dialogFalse.Name = "dialogFalse";
            this.dialogFalse.Size = new System.Drawing.Size(506, 20);
            this.dialogFalse.TabIndex = 5;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(232, 215);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 6;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // Dialogue_Prerequisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 264);
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.dialogFalse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dialogTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.responseID);
            this.Controls.Add(this.label1);
            this.Name = "Dialogue_Prerequisite";
            this.Text = "Dialogue Prerequisite ($p)";
            ((System.ComponentModel.ISupportInitialize)(this.responseID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown responseID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dialogTrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dialogFalse;
        private System.Windows.Forms.Button AddCommand;
    }
}