using ConvenienceStore.src.domain;
using ConvenienceStore.src.model;
using System;
using System.Collections.Generic;
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
            ProductsForm form = new ProductsForm();
            form.Show();
        }

        /// <summary>
        /// 주문 목록 리스트의 크기를 변경하지 못하도록 추가한 함수
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvOrders_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = lvOrders.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            // TODO 상품이 없을 때 경고 메시지 출력
            MessageBox.Show("결제 주문이 없습니다.");
        }
    }
}
