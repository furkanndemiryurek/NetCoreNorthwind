using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    //İş yapan classları oluşturmadan önce onun interfaceini oluştur. ALTERNATİFİ OLMASA BİLE. 
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
