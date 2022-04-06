using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uscuvilca.Eduardo.Business;

namespace RRCAGApp
{
    public partial class RRCForm : Form
    {
        public  RRCForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.RRCAMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFileOpenCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDataVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.formLabel = new System.Windows.Forms.Label();
            this.RRCAMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RRCAMenuStrip
            // 
            this.RRCAMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.RRCAMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuData,
            this.toolStripMenuHelp});
            this.RRCAMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.RRCAMenuStrip.Name = "RRCAMenuStrip";
            this.RRCAMenuStrip.Size = new System.Drawing.Size(780, 24);
            this.RRCAMenuStrip.TabIndex = 0;
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileOpen,
            this.toolStripSeparator1,
            this.menuItemFileExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFile.Text = "File";
            // 
            // menuItemFileOpen
            // 
            this.menuItemFileOpen.AutoToolTip = true;
            this.menuItemFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileOpenSalesQuote,
            this.menuItemFileOpenCarWash});
            this.menuItemFileOpen.Name = "menuItemFileOpen";
            this.menuItemFileOpen.Size = new System.Drawing.Size(135, 22);
            this.menuItemFileOpen.Text = "Open";
            // 
            // menuItemFileOpenSalesQuote
            // 
            this.menuItemFileOpenSalesQuote.Name = "menuItemFileOpenSalesQuote";
            this.menuItemFileOpenSalesQuote.ShortcutKeyDisplayString = "Ctrl+1";
            this.menuItemFileOpenSalesQuote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuItemFileOpenSalesQuote.Size = new System.Drawing.Size(176, 22);
            this.menuItemFileOpenSalesQuote.Text = "&Sales Quote";
            // 
            // menuItemFileOpenCarWash
            // 
            this.menuItemFileOpenCarWash.Name = "menuItemFileOpenCarWash";
            this.menuItemFileOpenCarWash.ShortcutKeyDisplayString = "Ctrl+2";
            this.menuItemFileOpenCarWash.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.menuItemFileOpenCarWash.Size = new System.Drawing.Size(176, 22);
            this.menuItemFileOpenCarWash.Text = "&Car Wash";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Name = "menuItemFileExit";
            this.menuItemFileExit.ShortcutKeyDisplayString = "Alt+F4";
            this.menuItemFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemFileExit.Size = new System.Drawing.Size(135, 22);
            this.menuItemFileExit.Text = "E&xit";
            // 
            // toolStripMenuData
            // 
            this.toolStripMenuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDataVehicle});
            this.toolStripMenuData.Name = "toolStripMenuData";
            this.toolStripMenuData.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuData.Text = "Data";
            // 
            // menuItemDataVehicle
            // 
            this.menuItemDataVehicle.Name = "menuItemDataVehicle";
            this.menuItemDataVehicle.ShortcutKeyDisplayString = "Ctrl+Shift+V";
            this.menuItemDataVehicle.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.menuItemDataVehicle.Size = new System.Drawing.Size(184, 22);
            this.menuItemDataVehicle.Text = "&Vehicle";
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpAbout});
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuHelp.Text = "Help";
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuItemHelpAbout.Text = "&About...";
            // 
            // formLabel
            // 
            this.formLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formLabel.AutoSize = true;
            this.formLabel.BackColor = System.Drawing.SystemColors.Control;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.formLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.formLabel.Location = new System.Drawing.Point(211, 185);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(359, 73);
            this.formLabel.TabIndex = 1;
            this.formLabel.Text = "ADEV2020";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RRCForm
            // 
            this.AccessibleDescription = "";
            this.ClientSize = new System.Drawing.Size(780, 442);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.RRCAMenuStrip);
            this.MainMenuStrip = this.RRCAMenuStrip;
            this.Name = "RRCForm";
            this.Text = "RRC Automotive Group";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.RRCAMenuStrip.ResumeLayout(false);
            this.RRCAMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            //
            //Loading the form
            //
            this.Load += RRCForm_Load;

        }

        /// <summary>
        /// Handles the Load event of the form.
        /// </summary>
        private void RRCForm_Load(object sender, EventArgs e)
        {
            this.menuItemFileOpenSalesQuote.Click += MenuItemFileOpenSalesQuote_Click;
            this.menuItemFileExit.Click += MenuItemFileExit_Click;
            this.menuItemHelpAbout.Click += MenuItemHelpAbout_Click;
            this.menuItemFileOpenCarWash.Click += MenuItemFileOpenCarWash_Click;
            this.menuItemDataVehicle.Click += MenuItemDataVehicle_Click; 
        }

        private void MenuItemFileOpenSalesQuote_Click(object sender, EventArgs e) {
            SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
            salesQuoteForm.Show();
        }

        private void MenuItemFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashForm carWashForm = new CarWashForm();
            carWashForm.Show();
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MenuItemHelpAbout_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MenuItemDataVehicle_Click(object sender, EventArgs e) {
            VehicleDataForm vehicleDataForm = new VehicleDataForm();
            vehicleDataForm.Show();
        }
    }
}
