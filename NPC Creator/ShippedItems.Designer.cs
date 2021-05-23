﻿namespace NPC_Creator
{
    partial class ShippedItems
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shipAmount = new System.Windows.Forms.NumericUpDown();
            this.AddtoList = new System.Windows.Forms.Button();
            this.shippingList = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.AddCommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddtoList);
            this.groupBox1.Controls.Add(this.shipAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.itemList);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please complete every field";
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(6, 48);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(121, 21);
            this.itemList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item to ship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many shipped?";
            // 
            // shipAmount
            // 
            this.shipAmount.Location = new System.Drawing.Point(6, 109);
            this.shipAmount.Name = "shipAmount";
            this.shipAmount.Size = new System.Drawing.Size(121, 20);
            this.shipAmount.TabIndex = 4;
            // 
            // AddtoList
            // 
            this.AddtoList.Location = new System.Drawing.Point(153, 71);
            this.AddtoList.Name = "AddtoList";
            this.AddtoList.Size = new System.Drawing.Size(75, 23);
            this.AddtoList.TabIndex = 5;
            this.AddtoList.Text = "Add";
            this.AddtoList.UseVisualStyleBackColor = true;
            this.AddtoList.Click += new System.EventHandler(this.AddtoList_Click);
            // 
            // shippingList
            // 
            this.shippingList.FormattingEnabled = true;
            this.shippingList.Location = new System.Drawing.Point(240, 12);
            this.shippingList.Name = "shippingList";
            this.shippingList.Size = new System.Drawing.Size(177, 160);
            this.shippingList.TabIndex = 6;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(423, 27);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(423, 71);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 8;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // AddCommand
            // 
            this.AddCommand.Location = new System.Drawing.Point(423, 119);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(75, 23);
            this.AddCommand.TabIndex = 9;
            this.AddCommand.Text = "Commit";
            this.AddCommand.UseVisualStyleBackColor = true;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // ShippedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 179);
            this.ControlBox = false;
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.shippingList);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShippedItems";
            this.Text = "ShippedItems";
            this.Load += new System.EventHandler(this.ShippedItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddtoList;
        private System.Windows.Forms.NumericUpDown shipAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.ListBox shippingList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button AddCommand;
    }
}