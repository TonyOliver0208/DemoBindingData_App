namespace Lab05_Winform
{
    partial class frmTracuu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductLineBox = new System.Windows.Forms.ComboBox();
            this.ProductLineLabel = new System.Windows.Forms.Label();
            this.BrandNameBox = new System.Windows.Forms.ComboBox();
            this.BrandNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountProductText = new System.Windows.Forms.TextBox();
            this.ProductListView = new System.Windows.Forms.ListView();
            this.ExitButton = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU THÔNG TIN LAPTOP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductLineBox);
            this.panel1.Controls.Add(this.ProductLineLabel);
            this.panel1.Controls.Add(this.BrandNameBox);
            this.panel1.Controls.Add(this.BrandNameLabel);
            this.panel1.Location = new System.Drawing.Point(67, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 81);
            this.panel1.TabIndex = 1;
            // 
            // ProductLineBox
            // 
            this.ProductLineBox.FormattingEnabled = true;
            this.ProductLineBox.Location = new System.Drawing.Point(519, 30);
            this.ProductLineBox.Name = "ProductLineBox";
            this.ProductLineBox.Size = new System.Drawing.Size(121, 28);
            this.ProductLineBox.TabIndex = 3;
            // 
            // ProductLineLabel
            // 
            this.ProductLineLabel.AutoSize = true;
            this.ProductLineLabel.Location = new System.Drawing.Point(383, 33);
            this.ProductLineLabel.Name = "ProductLineLabel";
            this.ProductLineLabel.Size = new System.Drawing.Size(130, 20);
            this.ProductLineLabel.TabIndex = 2;
            this.ProductLineLabel.Text = "Dòng sản phẩm :";
            // 
            // BrandNameBox
            // 
            this.BrandNameBox.FormattingEnabled = true;
            this.BrandNameBox.Items.AddRange(new object[] {
            "Tất cả",
            "HP",
            "Dell"});
            this.BrandNameBox.Location = new System.Drawing.Point(170, 30);
            this.BrandNameBox.Name = "BrandNameBox";
            this.BrandNameBox.Size = new System.Drawing.Size(121, 28);
            this.BrandNameBox.TabIndex = 1;
            this.BrandNameBox.SelectedIndexChanged += new System.EventHandler(this.BrandNameBox_SelectedIndexChanged);
            // 
            // BrandNameLabel
            // 
            this.BrandNameLabel.AutoSize = true;
            this.BrandNameLabel.Location = new System.Drawing.Point(48, 33);
            this.BrandNameLabel.Name = "BrandNameLabel";
            this.BrandNameLabel.Size = new System.Drawing.Size(116, 20);
            this.BrandNameLabel.TabIndex = 0;
            this.BrandNameLabel.Text = "Hãng sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số sản phẩm tìm kiếm :";
            // 
            // CountProductText
            // 
            this.CountProductText.Location = new System.Drawing.Point(246, 397);
            this.CountProductText.Name = "CountProductText";
            this.CountProductText.Size = new System.Drawing.Size(100, 26);
            this.CountProductText.TabIndex = 4;
            // 
            // ProductListView
            // 
            this.ProductListView.HideSelection = false;
            this.ProductListView.Location = new System.Drawing.Point(27, 184);
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.Size = new System.Drawing.Size(761, 187);
            this.ProductListView.TabIndex = 6;
            this.ProductListView.UseCompatibleStateImageBehavior = false;
            this.ProductListView.View = System.Windows.Forms.View.Details;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitButton.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.ExitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ExitButton.BorderRadius = 5;
            this.ExitButton.BorderSize = 0;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(586, 390);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 40);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.TextColor = System.Drawing.Color.White;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // frmTracuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CountProductText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTracuu";
            this.Text = "mnuTracuu";
            this.Load += new System.EventHandler(this.frmTracuu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductLineLabel;
        private System.Windows.Forms.ComboBox BrandNameBox;
        private System.Windows.Forms.Label BrandNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountProductText;
        private CustomControls.RJControls.RJButton ExitButton;
        private System.Windows.Forms.ComboBox ProductLineBox;
        private System.Windows.Forms.ListView ProductListView;
    }
}