namespace NPC_Creator
{
    partial class Schedule_Dialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Dialogue));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyString = new System.Windows.Forms.TextBox();
            this.dialogValue = new System.Windows.Forms.TextBox();
            this.scheduleDialogList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createDialog = new System.Windows.Forms.Button();
            this.listClear = new System.Windows.Forms.Button();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.sendToList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.keyString);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dialogue Key";
            // 
            // keyNumber
            // 
            this.keyNumber.Location = new System.Drawing.Point(122, 32);
            this.keyNumber.Name = "keyNumber";
            this.keyNumber.Size = new System.Drawing.Size(72, 20);
            this.keyNumber.TabIndex = 2;
            this.keyNumber.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".";
            // 
            // keyString
            // 
            this.keyString.Location = new System.Drawing.Point(6, 32);
            this.keyString.Name = "keyString";
            this.keyString.Size = new System.Drawing.Size(100, 20);
            this.keyString.TabIndex = 0;
            // 
            // dialogValue
            // 
            this.dialogValue.Location = new System.Drawing.Point(206, 32);
            this.dialogValue.Name = "dialogValue";
            this.dialogValue.Size = new System.Drawing.Size(769, 20);
            this.dialogValue.TabIndex = 3;
            // 
            // scheduleDialogList
            // 
            this.scheduleDialogList.FormattingEnabled = true;
            this.scheduleDialogList.Location = new System.Drawing.Point(206, 106);
            this.scheduleDialogList.Name = "scheduleDialogList";
            this.scheduleDialogList.Size = new System.Drawing.Size(769, 251);
            this.scheduleDialogList.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editData);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.createDialog);
            this.panel1.Controls.Add(this.listClear);
            this.panel1.Controls.Add(this.deleteSelected);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 251);
            this.panel1.TabIndex = 3;
            // 
            // editData
            // 
            this.editData.Location = new System.Drawing.Point(12, 182);
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(182, 23);
            this.editData.TabIndex = 4;
            this.editData.Text = "Edit Selected";
            this.editData.UseVisualStyleBackColor = true;
            this.editData.Click += new System.EventHandler(this.editData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load Recent Saved Work";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createDialog
            // 
            this.createDialog.Location = new System.Drawing.Point(12, 104);
            this.createDialog.Name = "createDialog";
            this.createDialog.Size = new System.Drawing.Size(182, 23);
            this.createDialog.TabIndex = 2;
            this.createDialog.Text = "Create Schedule Dialogue";
            this.createDialog.UseVisualStyleBackColor = true;
            this.createDialog.Click += new System.EventHandler(this.createDialog_Click);
            // 
            // listClear
            // 
            this.listClear.Location = new System.Drawing.Point(12, 63);
            this.listClear.Name = "listClear";
            this.listClear.Size = new System.Drawing.Size(182, 23);
            this.listClear.TabIndex = 1;
            this.listClear.Text = "Clear All";
            this.listClear.UseVisualStyleBackColor = true;
            this.listClear.Click += new System.EventHandler(this.listClear_Click);
            // 
            // deleteSelected
            // 
            this.deleteSelected.Location = new System.Drawing.Point(12, 24);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(182, 23);
            this.deleteSelected.TabIndex = 0;
            this.deleteSelected.Text = "Delete Selected";
            this.deleteSelected.UseVisualStyleBackColor = true;
            this.deleteSelected.Click += new System.EventHandler(this.deleteSelected_Click);
            // 
            // sendToList
            // 
            this.sendToList.Location = new System.Drawing.Point(540, 67);
            this.sendToList.Name = "sendToList";
            this.sendToList.Size = new System.Drawing.Size(75, 23);
            this.sendToList.TabIndex = 5;
            this.sendToList.Text = "Commit";
            this.sendToList.UseVisualStyleBackColor = true;
            this.sendToList.Click += new System.EventHandler(this.sendToList_Click);
            // 
            // Schedule_Dialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1018, 401);
            this.Controls.Add(this.sendToList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.scheduleDialogList);
            this.Controls.Add(this.dialogValue);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Schedule_Dialogue";
            this.Text = "Schedule Dialogue";
            this.Load += new System.EventHandler(this.Schedule_Dialogue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keyNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyString;
        private System.Windows.Forms.TextBox dialogValue;
        private System.Windows.Forms.ListBox scheduleDialogList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteSelected;
        private System.Windows.Forms.Button sendToList;
        private System.Windows.Forms.Button createDialog;
        private System.Windows.Forms.Button listClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editData;
    }
}