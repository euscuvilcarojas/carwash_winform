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
    public partial class CarWashInvoiceForm : Form
    {
        public CarWashInvoiceForm()
        {
            InitializeComponent();
            this.Load += CarWashInvoiceForm_Load;
        }

        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            LoadInformationFromMainForm();
        }

        private void LoadInformationFromMainForm() {
            lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblOutFragrancePrice.Text = CarWashForm.txtStaticFragrancePrice;
            lblOutPackagePrice.Text = CarWashForm.txtStaticPackagePrice;
            lblOutTaxes.Text = CarWashForm.txtStaticTaxes;
            lblOutTotal.Text = CarWashForm.txtStaticTotal;
            lblOutSubtotal.Text = CarWashForm.txtStaticSubTotal;
        }
    }
}
