namespace RRCAGApp
{
    partial class CarWashForm
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
            this.CarWashMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CarWashMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGenerateInvoiceOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitOption = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxPackage = new System.Windows.Forms.ComboBox();
            this.cmbBoxFragrance = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxExterior = new System.Windows.Forms.ListBox();
            this.lstBoxInterior = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOutSubTotal = new System.Windows.Forms.Label();
            this.lblOutPST = new System.Windows.Forms.Label();
            this.lblOutGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CarWashMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarWashMenuStrip
            // 
            this.CarWashMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CarWashMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarWashMenuFile});
            this.CarWashMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CarWashMenuStrip.Name = "CarWashMenuStrip";
            this.CarWashMenuStrip.Size = new System.Drawing.Size(375, 24);
            this.CarWashMenuStrip.TabIndex = 0;
            this.CarWashMenuStrip.Text = "menuStrip1";
            // 
            // CarWashMenuFile
            // 
            this.CarWashMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGenerateInvoiceOption,
            this.menuExitOption});
            this.CarWashMenuFile.Name = "CarWashMenuFile";
            this.CarWashMenuFile.Size = new System.Drawing.Size(37, 20);
            this.CarWashMenuFile.Text = "&File";
            // 
            // menuGenerateInvoiceOption
            // 
            this.menuGenerateInvoiceOption.Name = "menuGenerateInvoiceOption";
            this.menuGenerateInvoiceOption.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.menuGenerateInvoiceOption.Size = new System.Drawing.Size(231, 22);
            this.menuGenerateInvoiceOption.Text = "Generate &Invoice";
            // 
            // menuExitOption
            // 
            this.menuExitOption.Name = "menuExitOption";
            this.menuExitOption.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExitOption.Size = new System.Drawing.Size(231, 22);
            this.menuExitOption.Text = "E&xit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // cmbBoxPackage
            // 
            this.cmbBoxPackage.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBoxPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPackage.FormattingEnabled = true;
            this.cmbBoxPackage.Location = new System.Drawing.Point(34, 80);
            this.cmbBoxPackage.Name = "cmbBoxPackage";
            this.cmbBoxPackage.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPackage.Sorted = true;
            this.cmbBoxPackage.TabIndex = 3;
            // 
            // cmbBoxFragrance
            // 
            this.cmbBoxFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFragrance.FormattingEnabled = true;
            this.cmbBoxFragrance.Location = new System.Drawing.Point(210, 80);
            this.cmbBoxFragrance.Name = "cmbBoxFragrance";
            this.cmbBoxFragrance.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFragrance.Sorted = true;
            this.cmbBoxFragrance.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxExterior);
            this.groupBox1.Controls.Add(this.lstBoxInterior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lstBoxExterior
            // 
            this.lstBoxExterior.FormattingEnabled = true;
            this.lstBoxExterior.Location = new System.Drawing.Point(186, 60);
            this.lstBoxExterior.Name = "lstBoxExterior";
            this.lstBoxExterior.Size = new System.Drawing.Size(138, 134);
            this.lstBoxExterior.TabIndex = 5;
            // 
            // lstBoxInterior
            // 
            this.lstBoxInterior.FormattingEnabled = true;
            this.lstBoxInterior.Location = new System.Drawing.Point(19, 60);
            this.lstBoxInterior.Name = "lstBoxInterior";
            this.lstBoxInterior.Size = new System.Drawing.Size(141, 134);
            this.lstBoxInterior.Sorted = true;
            this.lstBoxInterior.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exterior:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(194, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Subtotal:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(194, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "PST:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(194, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "GST:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(213, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutSubTotal
            // 
            this.lblOutSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutSubTotal.Location = new System.Drawing.Point(267, 372);
            this.lblOutSubTotal.Name = "lblOutSubTotal";
            this.lblOutSubTotal.Size = new System.Drawing.Size(94, 22);
            this.lblOutSubTotal.TabIndex = 10;
            this.lblOutSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutPST
            // 
            this.lblOutPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutPST.Location = new System.Drawing.Point(267, 411);
            this.lblOutPST.Name = "lblOutPST";
            this.lblOutPST.Size = new System.Drawing.Size(94, 22);
            this.lblOutPST.TabIndex = 11;
            this.lblOutPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutGST
            // 
            this.lblOutGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutGST.Location = new System.Drawing.Point(267, 448);
            this.lblOutGST.Name = "lblOutGST";
            this.lblOutGST.Size = new System.Drawing.Size(94, 22);
            this.lblOutGST.TabIndex = 12;
            this.lblOutGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(267, 485);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 22);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 533);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOutGST);
            this.Controls.Add(this.lblOutPST);
            this.Controls.Add(this.lblOutSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbBoxFragrance);
            this.Controls.Add(this.cmbBoxPackage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarWashMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.CarWashMenuStrip;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.ShowIcon = false;
            this.Text = "CarWashForm";
            this.CarWashMenuStrip.ResumeLayout(false);
            this.CarWashMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CarWashMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CarWashMenuFile;
        private System.Windows.Forms.ToolStripMenuItem menuGenerateInvoiceOption;
        private System.Windows.Forms.ToolStripMenuItem menuExitOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxPackage;
        private System.Windows.Forms.ComboBox cmbBoxFragrance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxExterior;
        private System.Windows.Forms.ListBox lstBoxInterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOutSubTotal;
        private System.Windows.Forms.Label lblOutPST;
        private System.Windows.Forms.Label lblOutGST;
        private System.Windows.Forms.Label lblTotal;
    }
}