namespace NPC_Creator
{
    partial class Chance_Command
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
            this.chancePercentile = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.addCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chancePercentile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the odds of this happening?";
            // 
            // chancePercentile
            // 
            this.chancePercentile.Location = new System.Drawing.Point(65, 23);
            this.chancePercentile.Name = "chancePercentile";
            this.chancePercentile.Size = new System.Drawing.Size(50, 20);
            this.chancePercentile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // addCommand
            // 
            this.addCommand.Location = new System.Drawing.Point(51, 49);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(75, 23);
            this.addCommand.TabIndex = 3;
            this.addCommand.Text = "Commit";
            this.addCommand.UseVisualStyleBackColor = true;
            this.addCommand.Click += new System.EventHandler(this.addCommand_Click);
            // 
            // Chance_Command
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 81);
            this.ControlBox = false;
            this.Controls.Add(this.addCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chancePercentile);
            this.Controls.Add(this.label1);
            this.Name = "Chance_Command";
            this.Text = "Chance Command";
            ((System.ComponentModel.ISupportInitialize)(this.chancePercentile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown chancePercentile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCommand;
    }
}