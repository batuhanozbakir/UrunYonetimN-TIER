using BLL_UrunYonetimi.Managers.Concrete;
using BLL_UrunYonetimi.Models;
using Microsoft.Identity.Client;

namespace PL_UrunYonetimi
{
    public partial class Form1 : Form
    {
        ProductManager productManager = new ProductManager();
        ProductModel selectedProduct;
        public void ListAllProducts()
        {
            dgvProducts.DataSource = productManager.GetAll();
        }


        public Form1()
        {
            InitializeComponent();
            ListAllProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))

            {
                MessageBox.Show("Please fill all the textboxes!");
            }

            ProductModel productModel = new ProductModel();
            productModel.Name = txtName.Text;
            productModel.Price = Convert.ToInt32(txtPrice.Text);
            productManager.Create(productModel);

            ListAllProducts();
            MessageBox.Show("The product has successfully been added");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProduct = (ProductModel)dgvProducts.SelectedRows[0].DataBoundItem;
            lblSelectedProduct.Text = selectedProduct.Name;
            txtName.Text = selectedProduct.Name;
            txtPrice.Text = selectedProduct.Price.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                productManager.Delete(selectedProduct);
                ListAllProducts();
                selectedProduct = null;
                lblSelectedProduct.Text = "Selected Product:";
                MessageBox.Show("The product has succesfully been deleted!");
            }
            else
                MessageBox.Show("Please select a product to delete!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)

            {   
                selectedProduct.Name = txtName.Text;
                selectedProduct.Price = Convert.ToInt32(txtPrice.Text);
                productManager.Update(selectedProduct);
                ListAllProducts();
                selectedProduct = null;
                lblSelectedProduct.Text = "Selected Product:";
                MessageBox.Show("The product has succesfully been updated!");
            }
            else MessageBox.Show("Please select a product to update!");

            
        }

        public void ClearTextBox()
        {
            txtName.Clear();
            txtPrice.Clear();
        }
    }
}
