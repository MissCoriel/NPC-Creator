namespace NPC_Creator
{
    partial class ModifyFP
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
            this.modifyFriendship = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modifyFriendship)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add or Subtract Friendship Points";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(15, 34);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // modifyFriendship
            // 
            this.modifyFriendship.Location = new System.Drawing.Point(173, 35);
            this.modifyFriendship.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.modifyFriendship.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            -2147483648});
            this.modifyFriendship.Name = "modifyFriendship";
            this.modifyFriendship.Size = new System.Drawing.Size(76, 20);
            this.modifyFriendship.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyFP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 119);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modifyFriendship);
            this.Controls.Add(this.npcList);
            this.Controls.Add(this.label1);
            this.Name = "ModifyFP";
            this.Text = "ModifyFP";
            this.Load += new System.EventHandler(this.ModifyFP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifyFriendship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.NumericUpDown modifyFriendship;
        private System.Windows.Forms.Button button1;
    }
}