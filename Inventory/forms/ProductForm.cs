using Inventory.Models;
using Inventory.Pages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory
{
    public partial class ProductForm : Form
    {
        public Product currentProduct = null;
        private List<Category> categories;

        public ProductForm()
        {
            InitializeComponent();
            currentProduct = ProductsPage.instance?.currentProduct;
            categories = Category.GetAllCategories();

            if (currentProduct != null)
            {
                nameInput.Text = currentProduct.Name;
                priceInput.Value = currentProduct.Price;
                quantityInput.Value = currentProduct.Quantity;
            }
            else
            {
                deleteButton.Visible = false;
            }

            // Populate the category combo box.
            for (int i = 0; i < categories.Count; i++)
            {
                Category category = categories[i];
                categoryInput.Items.Add(category.Name);
            }
            if (currentProduct != null)
            {
                categoryInput.SelectedItem = currentProduct.CategoryName;
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            decimal price = priceInput.Value;
            int quantity = (int) quantityInput.Value;

            if (name.Equals(""))
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }

            int affectedRow = -1;
            string categoryName = categoryInput.SelectedItem.ToString();
            Product product = new Product(name, price, quantity, categoryName);
            if (currentProduct != null)
            {
                product.Id = currentProduct.Id;
                affectedRow = product.updateProduct();
            }
            else
            {
                affectedRow = product.insertProduct();
            }
            if (affectedRow > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Couldn't save product into the database");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(currentProduct != null)
            {
                int affectedRows = Product.DeleteProduct(currentProduct);
                if (affectedRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
