using ConvenienceStore.src.domain;
using ConvenienceStore.src.model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MemoryProductModel memoryProductModel = new MemoryProductModel();
            Product product1 = memoryProductModel.CreateProduct("꼬북칩", 3000);
            Product product2 = memoryProductModel.CreateProduct("바나나", 2000);
            Product product3 = memoryProductModel.CreateProduct("초코", 2000);

            memoryProductModel.SaveProduct(product1);
            memoryProductModel.SaveProduct(product2);
            memoryProductModel.SaveProduct(product3);

            memoryProductModel.DeleteProduct(product1.Id);
            memoryProductModel.DeleteProduct(product3.Id);

            List<Product> products = memoryProductModel.GetProductList();
            products.ForEach(p =>
            {
                Console.WriteLine($"ID: {p.Id }" +
                $"\nName:{p.Name}" +
                $"\nPrice:{p.Price}\n");
                
            });
        }
    }
}
