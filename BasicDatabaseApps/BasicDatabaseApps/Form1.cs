using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicDatabaseApps.BLL;
using BasicDatabaseApps.DLL.DAO;

namespace BasicDatabaseApps
{
    public partial class ProductEntityUi : Form
    {
        private ProductEntityBll productEntityBll;
        private ProductInfo productInfo;

        public ProductEntityUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            productEntityBll = new ProductEntityBll();
            productInfo = new ProductInfo();

            productInfo.ProductCode = productCodeTextBox.Text;
            productInfo.ProductName = productNameTextBox.Text;
            productInfo.Quantity =Convert.ToInt32((quantityTextBox.Text));

            string meg = productEntityBll.Save(productInfo);
            MessageBox.Show(meg);

            textBox4.Text = productEntityBll.GetTotalQuantity();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            ViewProductInfo.Items.Clear();
            productEntityBll = new ProductEntityBll();
            List<ProductInfo> productInfoList = productEntityBll.GetViewAll();

            foreach (ProductInfo productInfos in productInfoList)
            {
                productEntityBll = new ProductEntityBll();
                ListViewItem item=new ListViewItem(productInfos.ProductCode);
                item.SubItems.Add(productInfos.ProductName);
                item.SubItems.Add(productInfos.Quantity.ToString());

               ViewProductInfo.Items.Add(item);
            }
            
        }
        }
    }

