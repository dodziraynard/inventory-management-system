
namespace Inventory.Components
{
    partial class TitleBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleText = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.Dock = System.Windows.Forms.DockStyle.Left;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(15, 15);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(329, 66);
            this.titleText.TabIndex = 2;
            this.titleText.Text = "DASHBOARD";
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(1477, 15);
            this.infoText.Margin = new System.Windows.Forms.Padding(10);
            this.infoText.Name = "infoText";
            this.infoText.Padding = new System.Windows.Forms.Padding(10);
            this.infoText.Size = new System.Drawing.Size(186, 57);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "Hi, Admin!";
            // 
            // reloadButton
            // 
            this.reloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadButton.Image = global::Inventory.Properties.Resources.reload1;
            this.reloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reloadButton.Location = new System.Drawing.Point(1142, 15);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(335, 66);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.titleText);
            this.Name = "TitleBar";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(1678, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label infoText;
    }
}
