using Inventory.forms;
using Inventory.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory.Pages
{
    public partial class CategoryPage : UserControl
    {
        public Category currentCategory = null;
        public static CategoryPage instance = null;
        private List<Category> categories;
        private List<Category> allCategories;

        public CategoryPage()
        {
            InitializeComponent();
            titleBar.SetTitle("CATEGORY");
            titleBar.OnReload += reloadCategories;

            instance = this;
        }

        private void initTable()
        {
            dataGridView.Rows.Clear();
            //ADD COLUMNS
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Name";
            
            //ADD ROWS
            foreach (Category category in categories)
            {
                ArrayList row = new ArrayList();
                row.Add(category.Id);
                row.Add(category.Name);
                dataGridView.Rows.Add(row.ToArray());
            }

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Edit";
            button.Text = "Edit";
            button.HeaderText = "Edit";
            button.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(button);
        }

        private void reloadCategories()
        {
            categories = Category.GetAllCategories();
            allCategories = categories;
            initTable();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            currentCategory = null;
            navigateToCategoryFormPage();
        }

        private void navigateToCategoryFormPage()
        {
            using (var form = new CategoryForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    reloadCategories();
                }
            }
        }
        private void CategoriesPage_Load(object sender, EventArgs e)
        {
            categories = Category.GetAllCategories();
            allCategories = categories;
            initTable();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                currentCategory = categories.ToArray()[(e.RowIndex)];
                navigateToCategoryFormPage();
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            string term = searchInput.Text?.ToLower();
            if (term.Equals(""))
            {
                categories = allCategories;
            }
            else
            {
                List<Category> filtered = new List<Category>();
                foreach (Category category in allCategories)
                {
                    if (category.Name.ToLower().Contains(term))
                    {
                        filtered.Add(category);
                    }
                }
                categories = filtered;
            }
            initTable();
        }
    }
}
