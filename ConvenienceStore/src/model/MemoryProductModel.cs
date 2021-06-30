

using ConvenienceStore.src.domain;

namespace ConvenienceStore.src.model
{
    class MemoryProductModel : IProductModel
    {
        private int Id = 0;
        private int ID
        {
            get { return ++Id; }
        }

        public Product CreateProduct(string name, int price)
        {
            return Product.Create(ID, name, price);
        }

        public void DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product EditProduct(int id, string editName, int editPrice)
        {
            throw new System.NotImplementedException();
        }

        public void SaveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
