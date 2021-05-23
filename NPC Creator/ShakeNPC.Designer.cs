namespace NPC_Creator
{
    partial class ShakeNPC
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
            this.shakeDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shakeDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select NPC and for how long they will shake.";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 37);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // shakeDuration
            // 
            this.shakeDuration.Location = new System.Drawing.Point(167, 37);
            this.shakeDuration.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.shakeDuration.Name = "shakeDuration";
            this.shakeDuration.Size = new System.Drawing.Size(104, 20);
            this.shakeDuration.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShakeNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 118);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shakeDuration);
            this.Controls.Add(this.npcList);
            this.Controls.Add(this.label1);
            this.Name = "ShakeNPC";
            this.Text = "ShakeNPC";
            this.Load += new System.EventHandler(this.ShakeNPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shakeDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.NumericUpDown shakeDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}