namespace NPC_Creator
{
    partial class MoveViewport
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
            this.panX = new System.Windows.Forms.NumericUpDown();
            this.panY = new System.Windows.Forms.NumericUpDown();
            this.waitTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set panning steps.";
            // 
            // panX
            // 
            this.panX.Location = new System.Drawing.Point(40, 57);
            this.panX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.panX.Name = "panX";
            this.panX.Size = new System.Drawing.Size(49, 20);
            this.panX.TabIndex = 1;
            // 
            // panY
            // 
            this.panY.Location = new System.Drawing.Point(127, 57);
            this.panY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.panY.Name = "panY";
            this.panY.Size = new System.Drawing.Size(49, 20);
            this.panY.TabIndex = 2;
            // 
            // waitTime
            // 
            this.waitTime.Location = new System.Drawing.Point(217, 57);
            this.waitTime.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.waitTime.Name = "waitTime";
            this.waitTime.Size = new System.Drawing.Size(82, 20);
            this.waitTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "for";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveViewport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 140);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.waitTime);
            this.Controls.Add(this.panY);
            this.Controls.Add(this.panX);
            this.Controls.Add(this.label1);
            this.Name = "MoveViewport";
            this.Text = "MoveViewport";
            ((System.ComponentModel.ISupportInitialize)(this.panX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown panX;
        private System.Windows.Forms.NumericUpDown panY;
        private System.Windows.Forms.NumericUpDown waitTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}