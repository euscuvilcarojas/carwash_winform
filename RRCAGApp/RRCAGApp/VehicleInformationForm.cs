using RRCAG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        BindingSource bindingSourceInvoice;
        public VehicleInformationForm()
        {
            InitializeComponent();
            this.Load += VehicleInformationForm_Load;
            btnClose.Click += BtnClose_Click;
        }

        private void VehicleInformationForm_Load(object sender, EventArgs e)
        {
            LoadInformationFromMainForm();
        }

        private void LoadInformationFromMainForm()
        {
            Vehicle vehicleInformation = SalesQuoteForm.vehicleInformation;
            bindingSourceInvoice = new BindingSource();
            bindingSourceInvoice.DataSource = vehicleInformation;
            //DataBinding
            //, true, DataSourceUpdateMode.Never, null, "C"
            lblOutStockID.DataBindings.Add(new Binding("Text", vehicleInformation, "StockID"));
            lblOutYear.DataBindings.Add(new Binding("Text", vehicleInformation, "ManufacturedYear"));
            lblOutManufacturer.DataBindings.Add(new Binding("Text", vehicleInformation, "Manufacturer"));
            lblOutModel.DataBindings.Add(new Binding("Text", vehicleInformation, "Model"));
            lblOutMileage.DataBindings.Add(new Binding("Text", vehicleInformation, "Mileage", true, DataSourceUpdateMode.Never, null, "N0"));
            lblOutTransmission.DataBindings.Add(new Binding("Text", vehicleInformation, "IsAutomatic"));
            lblOutColour.DataBindings.Add(new Binding("Text", vehicleInformation, "Colour"));
            lblOutBasePrice.DataBindings.Add(new Binding("Text", vehicleInformation, "BasePrice", true, DataSourceUpdateMode.Never, null, "C"));

            if (vehicleInformation.IsAutomatic)
            {
                lblOutTransmission.Text = "Automatic";
            }
            else
            {
                lblOutTransmission.Text = "Manual";
            }

            this.Text = (vehicleInformation.StockID + " - " + vehicleInformation.ManufacturedYear + " - " + vehicleInformation.ManufacturedYear + " - " + vehicleInformation.Model);
        }

        private void BtnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
