namespace NPC_Creator
{
    partial class RemoveProp
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
            this.propX = new System.Windows.Forms.NumericUpDown();
            this.propY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.propX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Coordinates of the Prop to Remove";
            // 
            // propX
            // 
            this.propX.Location = new System.Drawing.Point(29, 43);
            this.propX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.propX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.propX.Name = "propX";
            this.propX.Size = new System.Drawing.Size(61, 20);
            this.propX.TabIndex = 1;
            // 
            // propY
            // 
            this.propY.Location = new System.Drawing.Point(136, 43);
            this.propY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.propY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.propY.Name = "propY";
            this.propY.Size = new System.Drawing.Size(61, 20);
            this.propY.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // RemoveProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 124);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propY);
            this.Controls.Add(this.propX);
            this.Controls.Add(this.label1);
            this.Name = "RemoveProp";
            this.Text = "RemoveProp";
            ((System.ComponentModel.ISupportInitialize)(this.propX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown propX;
        private System.Windows.Forms.NumericUpDown propY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}