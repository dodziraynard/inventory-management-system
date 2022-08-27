using Inventory.Models;
using Inventory.Pages;
using System;
using System.Windows.Forms;

namespace Inventory.forms
{
    public partial class CategoryForm : Form
    {
        public Category currentCategory = null;

        public CategoryForm()
        {
            InitializeComponent();
            currentCategory = CategoryPage.instance?.currentCategory;

            if (currentCategory != null)
            {
                nameInput.Text = currentCategory.Name;
            }
            else
            {
                deleteButton.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;

            if (name.Equals(""))
            {
                MessageBox.Show("Please enter a valid name");
                return;
            }

            int affectedRow = -1;
            Category category = new Category(name);
            if (currentCategory != null)
            {
                category.Id = currentCategory.Id;
                affectedRow = category.updateCategory();
            }
            else
            {
                affectedRow = category.insertCategory();
            }
            if (affectedRow > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Couldn't save category into the database");
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentCategory != null)
            {
                int affectedRows = Category.DeleteCategory(currentCategory);
                if (affectedRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
