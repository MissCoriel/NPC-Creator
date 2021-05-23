namespace NPC_Creator
{
    partial class Fast_Question
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
            this.question = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secondAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secondResponse = new System.Windows.Forms.TextBox();
            this.AddCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your Question?(Keep it short)";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(15, 37);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(179, 20);
            this.question.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Answer:";
            // 
            // firstAnswer
            // 
            this.firstAnswer.Location = new System.Drawing.Point(15, 102);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(100, 20);
            this.firstAnswer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NPC Response:";
            // 
            // firstResponse
            // 
            this.firstResponse.Location = new System.Drawing.Point(222, 102);
            this.firstResponse.Name = "firstResponse";
            this.firstResponse.Size = new System.Drawing.Size(211, 20);
            this.firstResponse.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Second Answer:";
            // 
            // secondAnswer
            // 
            this.secondAnswer.Location = new System.Drawing.Point(15, 187);
            this.secondAnswer.Name = "secondAnswer";
            this.secondAnswer.Size = new System.Drawing.Size(100, 20);
            this.secondAnswer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NPC Response:";
            // 
            // secondResponse
            // 
            this.secondResponse.Location = new System.Drawing.Point(222, 187);
            this.secondResponse.Name = "secondResponse";
            this.secondResponse.Size = new System.Drawing.Size(211, 20);
            this.secondResponse.TabIndex = 9;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(188, 236);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 10;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // Fast_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 284);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.secondResponse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label1);
            this.Name = "Fast_Question";
            this.Text = "Fast Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secondResponse;
        private System.Windows.Forms.Button AddCommand;
    }
}