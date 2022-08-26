using Inventory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory.Pages
{
    public partial class ProductsPage : UserControl
    {
        public Product currentProduct = null;
        public static ProductsPage instance = null;
        private List<Product> products;
        private List<Product> allProducts;

        public ProductsPage()
        {
            InitializeComponent();
            titleBar.SetTitle("PRODUCTS");
            titleBar.OnReload += reloadProducts;

            instance = this;
        }

        private void initTable()
        {
            dataGridView.Rows.Clear();
            //ADD COLUMNS
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Name";
            dataGridView.Columns[2].Name = "Price";
            dataGridView.Columns[3].Name = "Quantity";
            dataGridView.Columns[4].Name = "Category";

            //ADD ROWS
            foreach (Product product in products)
            {
                ArrayList row = new ArrayList();
                row.Add(product.Id);
                row.Add(product.Name);
                row.Add(product.Price);
                row.Add(product.Quantity);
                row.Add(product.CategoryId);
                dataGridView.Rows.Add(row.ToArray());
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.Text = "Edit";
            button.HeaderText = "Edit";
            button.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(button);
        }

        private void reloadProducts()
        {
            products = Product.GetAllProducts();
            allProducts = products;
            initTable();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            currentProduct = null;
            navigateToProductFormPage();
        }

        private void navigateToProductFormPage()
        {
            using (var form = new ProductForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reloadProducts();
                }
            }
        }

        private void ProductsPage_Load(object sender, EventArgs e)
        {
            products = Product.GetAllProducts();
            allProducts = products;
            initTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                currentProduct = products.ToArray()[(e.RowIndex)];
                navigateToProductFormPage();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string term = searchInput.Text?.ToLower();
            if (term.Equals(""))
            {
                products = allProducts;
            }
            else
            {
                List<Product> filtered = new List<Product>();
                foreach(Product product in allProducts)
                {
                    if (product.Name.ToLower().Contains(term))
                    {
                        filtered.Add(product);
                    }
                }
                products = filtered;
            }
            initTable();
        }
    }
}
