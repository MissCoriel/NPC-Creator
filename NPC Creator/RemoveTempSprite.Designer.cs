namespace NPC_Creator
{
    partial class RemoveTempSprite
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
            this.spriteX = new System.Windows.Forms.NumericUpDown();
            this.spriteY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Coordinates for Temporary Sprite";
            // 
            // spriteX
            // 
            this.spriteX.Location = new System.Drawing.Point(30, 47);
            this.spriteX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spriteX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.spriteX.Name = "spriteX";
            this.spriteX.Size = new System.Drawing.Size(59, 20);
            this.spriteX.TabIndex = 1;
            // 
            // spriteY
            // 
            this.spriteY.Location = new System.Drawing.Point(128, 47);
            this.spriteY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spriteY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.spriteY.Name = "spriteY";
            this.spriteY.Size = new System.Drawing.Size(59, 20);
            this.spriteY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveTempSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spriteY);
            this.Controls.Add(this.spriteX);
            this.Controls.Add(this.label1);
            this.Name = "RemoveTempSprite";
            this.Text = "RemoveTempSprite";
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spriteX;
        private System.Windows.Forms.NumericUpDown spriteY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}