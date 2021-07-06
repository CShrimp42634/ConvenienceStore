using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void lvProducts_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lvProducts.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductDialog addProductDialog = new AddProductDialog();
            addProductDialog.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProductDialog editProductDialog = new EditProductDialog();
            editProductDialog.ShowDialog();
        }
    }
}
