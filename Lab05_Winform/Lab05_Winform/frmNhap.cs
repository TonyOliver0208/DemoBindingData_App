using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05_Winform
{
    public partial class frmNhap : Form
    {
        public frmNhap()
        {
            InitializeComponent();
            BrandNameBox.SelectedItem = "HP";
        }
        private void AddDataButton_Click(object sender, EventArgs e)
        {
            if (BrandNameBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(ProductLineText.Text) ||
                string.IsNullOrWhiteSpace(ProductNameText.Text) || string.IsNullOrWhiteSpace(SpecificationText.Text) ||
                string.IsNullOrWhiteSpace(PriceText.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (BrandNameBox.SelectedItem.ToString() == "HP")
            {
                if (ProductLineText.Text != "X" && ProductLineText.Text != "M")
                {
                    MessageBox.Show("Dòng sản phẩm không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (BrandNameBox.SelectedItem.ToString() == "Dell")
            {
                if (ProductLineText.Text != "N" && ProductLineText.Text != "F")
                {
                    MessageBox.Show("Dòng sản phẩm không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                string computerName = Environment.MachineName;

                string insertQuery = "INSERT INTO Laptop (brandName, productLine, productName,specification,price) VALUES (@brandName, @productLine, @productName,@specification,@price)"; // Replace with your actual table and column names

                using (SqlConnection connection = new SqlConnection($@"Server={computerName}\SQLEXPRESS;Database=LaptopManagement;Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        string price = PriceText.Text;
                        if (PriceText.Text.Contains("."))                       
                            price = PriceText.Text.Replace(".", "");
                        
                        command.Parameters.AddWithValue("@brandName", BrandNameBox.Text);
                        command.Parameters.AddWithValue("@productLine", ProductLineText.Text);
                        command.Parameters.AddWithValue("@productName", ProductNameText.Text);
                        command.Parameters.AddWithValue("@specification", SpecificationText.Text);
                        command.Parameters.AddWithValue("@price", price );

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BrandNameBox.SelectedIndex = -1;
                        ProductLineText.Text = "";
                        ProductNameText.Text = "";
                        SpecificationText.Text = "";
                        PriceText.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteDataButton_Click(object sender, EventArgs e)
        {
            if (BrandNameBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(ProductLineText.Text) ||
                string.IsNullOrWhiteSpace(ProductNameText.Text) || string.IsNullOrWhiteSpace(SpecificationText.Text) ||
                string.IsNullOrWhiteSpace(PriceText.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (BrandNameBox.SelectedItem.ToString() == "HP")
            {
                if (ProductLineText.Text != "X" && ProductLineText.Text != "M")
                {
                    MessageBox.Show("Dòng sản phẩm không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (BrandNameBox.SelectedItem.ToString() == "Dell")
            {
                if (ProductLineText.Text != "N" && ProductLineText.Text != "F")
                {
                    MessageBox.Show("Dòng sản phẩm không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                string filePath = Path.Combine(Application.StartupPath, "list.txt");
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    string line = $"{BrandNameBox.SelectedItem}|{ProductLineText.Text}|{ProductNameText.Text}|{SpecificationText.Text}|{PriceText.Text}";
                    writer.WriteLine(line); 
                }
                MessageBox.Show("Ghi dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
