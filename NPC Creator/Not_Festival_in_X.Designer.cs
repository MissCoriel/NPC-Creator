namespace NPC_Creator
{
    partial class Not_Festival_in_X
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
            this.dayCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many days from today can the Festival not be in?";
            // 
            // dayCount
            // 
            this.dayCount.Location = new System.Drawing.Point(39, 35);
            this.dayCount.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.dayCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayCount.Name = "dayCount";
            this.dayCount.Size = new System.Drawing.Size(43, 20);
            this.dayCount.TabIndex = 1;
            this.dayCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Days";
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(150, 32);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 3;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // Not_Festival_in_X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 80);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayCount);
            this.Controls.Add(this.label1);
            this.Name = "Not_Festival_in_X";
            this.Text = "Not_Festival_in_X";
            ((System.ComponentModel.ISupportInitialize)(this.dayCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dayCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCommand;
    }
}