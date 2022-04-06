namespace RRCAGApp
{
    partial class VehicleDataForm
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
            this.menuVehicleData = new System.Windows.Forms.MenuStrip();
            this.menuVehicleDataFile = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDataFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vehicleDataFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicleDataEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleDataEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVehicleData = new System.Windows.Forms.DataGridView();
            this.menuVehicleData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVehicleData
            // 
            this.menuVehicleData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVehicleDataFile,
            this.menuVehicleDataEdit});
            this.menuVehicleData.Location = new System.Drawing.Point(0, 0);
            this.menuVehicleData.Name = "menuVehicleData";
            this.menuVehicleData.Size = new System.Drawing.Size(940, 24);
            this.menuVehicleData.TabIndex = 1;
            this.menuVehicleData.Text = "menuStrip1";
            // 
            // menuVehicleDataFile
            // 
            this.menuVehicleDataFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleDataFileSave,
            this.toolStripSeparator1,
            this.vehicleDataFileClose});
            this.menuVehicleDataFile.Name = "menuVehicleDataFile";
            this.menuVehicleDataFile.Size = new System.Drawing.Size(37, 20);
            this.menuVehicleDataFile.Text = "&File";
            // 
            // vehicleDataFileSave
            // 
            this.vehicleDataFileSave.Enabled = false;
            this.vehicleDataFileSave.Name = "vehicleDataFileSave";
            this.vehicleDataFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.vehicleDataFileSave.Size = new System.Drawing.Size(148, 22);
            this.vehicleDataFileSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // vehicleDataFileClose
            // 
            this.vehicleDataFileClose.Name = "vehicleDataFileClose";
            this.vehicleDataFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.vehicleDataFileClose.Size = new System.Drawing.Size(148, 22);
            this.vehicleDataFileClose.Text = "&Close";
            // 
            // menuVehicleDataEdit
            // 
            this.menuVehicleDataEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleDataEditDel});
            this.menuVehicleDataEdit.Name = "menuVehicleDataEdit";
            this.menuVehicleDataEdit.Size = new System.Drawing.Size(39, 20);
            this.menuVehicleDataEdit.Text = "&Edit";
            // 
            // vehicleDataEditDel
            // 
            this.vehicleDataEditDel.Enabled = false;
            this.vehicleDataEditDel.Name = "vehicleDataEditDel";
            this.vehicleDataEditDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.vehicleDataEditDel.Size = new System.Drawing.Size(131, 22);
            this.vehicleDataEditDel.Text = "&Delete";
            // 
            // dgvVehicleData
            // 
            this.dgvVehicleData.AllowUserToDeleteRows = false;
            this.dgvVehicleData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvVehicleData.Location = new System.Drawing.Point(0, 22);
            this.dgvVehicleData.MultiSelect = false;
            this.dgvVehicleData.Name = "dgvVehicleData";
            this.dgvVehicleData.Size = new System.Drawing.Size(937, 479);
            this.dgvVehicleData.TabIndex = 0;
            // 
            // VehicleDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 507);
            this.Controls.Add(this.dgvVehicleData);
            this.Controls.Add(this.menuVehicleData);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuVehicleData;
            this.Name = "VehicleDataForm";
            this.Text = "Vehicle Data";
            this.menuVehicleData.ResumeLayout(false);
            this.menuVehicleData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuVehicleData;
        private System.Windows.Forms.ToolStripMenuItem menuVehicleDataFile;
        private System.Windows.Forms.ToolStripMenuItem vehicleDataFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vehicleDataFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuVehicleDataEdit;
        private System.Windows.Forms.ToolStripMenuItem vehicleDataEditDel;
        private System.Windows.Forms.DataGridView dgvVehicleData;
    }
}