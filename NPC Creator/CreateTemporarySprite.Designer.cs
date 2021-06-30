namespace NPC_Creator
{
    partial class CreateTemporarySprite
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
            this.rowInTexture = new System.Windows.Forms.NumericUpDown();
            this.animationLength = new System.Windows.Forms.NumericUpDown();
            this.animationInterval = new System.Windows.Forms.NumericUpDown();
            this.flipAnimation = new System.Windows.Forms.CheckBox();
            this.layerBr = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.layerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowInTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerBr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter all Parameters";
            // 
            // spriteX
            // 
            this.spriteX.Location = new System.Drawing.Point(32, 52);
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
            this.spriteX.Size = new System.Drawing.Size(81, 20);
            this.spriteX.TabIndex = 1;
            // 
            // spriteY
            // 
            this.spriteY.Location = new System.Drawing.Point(155, 52);
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
            this.spriteY.Size = new System.Drawing.Size(81, 20);
            this.spriteY.TabIndex = 2;
            // 
            // rowInTexture
            // 
            this.rowInTexture.Location = new System.Drawing.Point(286, 52);
            this.rowInTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.rowInTexture.Name = "rowInTexture";
            this.rowInTexture.Size = new System.Drawing.Size(120, 20);
            this.rowInTexture.TabIndex = 3;
            // 
            // animationLength
            // 
            this.animationLength.Location = new System.Drawing.Point(56, 128);
            this.animationLength.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.animationLength.Name = "animationLength";
            this.animationLength.Size = new System.Drawing.Size(120, 20);
            this.animationLength.TabIndex = 4;
            // 
            // animationInterval
            // 
            this.animationInterval.Location = new System.Drawing.Point(249, 128);
            this.animationInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.animationInterval.Name = "animationInterval";
            this.animationInterval.Size = new System.Drawing.Size(120, 20);
            this.animationInterval.TabIndex = 5;
            // 
            // flipAnimation
            // 
            this.flipAnimation.AutoSize = true;
            this.flipAnimation.Location = new System.Drawing.Point(166, 97);
            this.flipAnimation.Name = "flipAnimation";
            this.flipAnimation.Size = new System.Drawing.Size(91, 17);
            this.flipAnimation.TabIndex = 6;
            this.flipAnimation.Text = "Flip Animation";
            this.flipAnimation.UseVisualStyleBackColor = true;
            // 
            // layerBr
            // 
            this.layerBr.Location = new System.Drawing.Point(15, 181);
            this.layerBr.Maximum = 100;
            this.layerBr.Name = "layerBr";
            this.layerBr.Size = new System.Drawing.Size(374, 45);
            this.layerBr.TabIndex = 7;
            this.layerBr.TickFrequency = 10;
            this.layerBr.Scroll += new System.EventHandler(this.layerBr_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Row:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Interval:";
            // 
            // layerLabel
            // 
            this.layerLabel.AutoSize = true;
            this.layerLabel.Location = new System.Drawing.Point(395, 192);
            this.layerLabel.Name = "layerLabel";
            this.layerLabel.Size = new System.Drawing.Size(45, 13);
            this.layerLabel.TabIndex = 13;
            this.layerLabel.Text = "Layer: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateTemporarySprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.layerLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.layerBr);
            this.Controls.Add(this.flipAnimation);
            this.Controls.Add(this.animationInterval);
            this.Controls.Add(this.animationLength);
            this.Controls.Add(this.rowInTexture);
            this.Controls.Add(this.spriteY);
            this.Controls.Add(this.spriteX);
            this.Controls.Add(this.label1);
            this.Name = "CreateTemporarySprite";
            this.Text = "CreateTemporarySprite";
            ((System.ComponentModel.ISupportInitialize)(this.spriteX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowInTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layerBr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spriteX;
        private System.Windows.Forms.NumericUpDown spriteY;
        private System.Windows.Forms.NumericUpDown rowInTexture;
        private System.Windows.Forms.NumericUpDown animationLength;
        private System.Windows.Forms.NumericUpDown animationInterval;
        private System.Windows.Forms.CheckBox flipAnimation;
        private System.Windows.Forms.TrackBar layerBr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label layerLabel;
        private System.Windows.Forms.Button button1;
    }
}