namespace Lab05_Winform
{
    partial class frmNhap
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
            this.BrandNameLabel = new System.Windows.Forms.Label();
            this.BrandNameBox = new System.Windows.Forms.ComboBox();
            this.ProductLineLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.SpecificationLabel = new System.Windows.Forms.Label();
            this.ProductLineText = new System.Windows.Forms.TextBox();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.SpecificationText = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ExitButton = new CustomControls.RJControls.RJButton();
            this.WriteDataButton = new CustomControls.RJControls.RJButton();
            this.AddDataButton = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // BrandNameLabel
            // 
            this.BrandNameLabel.AutoSize = true;
            this.BrandNameLabel.Location = new System.Drawing.Point(38, 24);
            this.BrandNameLabel.Name = "BrandNameLabel";
            this.BrandNameLabel.Size = new System.Drawing.Size(112, 20);
            this.BrandNameLabel.TabIndex = 0;
            this.BrandNameLabel.Text = "Hãng sản xuất";
            // 
            // BrandNameBox
            // 
            this.BrandNameBox.FormattingEnabled = true;
            this.BrandNameBox.Items.AddRange(new object[] {
            "HP",
            "Dell"});
            this.BrandNameBox.Location = new System.Drawing.Point(181, 16);
            this.BrandNameBox.Name = "BrandNameBox";
            this.BrandNameBox.Size = new System.Drawing.Size(161, 28);
            this.BrandNameBox.TabIndex = 1;
            // 
            // ProductLineLabel
            // 
            this.ProductLineLabel.AutoSize = true;
            this.ProductLineLabel.Location = new System.Drawing.Point(38, 66);
            this.ProductLineLabel.Name = "ProductLineLabel";
            this.ProductLineLabel.Size = new System.Drawing.Size(122, 20);
            this.ProductLineLabel.TabIndex = 2;
            this.ProductLineLabel.Text = "Dòng sản phẩm";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(38, 109);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(110, 20);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Tên sản phẩm";
            // 
            // SpecificationLabel
            // 
            this.SpecificationLabel.AutoSize = true;
            this.SpecificationLabel.Location = new System.Drawing.Point(38, 152);
            this.SpecificationLabel.Name = "SpecificationLabel";
            this.SpecificationLabel.Size = new System.Drawing.Size(131, 20);
            this.SpecificationLabel.TabIndex = 6;
            this.SpecificationLabel.Text = "Thông số kĩ thuật";
            // 
            // ProductLineText
            // 
            this.ProductLineText.Location = new System.Drawing.Point(181, 63);
            this.ProductLineText.Name = "ProductLineText";
            this.ProductLineText.Size = new System.Drawing.Size(121, 26);
            this.ProductLineText.TabIndex = 7;
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(181, 106);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(121, 26);
            this.ProductNameText.TabIndex = 8;
            // 
            // SpecificationText
            // 
            this.SpecificationText.Location = new System.Drawing.Point(181, 149);
            this.SpecificationText.Multiline = true;
            this.SpecificationText.Name = "SpecificationText";
            this.SpecificationText.Size = new System.Drawing.Size(247, 74);
            this.SpecificationText.TabIndex = 9;
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(181, 236);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(121, 26);
            this.PriceText.TabIndex = 11;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(38, 239);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(65, 20);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Giá bán";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitButton.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.ExitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ExitButton.BorderRadius = 10;
            this.ExitButton.BorderSize = 0;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(353, 291);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(144, 60);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.TextColor = System.Drawing.Color.White;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WriteDataButton
            // 
            this.WriteDataButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.WriteDataButton.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.WriteDataButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.WriteDataButton.BorderRadius = 10;
            this.WriteDataButton.BorderSize = 0;
            this.WriteDataButton.FlatAppearance.BorderSize = 0;
            this.WriteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteDataButton.ForeColor = System.Drawing.Color.White;
            this.WriteDataButton.Location = new System.Drawing.Point(185, 291);
            this.WriteDataButton.Name = "WriteDataButton";
            this.WriteDataButton.Size = new System.Drawing.Size(144, 60);
            this.WriteDataButton.TabIndex = 13;
            this.WriteDataButton.Text = "Ghi tệp";
            this.WriteDataButton.TextColor = System.Drawing.Color.White;
            this.WriteDataButton.UseVisualStyleBackColor = false;
            this.WriteDataButton.Click += new System.EventHandler(this.WriteDataButton_Click);
            // 
            // AddDataButton
            // 
            this.AddDataButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddDataButton.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.AddDataButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddDataButton.BorderRadius = 10;
            this.AddDataButton.BorderSize = 0;
            this.AddDataButton.FlatAppearance.BorderSize = 0;
            this.AddDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDataButton.ForeColor = System.Drawing.Color.White;
            this.AddDataButton.Location = new System.Drawing.Point(16, 291);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(144, 60);
            this.AddDataButton.TabIndex = 12;
            this.AddDataButton.Text = "Thêm";
            this.AddDataButton.TextColor = System.Drawing.Color.White;
            this.AddDataButton.UseVisualStyleBackColor = false;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 369);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WriteDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SpecificationText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.ProductLineText);
            this.Controls.Add(this.SpecificationLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductLineLabel);
            this.Controls.Add(this.BrandNameBox);
            this.Controls.Add(this.BrandNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrandNameLabel;
        private System.Windows.Forms.ComboBox BrandNameBox;
        private System.Windows.Forms.Label ProductLineLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label SpecificationLabel;
        private System.Windows.Forms.TextBox ProductLineText;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.TextBox SpecificationText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.Label PriceLabel;
        private CustomControls.RJControls.RJButton AddDataButton;
        private CustomControls.RJControls.RJButton WriteDataButton;
        private CustomControls.RJControls.RJButton ExitButton;
    }
}