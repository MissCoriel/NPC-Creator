namespace NPC_Creator
{
    partial class WeatherCondition
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
            this.sunnyDay = new System.Windows.Forms.RadioButton();
            this.rainyDay = new System.Windows.Forms.RadioButton();
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which weather will the event activate on?";
            // 
            // sunnyDay
            // 
            this.sunnyDay.AutoSize = true;
            this.sunnyDay.Location = new System.Drawing.Point(15, 37);
            this.sunnyDay.Name = "sunnyDay";
            this.sunnyDay.Size = new System.Drawing.Size(55, 17);
            this.sunnyDay.TabIndex = 1;
            this.sunnyDay.TabStop = true;
            this.sunnyDay.Text = "Sunny";
            this.sunnyDay.UseVisualStyleBackColor = true;
            this.sunnyDay.CheckedChanged += new System.EventHandler(this.sunnyDay_CheckedChanged);
            // 
            // rainyDay
            // 
            this.rainyDay.AutoSize = true;
            this.rainyDay.Location = new System.Drawing.Point(157, 37);
            this.rainyDay.Name = "rainyDay";
            this.rainyDay.Size = new System.Drawing.Size(61, 17);
            this.rainyDay.TabIndex = 2;
            this.rainyDay.TabStop = true;
            this.rainyDay.Text = "Raining";
            this.rainyDay.UseVisualStyleBackColor = true;
            this.rainyDay.CheckedChanged += new System.EventHandler(this.rainyDay_CheckedChanged);
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(74, 68);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 3;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // WeatherCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 101);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.rainyDay);
            this.Controls.Add(this.sunnyDay);
            this.Controls.Add(this.label1);
            this.Name = "WeatherCondition";
            this.Text = "WeatherCondition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sunnyDay;
        private System.Windows.Forms.RadioButton rainyDay;
        private System.Windows.Forms.Button AddCommand;
    }
}