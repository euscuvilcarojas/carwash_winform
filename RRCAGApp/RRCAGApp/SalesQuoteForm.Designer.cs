using System.Runtime.CompilerServices;

namespace RRCAGApp
{
    partial class SalesQuoteForm
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

      
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox groupBoxAccessories;
        private System.Windows.Forms.CheckBox checkBoxComputerNavigation;
        private System.Windows.Forms.CheckBox checkBoxLeatherInterior;
        private System.Windows.Forms.CheckBox checkBoxStereoSystem;
        private System.Windows.Forms.GroupBox groupBoxExteriorFinish;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbPearlized;
        private System.Windows.Forms.RadioButton rdbCustom;
        private System.Windows.Forms.RadioButton rdbStandard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numberOfYears;
        private System.Windows.Forms.NumericUpDown numberOfInterestRate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutAmountDue;
        private System.Windows.Forms.Label lblOutMonthly;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.groupBoxAccessories = new System.Windows.Forms.GroupBox();
            this.checkBoxComputerNavigation = new System.Windows.Forms.CheckBox();
            this.checkBoxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.checkBoxStereoSystem = new System.Windows.Forms.CheckBox();
            this.groupBoxExteriorFinish = new System.Windows.Forms.GroupBox();
            this.rdbPearlized = new System.Windows.Forms.RadioButton();
            this.rdbCustom = new System.Windows.Forms.RadioButton();
            this.rdbStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSumVehSale = new System.Windows.Forms.Label();
            this.lblSumOptions = new System.Windows.Forms.Label();
            this.lblSumSubTot = new System.Windows.Forms.Label();
            this.lblSumSalTax = new System.Windows.Forms.Label();
            this.lblSumTot = new System.Windows.Forms.Label();
            this.lblSumTradeIn = new System.Windows.Forms.Label();
            this.lblOutAmountDue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOutMonthly = new System.Windows.Forms.Label();
            this.numberOfYears = new System.Windows.Forms.NumericUpDown();
            this.numberOfInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.vehicleCmbError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tradeInValueError = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuSalesQuoteForm = new System.Windows.Forms.MenuStrip();
            this.menuSalesQuoteFormFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalesQuoteFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalesQuoteFormView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalesQuoteViewInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.groupBoxAccessories.SuspendLayout();
            this.groupBoxExteriorFinish.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleCmbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeInValueError)).BeginInit();
            this.menuSalesQuoteForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(138, 75);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(142, 20);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxAccessories
            // 
            this.groupBoxAccessories.Controls.Add(this.checkBoxComputerNavigation);
            this.groupBoxAccessories.Controls.Add(this.checkBoxLeatherInterior);
            this.groupBoxAccessories.Controls.Add(this.checkBoxStereoSystem);
            this.groupBoxAccessories.Location = new System.Drawing.Point(8, 126);
            this.groupBoxAccessories.Name = "groupBoxAccessories";
            this.groupBoxAccessories.Size = new System.Drawing.Size(272, 157);
            this.groupBoxAccessories.TabIndex = 4;
            this.groupBoxAccessories.TabStop = false;
            this.groupBoxAccessories.Text = "Accessories";
            // 
            // checkBoxComputerNavigation
            // 
            this.checkBoxComputerNavigation.AutoSize = true;
            this.checkBoxComputerNavigation.Location = new System.Drawing.Point(24, 113);
            this.checkBoxComputerNavigation.Name = "checkBoxComputerNavigation";
            this.checkBoxComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.checkBoxComputerNavigation.TabIndex = 3;
            this.checkBoxComputerNavigation.Text = "Computer Navigation";
            this.checkBoxComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeatherInterior
            // 
            this.checkBoxLeatherInterior.AutoSize = true;
            this.checkBoxLeatherInterior.Location = new System.Drawing.Point(24, 76);
            this.checkBoxLeatherInterior.Name = "checkBoxLeatherInterior";
            this.checkBoxLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.checkBoxLeatherInterior.TabIndex = 2;
            this.checkBoxLeatherInterior.Text = "Leather Interior";
            this.checkBoxLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // checkBoxStereoSystem
            // 
            this.checkBoxStereoSystem.AutoSize = true;
            this.checkBoxStereoSystem.Location = new System.Drawing.Point(24, 37);
            this.checkBoxStereoSystem.Name = "checkBoxStereoSystem";
            this.checkBoxStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.checkBoxStereoSystem.TabIndex = 1;
            this.checkBoxStereoSystem.Text = "Stereo System";
            this.checkBoxStereoSystem.UseVisualStyleBackColor = true;
            // 
            // groupBoxExteriorFinish
            // 
            this.groupBoxExteriorFinish.Controls.Add(this.rdbPearlized);
            this.groupBoxExteriorFinish.Controls.Add(this.rdbCustom);
            this.groupBoxExteriorFinish.Controls.Add(this.rdbStandard);
            this.groupBoxExteriorFinish.Location = new System.Drawing.Point(8, 305);
            this.groupBoxExteriorFinish.Name = "groupBoxExteriorFinish";
            this.groupBoxExteriorFinish.Size = new System.Drawing.Size(272, 166);
            this.groupBoxExteriorFinish.TabIndex = 5;
            this.groupBoxExteriorFinish.TabStop = false;
            this.groupBoxExteriorFinish.Text = "Exterior Finish";
            // 
            // rdbPearlized
            // 
            this.rdbPearlized.AutoSize = true;
            this.rdbPearlized.Location = new System.Drawing.Point(24, 73);
            this.rdbPearlized.Name = "rdbPearlized";
            this.rdbPearlized.Size = new System.Drawing.Size(68, 17);
            this.rdbPearlized.TabIndex = 1;
            this.rdbPearlized.TabStop = true;
            this.rdbPearlized.Text = "Pearlized";
            this.rdbPearlized.UseVisualStyleBackColor = true;
            // 
            // rdbCustom
            // 
            this.rdbCustom.AutoSize = true;
            this.rdbCustom.Location = new System.Drawing.Point(24, 109);
            this.rdbCustom.Name = "rdbCustom";
            this.rdbCustom.Size = new System.Drawing.Size(123, 17);
            this.rdbCustom.TabIndex = 2;
            this.rdbCustom.TabStop = true;
            this.rdbCustom.Text = "Customized Detailing";
            this.rdbCustom.UseVisualStyleBackColor = true;
            // 
            // rdbStandard
            // 
            this.rdbStandard.AutoSize = true;
            this.rdbStandard.Checked = true;
            this.rdbStandard.Location = new System.Drawing.Point(24, 37);
            this.rdbStandard.Name = "rdbStandard";
            this.rdbStandard.Size = new System.Drawing.Size(68, 17);
            this.rdbStandard.TabIndex = 0;
            this.rdbStandard.TabStop = true;
            this.rdbStandard.Text = "Standard";
            this.rdbStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSumVehSale);
            this.groupBox3.Controls.Add(this.lblSumOptions);
            this.groupBox3.Controls.Add(this.lblSumSubTot);
            this.groupBox3.Controls.Add(this.lblSumSalTax);
            this.groupBox3.Controls.Add(this.lblSumTot);
            this.groupBox3.Controls.Add(this.lblSumTradeIn);
            this.groupBox3.Controls.Add(this.lblOutAmountDue);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(290, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 296);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // lblSumVehSale
            // 
            this.lblSumVehSale.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumVehSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumVehSale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumVehSale.Location = new System.Drawing.Point(148, 30);
            this.lblSumVehSale.Name = "lblSumVehSale";
            this.lblSumVehSale.Size = new System.Drawing.Size(142, 20);
            this.lblSumVehSale.TabIndex = 16;
            this.lblSumVehSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumOptions
            // 
            this.lblSumOptions.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumOptions.Location = new System.Drawing.Point(148, 64);
            this.lblSumOptions.Name = "lblSumOptions";
            this.lblSumOptions.Size = new System.Drawing.Size(142, 20);
            this.lblSumOptions.TabIndex = 15;
            this.lblSumOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumSubTot
            // 
            this.lblSumSubTot.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumSubTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumSubTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumSubTot.Location = new System.Drawing.Point(148, 101);
            this.lblSumSubTot.Name = "lblSumSubTot";
            this.lblSumSubTot.Size = new System.Drawing.Size(142, 20);
            this.lblSumSubTot.TabIndex = 14;
            this.lblSumSubTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumSalTax
            // 
            this.lblSumSalTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumSalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumSalTax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumSalTax.Location = new System.Drawing.Point(148, 136);
            this.lblSumSalTax.Name = "lblSumSalTax";
            this.lblSumSalTax.Size = new System.Drawing.Size(142, 20);
            this.lblSumSalTax.TabIndex = 13;
            this.lblSumSalTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumTot
            // 
            this.lblSumTot.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumTot.Location = new System.Drawing.Point(148, 173);
            this.lblSumTot.Name = "lblSumTot";
            this.lblSumTot.Size = new System.Drawing.Size(142, 20);
            this.lblSumTot.TabIndex = 12;
            this.lblSumTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumTradeIn
            // 
            this.lblSumTradeIn.BackColor = System.Drawing.SystemColors.Control;
            this.lblSumTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumTradeIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSumTradeIn.Location = new System.Drawing.Point(148, 211);
            this.lblSumTradeIn.Name = "lblSumTradeIn";
            this.lblSumTradeIn.Size = new System.Drawing.Size(142, 20);
            this.lblSumTradeIn.TabIndex = 11;
            this.lblSumTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutAmountDue
            // 
            this.lblOutAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOutAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutAmountDue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOutAmountDue.Location = new System.Drawing.Point(148, 253);
            this.lblOutAmountDue.Name = "lblOutAmountDue";
            this.lblOutAmountDue.Size = new System.Drawing.Size(142, 20);
            this.lblOutAmountDue.TabIndex = 10;
            this.lblOutAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Amount Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trade-in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sales Tax(13%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Options:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehicle\'s Sale Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOutMonthly);
            this.groupBox4.Controls.Add(this.numberOfYears);
            this.groupBox4.Controls.Add(this.numberOfInterestRate);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(290, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 129);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finance";
            // 
            // lblOutMonthly
            // 
            this.lblOutMonthly.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblOutMonthly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutMonthly.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblOutMonthly.Location = new System.Drawing.Point(232, 68);
            this.lblOutMonthly.Name = "lblOutMonthly";
            this.lblOutMonthly.Size = new System.Drawing.Size(85, 20);
            this.lblOutMonthly.TabIndex = 12;
            // 
            // numberOfYears
            // 
            this.numberOfYears.Location = new System.Drawing.Point(20, 68);
            this.numberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfYears.Name = "numberOfYears";
            this.numberOfYears.Size = new System.Drawing.Size(73, 20);
            this.numberOfYears.TabIndex = 8;
            this.numberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfInterestRate
            // 
            this.numberOfInterestRate.DecimalPlaces = 2;
            this.numberOfInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numberOfInterestRate.Location = new System.Drawing.Point(132, 68);
            this.numberOfInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numberOfInterestRate.Name = "numberOfInterestRate";
            this.numberOfInterestRate.Size = new System.Drawing.Size(67, 20);
            this.numberOfInterestRate.TabIndex = 9;
            this.numberOfInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "No. of Years";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(131, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Anual Interest Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Monthly Payment";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 488);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(512, 488);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // vehicleCmbError
            // 
            this.vehicleCmbError.BlinkRate = 0;
            this.vehicleCmbError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.vehicleCmbError.ContainerControl = this;
            // 
            // tradeInValueError
            // 
            this.tradeInValueError.BlinkRate = 0;
            this.tradeInValueError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.tradeInValueError.ContainerControl = this;
            // 
            // menuSalesQuoteForm
            // 
            this.menuSalesQuoteForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalesQuoteFormFile,
            this.menuSalesQuoteFormView});
            this.menuSalesQuoteForm.Location = new System.Drawing.Point(0, 0);
            this.menuSalesQuoteForm.Name = "menuSalesQuoteForm";
            this.menuSalesQuoteForm.Size = new System.Drawing.Size(624, 24);
            this.menuSalesQuoteForm.TabIndex = 12;
            // 
            // menuSalesQuoteFormFile
            // 
            this.menuSalesQuoteFormFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalesQuoteFileClose});
            this.menuSalesQuoteFormFile.Name = "menuSalesQuoteFormFile";
            this.menuSalesQuoteFormFile.Size = new System.Drawing.Size(37, 20);
            this.menuSalesQuoteFormFile.Text = "&File";
            // 
            // menuSalesQuoteFileClose
            // 
            this.menuSalesQuoteFileClose.Name = "menuSalesQuoteFileClose";
            this.menuSalesQuoteFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuSalesQuoteFileClose.Size = new System.Drawing.Size(148, 22);
            this.menuSalesQuoteFileClose.Text = "&Close";
            // 
            // menuSalesQuoteFormView
            // 
            this.menuSalesQuoteFormView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalesQuoteViewInformation});
            this.menuSalesQuoteFormView.Name = "menuSalesQuoteFormView";
            this.menuSalesQuoteFormView.Size = new System.Drawing.Size(44, 20);
            this.menuSalesQuoteFormView.Text = "&View";
            // 
            // menuSalesQuoteViewInformation
            // 
            this.menuSalesQuoteViewInformation.Enabled = false;
            this.menuSalesQuoteViewInformation.Name = "menuSalesQuoteViewInformation";
            this.menuSalesQuoteViewInformation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.menuSalesQuoteViewInformation.Size = new System.Drawing.Size(246, 22);
            this.menuSalesQuoteViewInformation.Text = "Vehicle &Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Vehicle:";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(138, 44);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(142, 21);
            this.cmbVehicle.TabIndex = 1;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(624, 533);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxExteriorFinish);
            this.Controls.Add(this.groupBoxAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuSalesQuoteForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuSalesQuoteForm;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vehicle Sales Quote";
            this.groupBoxAccessories.ResumeLayout(false);
            this.groupBoxAccessories.PerformLayout();
            this.groupBoxExteriorFinish.ResumeLayout(false);
            this.groupBoxExteriorFinish.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleCmbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeInValueError)).EndInit();
            this.menuSalesQuoteForm.ResumeLayout(false);
            this.menuSalesQuoteForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ErrorProvider vehicleCmbError;
        private System.Windows.Forms.ErrorProvider tradeInValueError;
        private System.Windows.Forms.Label lblSumVehSale;
        private System.Windows.Forms.Label lblSumOptions;
        private System.Windows.Forms.Label lblSumSubTot;
        private System.Windows.Forms.Label lblSumSalTax;
        private System.Windows.Forms.Label lblSumTot;
        private System.Windows.Forms.Label lblSumTradeIn;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuSalesQuoteForm;
        private System.Windows.Forms.ToolStripMenuItem menuSalesQuoteFormFile;
        private System.Windows.Forms.ToolStripMenuItem menuSalesQuoteFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuSalesQuoteFormView;
        private System.Windows.Forms.ToolStripMenuItem menuSalesQuoteViewInformation;
    }
}