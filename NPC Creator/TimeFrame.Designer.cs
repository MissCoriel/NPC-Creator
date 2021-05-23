namespace NPC_Creator
{
    partial class TimeFrame
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
            this.label2 = new System.Windows.Forms.Label();
            this.minTime = new System.Windows.Forms.NumericUpDown();
            this.maxTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the Time Frame for this Event?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum Time";
            // 
            // minTime
            // 
            this.minTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minTime.Location = new System.Drawing.Point(15, 70);
            this.minTime.Maximum = new decimal(new int[] {
            2600,
            0,
            0,
            0});
            this.minTime.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.minTime.Name = "minTime";
            this.minTime.Size = new System.Drawing.Size(50, 20);
            this.minTime.TabIndex = 2;
            this.minTime.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.minTime.ValueChanged += new System.EventHandler(this.minTime_ValueChanged);
            // 
            // maxTime
            // 
            this.maxTime.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxTime.Location = new System.Drawing.Point(152, 70);
            this.maxTime.Maximum = new decimal(new int[] {
            2600,
            0,
            0,
            0});
            this.maxTime.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.maxTime.Name = "maxTime";
            this.maxTime.Size = new System.Drawing.Size(50, 20);
            this.maxTime.TabIndex = 3;
            this.maxTime.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.maxTime.ValueChanged += new System.EventHandler(this.maxTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Time";
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(70, 116);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 5;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // TimeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 149);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxTime);
            this.Controls.Add(this.minTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeFrame";
            this.Text = "TimeFrame";
            ((System.ComponentModel.ISupportInitialize)(this.minTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minTime;
        private System.Windows.Forms.NumericUpDown maxTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddCommand;
    }
}