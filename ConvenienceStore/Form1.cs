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
            Product product = memoryProductModel.CreateProduct("꼬북칩", 3000);
            Console.WriteLine($"ID: {product.Id}" +
                $"\nName:{product.Name}" +
                $"\nPrice:{product.Price}");


            Product product2 = memoryProductModel.CreateProduct("바나나킥", 3000);
            Console.WriteLine($"ID: {product2.Id}" +
                $"\nName:{product2.Name}" +
                $"\nPrice:{product2.Price}");
        }
    }
}
