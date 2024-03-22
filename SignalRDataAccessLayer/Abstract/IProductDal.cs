using SignalR.EntityLayer.Entities;

namespace SignalRDataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product> {

        List<Product> GetProductsWithCategories();

    }

   
    

}
