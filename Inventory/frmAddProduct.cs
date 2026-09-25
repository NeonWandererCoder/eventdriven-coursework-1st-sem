using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        // private fields based on Table 2
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        // holds the list of products added so far, bound to the DataGridView
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            // list of categories based on Table 3
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/Jarred Goods",
                "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            // populate the ComboBox with each category
            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        // methods copied from 03 Laboratory Exercise 2 - Method.txt,
        // with the missing exception-throwing lines filled in

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Product name should only contain letters.");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException("Quantity should only contain numbers.");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Selling price should be a valid amount (e.g. 10 or 10.50).");
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // each of these can throw a custom exception if the input is invalid
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                // add the new product to the list and refresh the grid
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                    _ExpDate, _SellPrice, _Quantity, _Description));

                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Product Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Selling Price",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // this runs whether the add succeeded or failed
                Console.WriteLine("Add Product attempt finished.");
            }
        }
    }
}