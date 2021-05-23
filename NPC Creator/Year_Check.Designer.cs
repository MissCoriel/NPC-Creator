namespace NPC_Creator
{
    partial class Year_Check
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
            this.AddCommand = new System.Windows.Forms.Button();
            this.eventYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.eventYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Year will this be available. (It will be available every year after too)";
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(139, 51);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // eventYear
            // 
            this.eventYear.Location = new System.Drawing.Point(151, 25);
            this.eventYear.Name = "eventYear";
            this.eventYear.Size = new System.Drawing.Size(51, 20);
            this.eventYear.TabIndex = 3;
            // 
            // Year_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 93);
            this.ControlBox = false;
            this.Controls.Add(this.eventYear);
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.label1);
            this.Name = "Year_Check";
            this.Text = "Year_Check";
            ((System.ComponentModel.ISupportInitialize)(this.eventYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCommand;
        private System.Windows.Forms.NumericUpDown eventYear;
    }
}