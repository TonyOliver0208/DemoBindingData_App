using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05_Winform
{
    public partial class frmTracuu : Form
    {
        private List<string[]> dataList;
        public frmTracuu()
        {
            InitializeComponent();            
        }
        private void frmTracuu_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "list.txt");

            if (File.Exists(filePath))
            {
                try
                {
                    ProductListView.Items.Clear();
                    ProductListView.Columns.Clear();
                    ProductListView.GridLines = true;

                    //ProductListView.Columns.Add("Brand");
                    //ProductListView.Columns.Add("Product Line");
                    ProductListView.Columns.Add("Sản phẩm");
                    ProductListView.Columns.Add("Thông số kỹ thuật");
                    ProductListView.Columns.Add("Giá bán");

                    foreach (ColumnHeader column in ProductListView.Columns)
                    {
                        column.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                        column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    ProductListView.Columns[0].Width = 100;
                    ProductListView.Columns[1].Width = 500;

                    dataList = ReadDataFromFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi đọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
            }

            BrandNameBox.SelectedIndexChanged += BrandNameBox_SelectedIndexChanged;
            ProductLineBox.SelectedIndexChanged += ProductLineBox_SelectedIndexChanged;
        }
        private List<string[]> ReadDataFromFile(string filePath)
        {
            List<string[]> dataList = new List<string[]>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        dataList.Add(parts);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataList;
        }
        private void DisplayProductInListView(List<string[]> dataList)
        {
            ProductListView.Items.Clear();

            foreach (string[] data in dataList)
            {
                string[] lastThreeElements = data.Skip(Math.Max(0, data.Length - 3)).ToArray();
                ListViewItem item = new ListViewItem(lastThreeElements);
                ProductListView.Items.Add(item);
            }
            CountProductText.Text = dataList.Count.ToString();
        }
        private void BrandNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrandName = BrandNameBox.SelectedItem.ToString();
            List<string[]> filteredList;

            if (selectedBrandName == "HP" && ProductLineBox.SelectedIndex == -1)
            {
                filteredList = dataList.Where(data => data[0] == selectedBrandName).ToList();
                DisplayProductInListView(filteredList);
                ProductLineBox.DataSource = new List<string> { "X", "M" };
            }
            else if (selectedBrandName == "Dell" && ProductLineBox.SelectedIndex == -1)
            {
                filteredList = dataList.Where(data => data[0] == selectedBrandName).ToList();
                DisplayProductInListView(filteredList);
                ProductLineBox.DataSource = new List<string> { "N", "F" };
            }
            else
            {
                DisplayProductInListView(dataList);
                ProductLineBox.DataSource = null;
            }
            
            ProductLineBox.SelectedIndex = -1;
        }

        private void ProductLineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrandName = BrandNameBox.SelectedItem.ToString();
            string selectedProductLine = ProductLineBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProductLine))
            {
                List<string[]> filteredList = dataList.Where(data => data[0] == selectedBrandName && data[1] == selectedProductLine).ToList();
                DisplayProductInListView(filteredList);
            }
            else
            {
                List<string[]> filteredList = dataList.Where(data => data[0] == selectedBrandName).ToList();
                DisplayProductInListView(filteredList);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
