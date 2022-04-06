using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAGApp.Classes;

namespace RRCAGApp
{
    public partial class CarWashForm : Form
    {
        public static string txtStaticPackagePrice = "";
        public static string txtStaticFragrancePrice = "";
        public static string txtStaticSubTotal = "";
        public static string txtStaticTaxes = "";
        public static string txtStaticTotal = "";
        public CarWashForm()
        {
            InitializeComponent();
            this.Load += CarWashForm_Load;
        }

        private void CarWashForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.menuExitOption.Click += MenuExitOption_Click;
                this.cmbBoxPackage.TextChanged += CmbBoxPackage_TextChanged;
                this.cmbBoxFragrance.TextChanged += CmbBoxFragrance_TextChanged;
                this.menuGenerateInvoiceOption.Click += MenuGenerateInvoiceOption_Click;
                //createDictionary();
                LoadFragranceDataFromFile();
                LoadPackageDataFromCollections();
                LoadInteriorPackagesItems(cmbBoxPackage.Text, cmbBoxFragrance.Text);
                LoadExteriorPackagesItems(cmbBoxPackage.Text);
                LoadOutPutLabels();
            }
            catch (Exception) {
            }
        }

        private void MenuExitOption_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbBoxPackage_TextChanged(object sender, EventArgs e) {
            LoadExteriorPackagesItems(cmbBoxPackage.Text);
            LoadInteriorPackagesItems(cmbBoxPackage.Text, cmbBoxFragrance.Text);
            LoadOutPutLabels();
        }

        private void CmbBoxFragrance_TextChanged(object sender, EventArgs e)
        {
            UpdateFragrance(cmbBoxFragrance.Text);
            LoadOutPutLabels();
        }

        private void MenuGenerateInvoiceOption_Click(object sender, EventArgs e) {

            txtStaticTotal = lblTotal.Text;
            txtStaticSubTotal = lblOutSubTotal.Text;
            txtStaticTaxes = (decimal.Parse(lblOutGST.Text) + decimal.Parse(lblOutPST.Text)).ToString();
            txtStaticFragrancePrice =  String.Format("{0:0.00}",CalculateFragranceCost());
            txtStaticPackagePrice = String.Format("{0:C}", CalculatePackageCost());

            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm();
            carWashInvoiceForm.Show();
        }

        private void LoadExteriorPackagesItems(string PackageParentFromList) {
            //Creating the databinding for the control
            BindingSource bindingExteriorItemsSummary = new BindingSource();
            bindingExteriorItemsSummary.DataSource = GenerateExteriorItems(PackageParentFromList);

            lstBoxExterior.DataSource = bindingExteriorItemsSummary;
            lstBoxExterior.DisplayMember = "ExteriorItemName";
            lstBoxExterior.ValueMember = "Value";
        }

        private void LoadInteriorPackagesItems(string PackageParentFromList, string selectedFragrance)
        {
            //Creating the databinding for the control
            BindingSource bindingInteriorItemsSummary = new BindingSource();
            bindingInteriorItemsSummary.DataSource = GenerateInteriorItems(PackageParentFromList, selectedFragrance);

            lstBoxInterior.DataSource = bindingInteriorItemsSummary;
            lstBoxInterior.DisplayMember = "InteriorItemName";
            lstBoxInterior.ValueMember = "Value";
        }

        private void UpdateFragrance(string fragrance) {

            this.lstBoxInterior.DataBindings.Clear();
            LoadInteriorPackagesItems(cmbBoxPackage.Text, cmbBoxFragrance.Text);
        }

        private void createDictionary() {
            var cities = new Dictionary<string, List<string>>();
            List<String> values = new List<String>();

            values.Add("a");
            values.Add("b");
            values.Add("c");
            values.Add("d");

            cities.Add("1", values);

            List<String> valuesExtracted = new List<String>();
            foreach (var kvp in cities) {
                Console.WriteLine("Key: {0}", kvp.Key);
                foreach (var kvp2 in kvp.Value) {
                    Console.WriteLine("Value: {0}", kvp2);
                    valuesExtracted.Add(kvp2);
                }
            }

            BindingSource bindingInteriorItemsSummary = new BindingSource();
            bindingInteriorItemsSummary.DataSource = valuesExtracted;

            lstBoxInterior.DataSource = valuesExtracted;
            //lstBoxInterior.DisplayMember = "valuesExtracted";
            //lstBoxInterior.ValueMember = "Value";
        }

        private List<ExteriorItems> GenerateExteriorItems(string PackageParentFromList) {
            //Loading information for exterior items
            List<ExteriorItems> exteriorItemsLists = new List<ExteriorItems>();
            exteriorItemsLists.Add(new ExteriorItems() { ExteriorItemName = "Hand Wash", Value = 1 });
            exteriorItemsLists.Add(new ExteriorItems() { ExteriorItemName = "Hand Wax", Value = 2 });
            exteriorItemsLists.Add(new ExteriorItems() { ExteriorItemName = "Wheel Polish", Value = 3 });
            exteriorItemsLists.Add(new ExteriorItems() { ExteriorItemName = "Detail Engine Compartment", Value = 4 });

            switch (PackageParentFromList) {
                case "Executive":
                    exteriorItemsLists.RemoveAt(3);
                    break;
                case "Deluxe":
                    exteriorItemsLists.RemoveAt(3);
                    exteriorItemsLists.RemoveAt(2);

                    break;
                case "Standard":
                    exteriorItemsLists.RemoveAt(3);
                    exteriorItemsLists.RemoveAt(2);
                    exteriorItemsLists.RemoveAt(1);
                    break;
            }
            return exteriorItemsLists;
        }

        private List<InteriorItems> GenerateInteriorItems(string PackageParentFromList, string selectedFragrance) {

            
            //Loading information for interior items
            List<InteriorItems> interiorItemsLists = new List<InteriorItems>();
            interiorItemsLists.Add(new InteriorItems() { InteriorItemName = "Fragrance - "+selectedFragrance, Value = 1 });
            interiorItemsLists.Add(new InteriorItems() { InteriorItemName = "Shampoo Carpets", Value = 2 });
            interiorItemsLists.Add(new InteriorItems() { InteriorItemName = "Shampoo Upholstery", Value = 3 });
            interiorItemsLists.Add(new InteriorItems() { InteriorItemName = "Interior Protection Coat", Value = 4 });

            switch (PackageParentFromList)
            {
                case "Executive":
                    interiorItemsLists.RemoveAt(3);
                    break;
                case "Deluxe":
                    interiorItemsLists.RemoveAt(3);
                    interiorItemsLists.RemoveAt(2);

                    break;
                case "Standard":
                    interiorItemsLists.RemoveAt(3);
                    interiorItemsLists.RemoveAt(2);
                    interiorItemsLists.RemoveAt(1);
                    break;
            }
            return interiorItemsLists;
        }

        private void LoadPackageDataFromCollections() {
            //Generating Data into
            List<Package> packagesItems = new List<Package>();  
            packagesItems.Add(new Package() { Name = "Standard", Value = 1 });
            packagesItems.Add(new Package() { Name = "Deluxe", Value = 2 });
            packagesItems.Add(new Package() { Name = "Executive", Value = 3 });
            packagesItems.Add(new Package() { Name = "Luxury", Value = 4 });

            //DataBinding from class Package
            BindingSource bindingPackage = new BindingSource();
            bindingPackage.DataSource = packagesItems;
            cmbBoxPackage.DataSource = bindingPackage;
            cmbBoxPackage.DisplayMember = "Name";
            cmbBoxPackage.ValueMember = "Value";

            cmbBoxPackage.SelectedIndex = 0;
        }

        private void LoadFragranceDataFromFile() {
            try
            {
                //Loading all the data from the file to the class Fragrance
                List<Fragrance> fragranceData = new List<Fragrance>();
                string textFileDirectory = @"..\..\Data\Fragrance_Data.txt";
                string[] textFileData = File.ReadAllLines(textFileDirectory);

                for (int i = 0; i < textFileData.Length; i++)
                {
                    fragranceData.Add(new Fragrance() { FragranceName = textFileData[i].Split(',')[0], Value = i });
                }

                //DataBinding from class Fragrance
                BindingSource bindingFragrance = new BindingSource();
                bindingFragrance.DataSource = fragranceData;
                cmbBoxFragrance.DataSource = bindingFragrance;
                cmbBoxFragrance.DisplayMember = "FragranceName";
                cmbBoxFragrance.ValueMember = "Value";
                cmbBoxFragrance.SelectedIndex = 3;
            }
            catch (Exception e) {
                if (e.Message.Contains("Could not find file"))
                {
                    MessageBox.Show("Fragrances data file not found.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (e.Message.Contains("is denied"))
                {
                    MessageBox.Show("An error occurred while reading the data file.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void LoadOutPutLabels(){
            decimal subTotal = CalculateCostsFromForm(); 
            BindingSource bindingSourceInvoice = new BindingSource();

            //Loading information to the carWashInvoice object
            CarWashInvoice carWashInvoice = new CarWashInvoice(decimal.Parse(subTotal.ToString("#.##")), 
                decimal.Parse((subTotal * 0.05m).ToString("#.##")), 
                decimal.Parse((subTotal * 0.07m).ToString("#.##")), 
                decimal.Parse((subTotal * 1.12m).ToString("#.##")));

            //Loading the dataSource
            bindingSourceInvoice.DataSource = carWashInvoice;
            
            lblOutSubTotal.DataBindings.Clear(); 
            lblOutPST.DataBindings.Clear();
            lblOutGST.DataBindings.Clear();
            lblTotal.DataBindings.Clear();

            //Databinding all the output labels                        
            lblOutSubTotal.DataBindings.Add(new Binding("Text", bindingSourceInvoice, "SubTotal", true, DataSourceUpdateMode.Never, null, "C"));
            lblOutPST.DataBindings.Add(new Binding("Text", bindingSourceInvoice, "PST"));
            lblOutGST.DataBindings.Add(new Binding("Text", bindingSourceInvoice, "GST"));
            lblTotal.DataBindings.Add(new Binding("Text", bindingSourceInvoice, "Total", true, DataSourceUpdateMode.Never, null, "C"));
        }

        private decimal CalculateCostsFromForm() {
            decimal subTotal = 0;
            //Packages
            switch (cmbBoxPackage.Text) {
                case "Standard":
                    subTotal = 7.50m;
                    break;
                case "Deluxe":
                    subTotal = 15.00m;
                    break;
                case "Executive":
                    subTotal = 35.00m;
                    break;
                case "Luxury":
                    subTotal = 55.00m;
                    break;
            }

            //Fragrances
            switch (cmbBoxFragrance.Text) {
                case "Pine":
                    subTotal += 0.0m;
                    break;
                case "Hawaiian Mist":
                    subTotal += 2.75m;
                    break;
                case "Baby Powder":
                    subTotal += 1.50m;
                    break;
                case "Country Floral":
                    subTotal += 2.25m;
                    break;
                case "Pina Colada":
                    subTotal += 0.75m;
                    break;
                case "Vanilla":
                    subTotal += 2.00m;
                    break;
            }
            return subTotal;
        }

        private decimal CalculatePackageCost() {
            decimal packageCost = 0;
            //Packages
            switch (cmbBoxPackage.Text)
            {
                case "Standard":
                    packageCost = 7.50m;
                    break;
                case "Deluxe":
                    packageCost = 15.00m;
                    break;
                case "Executive":
                    packageCost = 35.00m;
                    break;
                case "Luxury":
                    packageCost = 55.00m;
                    break;
            }
            return packageCost;
        }

        private decimal CalculateFragranceCost()
        {
            decimal fragranceCost = 0;
            //Packages
            switch (cmbBoxFragrance.Text)
            {
                case "Pine":
                    fragranceCost += 0.0m;
                    break;
                case "Hawaiian Mist":
                    fragranceCost += 2.75m;
                    break;
                case "Baby Powder":
                    fragranceCost += 1.50m;
                    break;
                case "Country Floral":
                    fragranceCost += 2.25m;
                    break;
                case "Pina Colada":
                    fragranceCost += 0.75m;
                    break;
                case "Vanilla":
                    fragranceCost += 2.00m;
                    break;
            }
            return fragranceCost;
        }
    }
}

