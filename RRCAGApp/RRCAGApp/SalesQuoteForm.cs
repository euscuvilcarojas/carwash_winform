using RRCAG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Uscuvilca.Eduardo.Business;

namespace RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        public static Vehicle vehicleInformation;
        decimal vehicleSalePrice = 1;
        decimal tradeInAmount = 1;
        decimal TAXRATE = 0.13m;
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;
        Accessories accessoriesChosen = Accessories.None;
        ExteriorFinish exteriorFinish = ExteriorFinish.None;

        public SalesQuoteForm()
        {
            InitializeComponent();
            this.Load += SalesQuoteForm_Load;
        }

        private void SetDefault(Button defaultButton)
        {
            this.AcceptButton = defaultButton;
        }

        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            RetrieveDataFromTheDatabase();
            if (this.connection.State == ConnectionState.Open)
            {
                GenerateVehicleObjectsFromDataBase();
                LoadVehicleInformationFromDataBase();
            }
            else
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            this.btnCalculate.Click += BtnCalculate_click;
            this.btnReset.Click += BtnReset_click;

            this.checkBoxComputerNavigation.CheckedChanged += CheckBoxComputerNavigation_CheckedChanged;
            this.checkBoxLeatherInterior.CheckedChanged += CheckBoxLeatherInterior_CheckedChanged;
            this.checkBoxStereoSystem.CheckedChanged += CheckBoxStereoSystem_CheckedChanged;

            this.txtTradeInValue.TextChanged += TxtTradeInValue_textChanged;

            this.rdbStandard.CheckedChanged += RdbStandard_CheckedChanged;
            this.rdbCustom.CheckedChanged += RdbCustom_CheckedChanged;
            this.rdbPearlized.CheckedChanged += RdbPearlized_CheckedChanged;

            this.numberOfInterestRate.ValueChanged += NumberOfInterestRate_ValueChanged;
            this.numberOfYears.ValueChanged += NumberOfYears_ValueChanged;

            this.menuSalesQuoteViewInformation.Click += MenuSalesQuoteViewInformation_Click;
            this.cmbVehicle.TextChanged += CmbVehicle_TextChanged;

            this.menuSalesQuoteFileClose.Click += MenuSalesQuoteFileClose_Click;
        }

        #region Events

        //Menu Events

        private void MenuSalesQuoteViewInformation_Click(object sender, EventArgs e) {

            vehicleInformation = ObtainVehicleSelected();
            VehicleInformationForm vehicleInformationForm = new VehicleInformationForm();
            vehicleInformationForm.Show();
        }

        private void MenuSalesQuoteFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ComboBox Events
        private void CmbVehicle_TextChanged(object sender, EventArgs e)
        {
            if (cmbVehicle.SelectedIndex >= 0) {
                menuSalesQuoteViewInformation.Enabled = true;
                ResetSectionSummary();
                lblOutMonthly.ResetText();
            }
        }

        //Inputs Events
        private void TxtTradeInValue_textChanged(object sender, EventArgs e)
        {
            ResetSectionSummary();
            lblOutMonthly.ResetText();
        }

        //Button Events
        private void BtnCalculate_click(object sender, EventArgs e) {
            CalculateSalesQuote();
        }

        private void BtnReset_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to reset form?", "Reset Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                ResetSectionInput();
                ResetSectionOptions();
                ResetSectionSummary();
                ResetSectionFinance();
                ResetSectionInputErrors();
                cmbVehicle.Focus();
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("You have clicked the Cancel button", "Message");
            }
        }

        //Accessories CheckBoxes Event
        private void CheckBoxComputerNavigation_CheckedChanged(object sender, EventArgs e) {
            if (lblOutAmountDue.Text.Length != 0) {
                CalculateSalesQuote();
            }
        }

        private void CheckBoxLeatherInterior_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        private void CheckBoxStereoSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        //Exterior Finish radioButton Events
        private void RdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        private void RdbPearlized_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        private void RdbStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        //NumberControls Events

        private void NumberOfInterestRate_ValueChanged(object sender, EventArgs e) {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        private void NumberOfYears_ValueChanged(object sender, EventArgs e)
        {
            if (lblOutAmountDue.Text.Length != 0)
            {
                CalculateSalesQuote();
            }
        }

        #endregion

        /// <summary>
        /// Queries the database and populates a dataset.
        /// </summary>
        private void RetrieveDataFromTheDatabase()
        {
            try
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='AMDatabase.mdb'";

                this.connection = new OleDbConnection();
                this.connection.ConnectionString = connectionString;
                this.connection.Open();

                OleDbCommand selectCommand = new OleDbCommand();
                selectCommand.CommandText = "SELECT * FROM VehicleStock";
                selectCommand.Connection = this.connection;

                this.adapter = new OleDbDataAdapter();
                this.adapter.SelectCommand = selectCommand;

                OleDbCommandBuilder builder = new OleDbCommandBuilder();
                builder.DataAdapter = this.adapter;

                this.adapter.UpdateCommand = builder.GetUpdateCommand();
                this.adapter.DeleteCommand = builder.GetDeleteCommand();
                this.adapter.InsertCommand = builder.GetInsertCommand();

                this.dataset = new DataSet();

                this.adapter.Fill(this.dataset, "VehicleStock");
            }
            catch (Exception e)
            {
                this.connection.Close();
                this.connection.Dispose();
            }
        }

        private List<Vehicle> GenerateVehicleObjectsFromDataBase()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < this.dataset.Tables[0].Rows.Count; i++) {
                vehicleList.Add(new Vehicle(
                    dataset.Tables["VehicleStock"].Rows[i]["StockNumber"].ToString(),
                    (int)(short)dataset.Tables["VehicleStock"].Rows[i]["ManufacturedYear"],
                    dataset.Tables["VehicleStock"].Rows[i]["Make"].ToString(),
                    dataset.Tables["VehicleStock"].Rows[i]["Model"].ToString(),
                    (int)dataset.Tables["VehicleStock"].Rows[i]["Mileage"],
                    (bool)dataset.Tables["VehicleStock"].Rows[i]["Automatic"],
                    dataset.Tables["VehicleStock"].Rows[i]["Colour"].ToString(),
                    (decimal)(double)dataset.Tables["VehicleStock"].Rows[i]["BasePrice"]
                    ));
            }
            return vehicleList;
        }

        //Load Information from DataBase
        private void LoadVehicleInformationFromDataBase()
        {
            //DataBinding from class Package
            BindingSource bindingVehicles = new BindingSource();
            bindingVehicles.DataSource = GenerateVehicleObjectsFromDataBase();
            cmbVehicle.DataSource = bindingVehicles;

            cmbVehicle.DisplayMember = "stockID";
            cmbVehicle.ValueMember = "stockID";
            cmbVehicle.SelectedIndex = -1;
            cmbVehicle.Focus();
        }

        //Load Information into Vehicle DLL
        private void LoadVehicleInformation() {
            //DataBinding from class Package
            BindingSource bindingVehicles = new BindingSource();
            bindingVehicles.DataSource = GenerateVehicleObjects();
            cmbVehicle.DataSource = bindingVehicles;

            cmbVehicle.DisplayMember = "stockID";
            cmbVehicle.ValueMember = "stockID";
            cmbVehicle.SelectedIndex = -1;
            cmbVehicle.Focus();
        }

        private List<Vehicle> GenerateVehicleObjects() {
            //Vehicle vehicle = new Vehicle(string StcokId, int manufacturedyear, string manufacturer, string model, int mileage, bool isAutomatic, string colour, decimal basePrice);
            List<Vehicle> vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle("VEH01", 2019, "KIA", "SORENTO", 10000, true, "BLACK", 10000m));
            vehicleList.Add(new Vehicle("VEH02", 2020, "TOYOTA", "RAV4Pro", 25000, false, "RED", 20000m));
            vehicleList.Add(new Vehicle("VEH03", 2016, "HYUNDAI", "GRAND SANTA FE", 2900, false, "GRAY", 30000m));
            vehicleList.Add(new Vehicle("VEH04", 2018, "FORD", "CHARGER4", 550000, true, "BLUE", 40000m));
            vehicleList.Add(new Vehicle("VEH05", 2017, "HONDA", "PILOT", 47000, true, "WHITE", 50000m));
            vehicleList.Add(new Vehicle("VEH06", 2020, "NIISA", "CALDINA", 47000, true, "WHITE", 60000m));
            return vehicleList;
        }

        private Vehicle ObtainVehicleSelected() {
            return (Vehicle)cmbVehicle.SelectedItem;
        }

        //Validate VehicleComboBox
        private void ValidateVehicleList() {
            if (cmbVehicle.SelectedText == "") {
                MessageBox.Show("A vehicle must be selected.");
            }
        }

        //Calculate Operation
        private void CalculateSalesQuote() {
            if (ProcessTextBoxes())
            {
                AccessoriesChosen();
                ExteriorFinishChosen();
                ProcessSummary();
                ResetSectionInputErrors();
            }
            else
            {
                ResetSectionSummary();
            }
        }

        //Sumary
        private void ProcessSummary()
        {
            //Displaying the summary
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, TAXRATE, accessoriesChosen, exteriorFinish);

            lblSumVehSale.Text = String.Format("{0:C}", salesQuote.VehicleSalePrice);
            lblSumOptions.Text = (salesQuote.AccessoryCost + salesQuote.FinishCost).ToString();
            lblSumSubTot.Text = String.Format("{0:C}",salesQuote.SubTotal);
            lblSumSalTax.Text = salesQuote.SalesTax.ToString();
            lblSumTot.Text = String.Format("{0:C}", salesQuote.Total);
            lblSumTradeIn.Text = (salesQuote.TradeInAmount * -1).ToString();
            lblOutAmountDue.Text = String.Format("{0:C}",salesQuote.AmountDue);

            //Displaying Finance Calculation
            lblOutMonthly.Text = calculateMonthlyPayment(
                Convert.ToDecimal(lblOutAmountDue.Text.Substring(1)), 
                numberOfInterestRate.Value, 
                (Convert.ToInt32(numberOfYears.Value) * 12));
        }

        private string calculateMonthlyPayment(decimal amountDue, decimal interestRate, int months) {
            return ((amountDue * (1 + (interestRate * 0.01m))) / months).ToString("#.##"); 
        }
        //Accessories
        private void AccessoriesChosen() {
            //Accessories
            String accessoryChosenString = "D";
            if (checkBoxStereoSystem.Checked)
            {
                accessoryChosenString += "A";
            }
            if (checkBoxLeatherInterior.Checked)
            {
                accessoryChosenString += "B";
            }
            if (checkBoxComputerNavigation.Checked)
            {
                accessoryChosenString += "C";
            }

            switch (accessoryChosenString)
            {
                case "D":
                    accessoriesChosen = Accessories.None;
                    break;
                case "DABC":
                    accessoriesChosen = Accessories.All;
                    break;
                case "DA":
                    accessoriesChosen = Accessories.StereoSystem;
                    break;
                case "DB":
                    accessoriesChosen = Accessories.LeatherInterior;
                    break;
                case "DC":
                    accessoriesChosen = Accessories.ComputerNavigation;
                    break;

                case "DAB":
                    accessoriesChosen = Accessories.StereoAndLeather;
                    break;

                case "DAC":
                    accessoriesChosen = Accessories.StereoAndNavigation;
                    break;
                case "DBC":
                    accessoriesChosen = Accessories.LeatherAndNavigation;
                    break;
            }
        }

        //Exterior Finish
        private void ExteriorFinishChosen() {
            if (rdbStandard.Checked)
            {
                exteriorFinish = ExteriorFinish.Standard;
            }
            else if (rdbPearlized.Checked)
            {
                exteriorFinish = ExteriorFinish.Pearlized;
            }
            else if (rdbCustom.Checked)
            {
                exteriorFinish = ExteriorFinish.Custom;
            }
        }

        //TextBoxes
        private bool ProcessTextBoxes() {
            ResetSectionInputErrors();
            bool validationFlagVehicle = false;
            bool validationFlagTradeIn = false;
            bool result = false;

            if (cmbVehicle.SelectedIndex < 0)
            {
                cmbVehicle.Focus();
                vehicleCmbError.SetError(cmbVehicle, "A vehicle must be selected.");
            }
            else
            {
                validationFlagVehicle = true;
                vehicleSalePrice = ObtainVehicleSelected().BasePrice;
            }

            //TradeInValue TextBox
            if (txtTradeInValue.Text == "0")
            {
                tradeInValueError.SetError(txtTradeInValue, "Trade-in value is a required field.");
            }
            else if (!int.TryParse(txtTradeInValue.Text, out _))
            {
                tradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
            }
            else if (Decimal.Parse(txtTradeInValue.Text) < 0.0m)
            {
                tradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot be less than 0.");
            }
            else if (validationFlagVehicle)
            {
                if ((int)(ObtainVehicleSelected().BasePrice) < int.Parse(txtTradeInValue.Text))
                {
                    tradeInValueError.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                }
                else
                {
                    validationFlagTradeIn = true;
                }
            }

            if (validationFlagTradeIn) {
                tradeInAmount = Decimal.Parse(txtTradeInValue.Text);
                result = true;
            }

            return result;
        }

        #region Reset Options
        private void ResetSectionSummary() {
            lblSumOptions.ResetText();
            lblSumSalTax.ResetText();
            lblSumSubTot.ResetText();
            lblSumTot.ResetText();
            lblSumTradeIn.ResetText();
            lblSumVehSale.ResetText();
            lblOutAmountDue.ResetText();
        }

        private void ResetSectionFinance() {
            lblOutMonthly.ResetText();
            numberOfInterestRate.Value = 5;
            numberOfYears.Value = 1;
        }

        private void ResetSectionOptions() {
            //CheckBox
            checkBoxStereoSystem.Checked = false;
            checkBoxLeatherInterior.Checked = false;
            checkBoxComputerNavigation.Checked = false;
            //RadioButton
            rdbStandard.Checked = true;
        }

        private void ResetSectionInput() {
            cmbVehicle.SelectedIndex = -1;
            txtTradeInValue.ResetText();
        }

        private void ResetSectionInputErrors() {
            vehicleCmbError.Clear();
            tradeInValueError.Clear();
        }
        #endregion
    }
}
