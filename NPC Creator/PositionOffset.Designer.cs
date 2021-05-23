namespace NPC_Creator
{
    partial class PositionOffset
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
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type NPC Name";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 34);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(163, 35);
            this.offsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(54, 20);
            this.offsetX.TabIndex = 2;
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(241, 35);
            this.offsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(54, 20);
            this.offsetY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PositionOffset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 74);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.offsetY);
            this.Controls.Add(this.offsetX);
            this.Controls.Add(this.npcList);
            this.Controls.Add(this.label1);
            this.Name = "PositionOffset";
            this.Text = "PositionOffset";
            this.Load += new System.EventHandler(this.PositionOffset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}