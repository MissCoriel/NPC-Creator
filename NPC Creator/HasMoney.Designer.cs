namespace NPC_Creator
{
    partial class HasMoney
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
            this.moneyAmount = new System.Windows.Forms.NumericUpDown();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much Money does the Farmer need to have?";
            // 
            // moneyAmount
            // 
            this.moneyAmount.Location = new System.Drawing.Point(70, 34);
            this.moneyAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.Size = new System.Drawing.Size(120, 20);
            this.moneyAmount.TabIndex = 1;
            this.moneyAmount.ThousandsSeparator = true;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(94, 77);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // HasMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 112);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.moneyAmount);
            this.Controls.Add(this.label1);
            this.Name = "HasMoney";
            this.Text = "HasMoney";
            ((System.ComponentModel.ISupportInitialize)(this.moneyAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown moneyAmount;
        private System.Windows.Forms.Button AddCommand;
    }
}