namespace NPC_Creator
{
    partial class WarpNPC
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
            this.npcList = new System.Windows.Forms.ComboBox();
            this.warpX = new System.Windows.Forms.NumericUpDown();
            this.warpY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warpX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type NPC Name and Set coordinates.";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 40);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // warpX
            // 
            this.warpX.Location = new System.Drawing.Point(176, 41);
            this.warpX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.warpX.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.warpX.Name = "warpX";
            this.warpX.Size = new System.Drawing.Size(56, 20);
            this.warpX.TabIndex = 2;
            // 
            // warpY
            // 
            this.warpY.Location = new System.Drawing.Point(261, 41);
            this.warpY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.warpY.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.warpY.Name = "warpY";
            this.warpY.Size = new System.Drawing.Size(56, 20);
            this.warpY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WarpNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 121);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warpY);
            this.Controls.Add(this.warpX);
            this.Controls.Add(this.npcList);
            this.Controls.Add(this.label1);
            this.Name = "WarpNPC";
            this.Text = "WarpNPC";
            this.Load += new System.EventHandler(this.WarpNPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warpX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.NumericUpDown warpX;
        private System.Windows.Forms.NumericUpDown warpY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}