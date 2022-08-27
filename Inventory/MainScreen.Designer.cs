﻿
namespace Inventory
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoryPage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.mainPage = new System.Windows.Forms.Panel();
            this.pageDashboard = new Inventory.DashboardPage();
            this.pageProducts = new Inventory.Pages.ProductsPage();
            this.pageCategory = new Inventory.Pages.CategoryPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.udtTypeHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtTypeHandlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.sidebar.Controls.Add(this.flowLayoutPanel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(400, 1090);
            this.sidebar.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.homeButton);
            this.flowLayoutPanel1.Controls.Add(this.productsButton);
            this.flowLayoutPanel1.Controls.Add(this.categoryPage);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.Logout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 1090);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.Image = global::Inventory.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(390, 130);
            this.homeButton.TabIndex = 6;
            this.homeButton.Tag = "dashboard";
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.changePage);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.productsButton.Image = global::Inventory.Properties.Resources.product;
            this.productsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.Location = new System.Drawing.Point(3, 139);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(390, 130);
            this.productsButton.TabIndex = 0;
            this.productsButton.Tag = "products";
            this.productsButton.Text = "Products";
            this.productsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.changePage);
            // 
            // categoryPage
            // 
            this.categoryPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.categoryPage.FlatAppearance.BorderSize = 0;
            this.categoryPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryPage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoryPage.Image = global::Inventory.Properties.Resources.category;
            this.categoryPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryPage.Location = new System.Drawing.Point(3, 275);
            this.categoryPage.Name = "categoryPage";
            this.categoryPage.Size = new System.Drawing.Size(390, 130);
            this.categoryPage.TabIndex = 1;
            this.categoryPage.Tag = "category";
            this.categoryPage.Text = "Categories";
            this.categoryPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoryPage.UseVisualStyleBackColor = false;
            this.categoryPage.Click += new System.EventHandler(this.changePage);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::Inventory.Properties.Resources.reporting;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(390, 130);
            this.button3.TabIndex = 2;
            this.button3.Text = "Reporting";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::Inventory.Properties.Resources.session;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(390, 130);
            this.button4.TabIndex = 3;
            this.button4.Text = "Session";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Image = global::Inventory.Properties.Resources.users;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 683);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(390, 130);
            this.button5.TabIndex = 4;
            this.button5.Text = "Users";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Logout.Image = global::Inventory.Properties.Resources.log_out;
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(3, 819);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(390, 130);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Log out";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = false;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainPage.Controls.Add(this.pageDashboard);
            this.mainPage.Controls.Add(this.pageProducts);
            this.mainPage.Controls.Add(this.pageCategory);
            this.mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPage.Location = new System.Drawing.Point(400, 0);
            this.mainPage.Margin = new System.Windows.Forms.Padding(0);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1434, 1090);
            this.mainPage.TabIndex = 1;
            // 
            // pageDashboard
            // 
            this.pageDashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pageDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDashboard.Location = new System.Drawing.Point(0, 0);
            this.pageDashboard.Name = "pageDashboard";
            this.pageDashboard.Size = new System.Drawing.Size(1434, 1090);
            this.pageDashboard.TabIndex = 0;
            this.pageDashboard.Tag = "home";
            // 
            // pageProducts
            // 
            this.pageProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pageProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageProducts.Location = new System.Drawing.Point(0, 0);
            this.pageProducts.Name = "pageProducts";
            this.pageProducts.Size = new System.Drawing.Size(1434, 1090);
            this.pageProducts.TabIndex = 1;
            this.pageProducts.Tag = "products";
            // 
            // pageCategory
            // 
            this.pageCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageCategory.Location = new System.Drawing.Point(0, 0);
            this.pageCategory.Name = "pageCategory";
            this.pageCategory.Size = new System.Drawing.Size(1434, 1090);
            this.pageCategory.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sidebar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainPage, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1834, 1110);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // udtTypeHandlerBindingSource
            // 
            this.udtTypeHandlerBindingSource.DataSource = typeof(Dapper.SqlMapper.UdtTypeHandler);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1834, 1110);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainScreen";
            this.Text = "Inventory Management System";
            this.sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udtTypeHandlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button categoryPage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel mainPage;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.BindingSource udtTypeHandlerBindingSource;
        private DashboardPage pageDashboard;
        private Pages.ProductsPage pageProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Pages.CategoryPage pageCategory;
    }
}