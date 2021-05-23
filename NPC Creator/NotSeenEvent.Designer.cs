namespace NPC_Creator
{
    partial class NotSeenEvent
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
            this.eventID = new System.Windows.Forms.NumericUpDown();
            this.eventList = new System.Windows.Forms.ListBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.AddCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create list of events not seen by the Farmer.";
            // 
            // eventID
            // 
            this.eventID.Location = new System.Drawing.Point(15, 41);
            this.eventID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.eventID.Name = "eventID";
            this.eventID.Size = new System.Drawing.Size(120, 20);
            this.eventID.TabIndex = 1;
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(232, 12);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(120, 147);
            this.eventList.TabIndex = 2;
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(151, 41);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(75, 23);
            this.AddEvent.TabIndex = 3;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Location = new System.Drawing.Point(151, 70);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(75, 23);
            this.DeleteEvent.TabIndex = 4;
            this.DeleteEvent.Text = "Delete";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(151, 99);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 5;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(33, 89);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 6;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // NotSeenEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 174);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.eventID);
            this.Controls.Add(this.label1);
            this.Name = "NotSeenEvent";
            this.Text = "NotSeenEvent";
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown eventID;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button AddCommand;
    }
}