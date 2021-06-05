namespace NPC_Creator
{
    partial class Add_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items));
            this.itemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addItemList = new System.Windows.Forms.ListBox();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.addCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(12, 34);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(120, 225);
            this.itemList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item List";
            // 
            // addItemList
            // 
            this.addItemList.FormattingEnabled = true;
            this.addItemList.Location = new System.Drawing.Point(248, 34);
            this.addItemList.Name = "addItemList";
            this.addItemList.Size = new System.Drawing.Size(120, 225);
            this.addItemList.TabIndex = 2;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(150, 79);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "ADD ->";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(150, 121);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(75, 23);
            this.removeItem.TabIndex = 4;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // addCommand
            // 
            this.addCommand.Location = new System.Drawing.Point(150, 283);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(75, 23);
            this.addCommand.TabIndex = 5;
            this.addCommand.Text = "Commit";
            this.addCommand.UseVisualStyleBackColor = true;
            this.addCommand.Click += new System.EventHandler(this.addCommand_Click);
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 332);
            this.Controls.Add(this.addCommand);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.addItemList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Items";
            this.Text = "Add_Items";
            this.Load += new System.EventHandler(this.Add_Items_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox addItemList;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button addCommand;
    }
}