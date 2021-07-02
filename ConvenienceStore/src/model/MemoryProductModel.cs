

using ConvenienceStore.src.domain;
using System.Collections.Generic;

namespace ConvenienceStore.src.model
{
    class MemoryProductModel : IProductModel
    {
        private new Dictionary<int, Product> Products = new Dictionary<int, Product>();

        private int Id = 0;

        public object Current { get; private set; }

        private int ID
        {
            get { return ++Id; }
        }

        public Product CreateProduct(string name, int price)
        {
            return Product.Create(ID, name, price);
        }

        //Delete (델리트) - 삭제
        public void DeleteProduct(int id)
        {
            Products.Remove(id);
        }

        //Edit (에딧ㅌ)
        public Product EditProduct(int id, string editName, int editPrice)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProductList()
        {
            List<Product> Iist = new List<Product>();
            //이너뮬레이터 - 반복자
            Dictionary<int, Product>.Enumerator enumerator = Products.GetEnumerator();
            

            while (enumerator.MoveNext())
                Iist.Add(enumerator.Current.Value);

            return Iist;
        }

        public void SaveProduct(Product product)
        {
            Products.Add(product.Id, product);
        }
    }
}
