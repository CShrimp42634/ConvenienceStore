using ConvenienceStore.src.domain;
using System.Collections.Generic;

namespace ConvenienceStore.src.model
{
    /// <summary>
    /// 상품 모델 인터페이스
    /// </summary>
    interface IProductModel
    {
        /// <summary>
        /// 상품 생성 함수
        /// </summary>
        /// <param name="name">상품 명</param>
        /// <param name="price">상품 가격</param>
        /// <returns>생성된 상품</returns>
        Product CreateProduct(string name, int price);

        // 한개 불러오기

        /// <summary>
        /// 상품 모두 불러오기
        /// </summary>
        /// <returns>상품목록</returns>
        List<Product> GetProductList();

        /// <summary>
        /// 상품 내용 수정 함수
        /// </summary>
        /// <param name="id">수정할 상품 아이디</param>
        /// <param name="editName">수정할 상품 명</param>
        /// <param name="editPrice">수정할 상품 가격</param>
        /// <returns>수정된 상품</returns>
        Product EditProduct(int id, string editName, int editPrice);

        /// <summary>
        /// 상품 삭제 함수
        /// <param name="id">삭제할 상품 아이디</param>
        /// </summary>
        void DeleteProduct(int id);

        /// <summary>
        /// 상품 저장 함수
        /// </summary>
        /// <param name="product">저장될 상품</param>
        void SaveProduct(Product product);
    }
}
