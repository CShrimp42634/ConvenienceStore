namespace ConvenienceStore.src.domain
{
    /// <summary>
    /// 상품
    /// </summary>
    class Product
    {
        /// <summary>
        /// 상품 아아디
        /// </summary>
        public int Id { get; private set; }
        /// <summary>
        /// 상품 이름
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 상품 가격
        /// </summary>
        public int Price { get; private set; }

        /// <summary>
        /// 상품 설명
        /// </summary>
        public string Description;

        /// <summary>
        /// 생성자 (외부 생성 차단)
        /// </summary>
        protected Product()
        {

        }

        public override string ToString()
        {
            return $"상품명:{Name} | 가격: {Price}";
        }

        /// <summary>
        /// Product 생성 함수
        /// </summary>
        /// <param name="Name">상품 명</param>
        /// <param name="Price">상품 가격</param>
        /// <returns>상품</returns>
        public static Product Create(int id ,string Name, int Price)
        {
            Product product = new Product();
            product.Id = id;
            product.Name = Name;
            product.Price = Price;

            return product;
        }
    }
}
