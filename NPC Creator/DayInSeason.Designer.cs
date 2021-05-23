namespace NPC_Creator
{
    partial class DayInSeason
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
            this.seasonDay = new System.Windows.Forms.NumericUpDown();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seasonDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What day in the season will this event be available?";
            // 
            // seasonDay
            // 
            this.seasonDay.Location = new System.Drawing.Point(71, 34);
            this.seasonDay.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.seasonDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seasonDay.Name = "seasonDay";
            this.seasonDay.Size = new System.Drawing.Size(120, 20);
            this.seasonDay.TabIndex = 1;
            this.seasonDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(93, 70);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // DayInSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 108);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.seasonDay);
            this.Controls.Add(this.label1);
            this.Name = "DayInSeason";
            this.Text = "DayInSeason";
            ((System.ComponentModel.ISupportInitialize)(this.seasonDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown seasonDay;
        private System.Windows.Forms.Button AddCommand;
    }
}