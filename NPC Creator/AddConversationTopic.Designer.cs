namespace NPC_Creator
{
    partial class AddConversationTopic
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
            this.topicList = new System.Windows.Forms.ComboBox();
            this.conversationDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conversationDays)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select or Type in a Conversation Topic.  It doesn\'t have to be the vanilla game t" +
    "opics.";
            // 
            // topicList
            // 
            this.topicList.FormattingEnabled = true;
            this.topicList.Items.AddRange(new object[] {
            "cc_Begin",
            "cc_Complete",
            "cc_Boulder",
            "cc_Bridge",
            "cc_Bus",
            "cc_Greenhouse",
            "cc_Minecart",
            "joja_Begin",
            "movieTheater",
            "elliottGone",
            "ElliottGone1",
            "ElliottGone2",
            "ElliottGone3",
            "ElliottGone4",
            "ElliottGone5",
            "ElliottGone6",
            "ElliottGone7",
            "emilyFiber",
            "haleyCakewalk1",
            "haleyCakewalk2",
            "leahPaint",
            "pennyRedecorating",
            "samJob1",
            "samJob2",
            "samJob3",
            "sebastianFrog",
            "sebastianFrog2",
            "shaneSaloon1",
            "shaneSaloon2",
            "dumped_Guys",
            "dumped_Girls",
            "secondChance_Girls",
            "secondChance_Guys",
            "pamHouseUpgrade",
            "pamHouseUpgradeAnonymous",
            "willyCrabs",
            "Introduction",
            "FullCrabPond"});
            this.topicList.Location = new System.Drawing.Point(138, 35);
            this.topicList.Name = "topicList";
            this.topicList.Size = new System.Drawing.Size(121, 21);
            this.topicList.TabIndex = 1;
            // 
            // conversationDays
            // 
            this.conversationDays.Location = new System.Drawing.Point(138, 111);
            this.conversationDays.Name = "conversationDays";
            this.conversationDays.Size = new System.Drawing.Size(120, 20);
            this.conversationDays.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many Days will this last? 0 = Default (4)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Commit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddConversationTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 195);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conversationDays);
            this.Controls.Add(this.topicList);
            this.Controls.Add(this.label1);
            this.Name = "AddConversationTopic";
            this.Text = "AddConversationTopic";
            ((System.ComponentModel.ISupportInitialize)(this.conversationDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox topicList;
        private System.Windows.Forms.NumericUpDown conversationDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}