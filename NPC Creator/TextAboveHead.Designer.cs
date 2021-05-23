namespace NPC_Creator
{
    partial class TextAboveHead
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
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dialogBody = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Commit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dialogBody);
            this.groupBox2.Location = new System.Drawing.Point(1, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speech Text";
            // 
            // dialogBody
            // 
            this.dialogBody.Location = new System.Drawing.Point(12, 37);
            this.dialogBody.Name = "dialogBody";
            this.dialogBody.Size = new System.Drawing.Size(425, 20);
            this.dialogBody.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPC Speaking";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(12, 37);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 0;
            // 
            // TextAboveHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 196);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TextAboveHead";
            this.Text = "TextAboveHead";
            this.Load += new System.EventHandler(this.TextAboveHead_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dialogBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox npcList;
    }
}