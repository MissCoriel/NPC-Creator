namespace NPC_Creator
{
    partial class Do_Action
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
            this.exitX = new System.Windows.Forms.NumericUpDown();
            this.exitY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitY)).BeginInit();
            this.SuspendLayout();
            // 
            // exitX
            // 
            this.exitX.Location = new System.Drawing.Point(32, 69);
            this.exitX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.exitX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.exitX.Name = "exitX";
            this.exitX.Size = new System.Drawing.Size(70, 20);
            this.exitX.TabIndex = 0;
            // 
            // exitY
            // 
            this.exitY.Location = new System.Drawing.Point(133, 69);
            this.exitY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.exitY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.exitY.Name = "exitY";
            this.exitY.Size = new System.Drawing.Size(70, 20);
            this.exitY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Coordinates to Do the Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Do_Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 157);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitY);
            this.Controls.Add(this.exitX);
            this.Name = "Do_Action";
            this.Text = "Do_Action";
            ((System.ComponentModel.ISupportInitialize)(this.exitX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown exitX;
        private System.Windows.Forms.NumericUpDown exitY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}