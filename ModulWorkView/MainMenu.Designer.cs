namespace ModulWorkView
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.machinesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usedCoffeBox = new System.Windows.Forms.TextBox();
            this.usedMilkBox = new System.Windows.Forms.TextBox();
            this.usedWaterBox = new System.Windows.Forms.TextBox();
            this.startTimeMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.endTimeMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getUsedBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.refillPeriodBox = new System.Windows.Forms.TextBox();
            this.refillPeriodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machinesListBox
            // 
            this.machinesListBox.FormattingEnabled = true;
            this.machinesListBox.ItemHeight = 15;
            this.machinesListBox.Location = new System.Drawing.Point(31, 37);
            this.machinesListBox.Name = "machinesListBox";
            this.machinesListBox.Size = new System.Drawing.Size(97, 199);
            this.machinesListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(134, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Used coffee ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(223, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Used milk";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(311, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Used water";
            // 
            // usedCoffeBox
            // 
            this.usedCoffeBox.Location = new System.Drawing.Point(134, 118);
            this.usedCoffeBox.Name = "usedCoffeBox";
            this.usedCoffeBox.ReadOnly = true;
            this.usedCoffeBox.Size = new System.Drawing.Size(74, 23);
            this.usedCoffeBox.TabIndex = 4;
            // 
            // usedMilkBox
            // 
            this.usedMilkBox.Location = new System.Drawing.Point(224, 118);
            this.usedMilkBox.Name = "usedMilkBox";
            this.usedMilkBox.ReadOnly = true;
            this.usedMilkBox.Size = new System.Drawing.Size(74, 23);
            this.usedMilkBox.TabIndex = 5;
            // 
            // usedWaterBox
            // 
            this.usedWaterBox.Location = new System.Drawing.Point(311, 118);
            this.usedWaterBox.Name = "usedWaterBox";
            this.usedWaterBox.ReadOnly = true;
            this.usedWaterBox.Size = new System.Drawing.Size(74, 23);
            this.usedWaterBox.TabIndex = 6;
            // 
            // startTimeMaskedBox
            // 
            this.startTimeMaskedBox.Location = new System.Drawing.Point(224, 37);
            this.startTimeMaskedBox.Mask = "00/00/0000 90:00";
            this.startTimeMaskedBox.Name = "startTimeMaskedBox";
            this.startTimeMaskedBox.Size = new System.Drawing.Size(161, 23);
            this.startTimeMaskedBox.TabIndex = 7;
            this.startTimeMaskedBox.ValidatingType = typeof(System.DateTime);
            // 
            // endTimeMaskedBox
            // 
            this.endTimeMaskedBox.Location = new System.Drawing.Point(224, 65);
            this.endTimeMaskedBox.Mask = "00/00/0000 90:00";
            this.endTimeMaskedBox.Name = "endTimeMaskedBox";
            this.endTimeMaskedBox.Size = new System.Drawing.Size(161, 23);
            this.endTimeMaskedBox.TabIndex = 8;
            this.endTimeMaskedBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(133, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start of period";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(133, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = " End of period";
            // 
            // getUsedBtn
            // 
            this.getUsedBtn.Location = new System.Drawing.Point(133, 151);
            this.getUsedBtn.Name = "getUsedBtn";
            this.getUsedBtn.Size = new System.Drawing.Size(252, 24);
            this.getUsedBtn.TabIndex = 11;
            this.getUsedBtn.Text = "Count used ingredients";
            this.getUsedBtn.UseVisualStyleBackColor = true;
            this.getUsedBtn.Click += new System.EventHandler(this.getUsedBtn_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(134, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Refill period in hours";
            // 
            // refillPeriodBox
            // 
            this.refillPeriodBox.Location = new System.Drawing.Point(268, 179);
            this.refillPeriodBox.Name = "refillPeriodBox";
            this.refillPeriodBox.ReadOnly = true;
            this.refillPeriodBox.Size = new System.Drawing.Size(116, 23);
            this.refillPeriodBox.TabIndex = 13;
            // 
            // refillPeriodBtn
            // 
            this.refillPeriodBtn.Location = new System.Drawing.Point(135, 212);
            this.refillPeriodBtn.Name = "refillPeriodBtn";
            this.refillPeriodBtn.Size = new System.Drawing.Size(252, 24);
            this.refillPeriodBtn.TabIndex = 14;
            this.refillPeriodBtn.Text = "Count refill period";
            this.refillPeriodBtn.UseVisualStyleBackColor = true;
            this.refillPeriodBtn.Click += new System.EventHandler(this.refillPeriodBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 282);
            this.Controls.Add(this.refillPeriodBtn);
            this.Controls.Add(this.refillPeriodBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getUsedBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endTimeMaskedBox);
            this.Controls.Add(this.startTimeMaskedBox);
            this.Controls.Add(this.usedWaterBox);
            this.Controls.Add(this.usedMilkBox);
            this.Controls.Add(this.usedCoffeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machinesListBox);
            this.MaximumSize = new System.Drawing.Size(430, 321);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usedCoffeBox;
        private System.Windows.Forms.TextBox usedMilkBox;
        private System.Windows.Forms.TextBox usedWaterBox;
        private System.Windows.Forms.MaskedTextBox startTimeMaskedBox;
        private System.Windows.Forms.MaskedTextBox endTimeMaskedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refillPeriodBtn;
        private System.Windows.Forms.TextBox refillPeriodBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getUsedBtn;
        private System.Windows.Forms.ListBox machinesListBox;
    }
}

