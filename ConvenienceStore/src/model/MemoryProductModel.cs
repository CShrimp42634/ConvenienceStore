using ConvenienceStore.src.domain;
using System.Collections.Generic;

namespace ConvenienceStore.src.model
{
    class MemoryProductModel : IProductModel
    {
        // 상품 저장 공간
        private Dictionary<int, Product> Products = new Dictionary<int, Product>();

        private int Id = 0;
        private int ID
        {
            get { return ++Id; }
        }

        public Product CreateProduct(string name, int price)
        {
            return Product.Create(ID, name, price);
        }

        public void SaveProduct(Product product)
        {
            Products.Add(product.Id, product);
        }

        public List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            // 이너뮬레이터 - 반복자
            Dictionary<int, Product>.Enumerator enumerator = Products.GetEnumerator();

            while (enumerator.MoveNext())
                list.Add(enumerator.Current.Value);

            return list;
        }

        /// <summary>
        /// Edit 함수를 위한 생성 함수.
        /// </summary>
        /// <param name="id">수정이 필요한 상품의 아이디</param>
        /// <param name="name">수정된 이름</param>
        /// <param name="price">수정된 가격</param>
        /// <returns></returns>
        private Product ECreateProduct(int id, string name, int price)
        {
            return Product.Create(id, name, price);
        }

        //Edit (에딧ㅌ) - 수정
        public Product EditProduct(int id, string editName, int editPrice)
        {
            // 불변성
            Product product = ECreateProduct(id, editName, editPrice);
            Products[id] = product;

            return product;
        }
        //Delete(델리트) - 삭제
        public void DeleteProduct(int id)
        {
            Products.Remove(id);
        }
    }
}
