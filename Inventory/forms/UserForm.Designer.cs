
namespace Inventory.forms
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new Inventory.Components.PasswordInput();
            this.otherNamesInput = new Inventory.Components.CustomInput();
            this.usernameInput = new Inventory.Components.CustomInput();
            this.surnameInput = new Inventory.Components.CustomInput();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 992);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1054, 100);
            this.panel1.TabIndex = 2;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(20, 20);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(225, 60);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(829, 20);
            this.saveButton.Margin = new System.Windows.Forms.Padding(20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(205, 60);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passwordInput);
            this.panel2.Controls.Add(this.isAdmin);
            this.panel2.Controls.Add(this.isActive);
            this.panel2.Controls.Add(this.otherNamesInput);
            this.panel2.Controls.Add(this.usernameInput);
            this.panel2.Controls.Add(this.surnameInput);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 992);
            this.panel2.TabIndex = 3;
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdmin.Location = new System.Drawing.Point(324, 546);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(174, 41);
            this.isAdmin.TabIndex = 5;
            this.isAdmin.Text = "Is Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActive.Location = new System.Drawing.Point(23, 546);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(168, 41);
            this.isActive.TabIndex = 4;
            this.isActive.Text = "Is Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER FORM";
            // 
            // passwordInput
            // 
            this.passwordInput.Label = "Password";
            this.passwordInput.Location = new System.Drawing.Point(23, 724);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.ShowPassword = false;
            this.passwordInput.Size = new System.Drawing.Size(995, 118);
            this.passwordInput.TabIndex = 6;
            this.passwordInput.Value = "";
            // 
            // otherNamesInput
            // 
            this.otherNamesInput.Label = "Other Names";
            this.otherNamesInput.Location = new System.Drawing.Point(21, 392);
            this.otherNamesInput.Name = "otherNamesInput";
            this.otherNamesInput.Size = new System.Drawing.Size(998, 112);
            this.otherNamesInput.TabIndex = 3;
            this.otherNamesInput.Value = "";
            // 
            // usernameInput
            // 
            this.usernameInput.Label = "Username";
            this.usernameInput.Location = new System.Drawing.Point(20, 144);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(998, 112);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.Value = "";
            // 
            // surnameInput
            // 
            this.surnameInput.Label = "Surname";
            this.surnameInput.Location = new System.Drawing.Point(20, 267);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(998, 112);
            this.surnameInput.TabIndex = 1;
            this.surnameInput.Value = "";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 1092);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "User Form";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Components.CustomInput otherNamesInput;
        private Components.CustomInput usernameInput;
        private Components.CustomInput surnameInput;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.CheckBox isActive;
        private Components.PasswordInput passwordInput;
    }
}