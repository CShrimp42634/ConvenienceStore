
namespace ConvenienceStore
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPayment = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCountUp = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productsPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("굴림", 20F);
            this.btnPayment.Location = new System.Drawing.Point(676, 341);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(112, 71);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "결제";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "받을 금액";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(103, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 29);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 20F);
            this.button2.Location = new System.Drawing.Point(676, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 71);
            this.button2.TabIndex = 5;
            this.button2.Text = "결제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 20F);
            this.button3.Location = new System.Drawing.Point(676, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 71);
            this.button3.TabIndex = 6;
            this.button3.Text = "결제";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("굴림", 20F);
            this.button4.Location = new System.Drawing.Point(676, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 71);
            this.button4.TabIndex = 7;
            this.button4.Text = "결제";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 20F);
            this.button5.Location = new System.Drawing.Point(676, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 71);
            this.button5.TabIndex = 8;
            this.button5.Text = "결제";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnCountUp
            // 
            this.btnCountUp.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCountUp.Location = new System.Drawing.Point(14, 277);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(97, 36);
            this.btnCountUp.TabIndex = 9;
            this.btnCountUp.Text = "상품 추가";
            this.btnCountUp.UseVisualStyleBackColor = true;
            // 
            // btnCountDown
            // 
            this.btnCountDown.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCountDown.Location = new System.Drawing.Point(117, 277);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(97, 36);
            this.btnCountDown.TabIndex = 10;
            this.btnCountDown.Text = "상품 제거";
            this.btnCountDown.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(220, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 138);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox3.Location = new System.Drawing.Point(103, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 29);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(103, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "거스름돈";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "받은 금액";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.productCount,
            this.productPrice,
            this.productsPrice});
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(13, 13);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(651, 258);
            this.lvOrders.TabIndex = 12;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvOrders_ColumnWidthChanging);
            // 
            // productName
            // 
            this.productName.Text = "상품 명";
            this.productName.Width = 364;
            // 
            // productCount
            // 
            this.productCount.Text = "상품 수량";
            this.productCount.Width = 75;
            // 
            // productPrice
            // 
            this.productPrice.Text = "단품 가격";
            this.productPrice.Width = 104;
            // 
            // productsPrice
            // 
            this.productsPrice.Text = "도합 가격";
            this.productsPrice.Width = 104;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCountDown);
            this.Controls.Add(this.btnCountUp);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCountUp;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productCount;
        private System.Windows.Forms.ColumnHeader productPrice;
        private System.Windows.Forms.ColumnHeader productsPrice;
    }
}

