namespace NPC_Creator
{
    partial class FriendshipPoints
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.npcList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heartAmount = new System.Windows.Forms.NumericUpDown();
            this.AddtoList = new System.Windows.Forms.Button();
            this.npcDatum = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddCommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heartAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete all Data before adding.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddtoList);
            this.groupBox1.Controls.Add(this.heartAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.npcList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NPC Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select or Type NPC name";
            // 
            // npcList
            // 
            this.npcList.FormattingEnabled = true;
            this.npcList.Location = new System.Drawing.Point(9, 59);
            this.npcList.Name = "npcList";
            this.npcList.Size = new System.Drawing.Size(121, 21);
            this.npcList.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "How many Hearts?";
            // 
            // heartAmount
            // 
            this.heartAmount.Location = new System.Drawing.Point(219, 59);
            this.heartAmount.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.heartAmount.Name = "heartAmount";
            this.heartAmount.Size = new System.Drawing.Size(41, 20);
            this.heartAmount.TabIndex = 3;
            // 
            // AddtoList
            // 
            this.AddtoList.Location = new System.Drawing.Point(71, 100);
            this.AddtoList.Name = "AddtoList";
            this.AddtoList.Size = new System.Drawing.Size(167, 23);
            this.AddtoList.TabIndex = 4;
            this.AddtoList.Text = "Add to List";
            this.AddtoList.UseVisualStyleBackColor = true;
            this.AddtoList.Click += new System.EventHandler(this.AddtoList_Click);
            // 
            // npcDatum
            // 
            this.npcDatum.FormattingEnabled = true;
            this.npcDatum.Location = new System.Drawing.Point(326, 43);
            this.npcDatum.Name = "npcDatum";
            this.npcDatum.Size = new System.Drawing.Size(142, 147);
            this.npcDatum.TabIndex = 5;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(486, 43);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(486, 90);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(486, 144);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 8;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // FriendshipPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 198);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.npcDatum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FriendshipPoints";
            this.Text = "FriendshipPoints";
            this.Load += new System.EventHandler(this.FriendshipPoints_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heartAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddtoList;
        private System.Windows.Forms.NumericUpDown heartAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox npcList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox npcDatum;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddCommand;
    }
}