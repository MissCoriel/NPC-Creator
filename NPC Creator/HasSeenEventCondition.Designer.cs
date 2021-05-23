namespace NPC_Creator
{
    partial class HasSeenEventCondition
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
            this.AddCommand = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.ListBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.DelSelected = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the ID of the Event that needs to be seen.";
            // 
            // eventID
            // 
            this.eventID.Location = new System.Drawing.Point(15, 35);
            this.eventID.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.eventID.Name = "eventID";
            this.eventID.Size = new System.Drawing.Size(120, 20);
            this.eventID.TabIndex = 1;
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(38, 74);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 2;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(213, 35);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(120, 95);
            this.eventList.TabIndex = 3;
            // 
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(152, 35);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(42, 23);
            this.AddEvent.TabIndex = 4;
            this.AddEvent.Text = "Add";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // DelSelected
            // 
            this.DelSelected.Location = new System.Drawing.Point(152, 64);
            this.DelSelected.Name = "DelSelected";
            this.DelSelected.Size = new System.Drawing.Size(42, 23);
            this.DelSelected.TabIndex = 5;
            this.DelSelected.Text = "Del";
            this.DelSelected.UseVisualStyleBackColor = true;
            this.DelSelected.Click += new System.EventHandler(this.DelSelected_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(152, 93);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(42, 23);
            this.ClearAll.TabIndex = 6;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // HasSeenEventCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 145);
            this.ControlBox = false;
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.DelSelected);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.eventID);
            this.Controls.Add(this.label1);
            this.Name = "HasSeenEventCondition";
            this.Text = "HasSeenEventCondition";
            ((System.ComponentModel.ISupportInitialize)(this.eventID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown eventID;
        private System.Windows.Forms.Button AddCommand;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button DelSelected;
        private System.Windows.Forms.Button ClearAll;
    }
}