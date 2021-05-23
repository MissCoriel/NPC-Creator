namespace NPC_Creator
{
    partial class ChangeViewport
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
            this.viewX = new System.Windows.Forms.NumericUpDown();
            this.viewY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set New Viewport";
            // 
            // viewX
            // 
            this.viewX.Location = new System.Drawing.Point(31, 42);
            this.viewX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.viewX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.viewX.Name = "viewX";
            this.viewX.Size = new System.Drawing.Size(45, 20);
            this.viewX.TabIndex = 1;
            // 
            // viewY
            // 
            this.viewY.Location = new System.Drawing.Point(116, 42);
            this.viewY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.viewY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.viewY.Name = "viewY";
            this.viewY.Size = new System.Drawing.Size(45, 20);
            this.viewY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeViewport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 121);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewY);
            this.Controls.Add(this.viewX);
            this.Controls.Add(this.label1);
            this.Name = "ChangeViewport";
            this.Text = "ChangeViewport";
            ((System.ComponentModel.ISupportInitialize)(this.viewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown viewX;
        private System.Windows.Forms.NumericUpDown viewY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}