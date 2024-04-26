using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> GetAll();
		IDataResult<List<ProductDetailDto>> GetProductDetails();
		IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
		IResult Add(Product product);
		IResult Update(Product product);
		IDataResult<Product> GetById(int productId);

	}
}
