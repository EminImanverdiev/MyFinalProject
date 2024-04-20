using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	public class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();
			ProductDetailTest();
			//GetUnitPrice();
		}

	

		private static void ProductDetailTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			var result = productManager.GetAll();
			if (result.Success == true)
			{
				foreach (var product in productManager.GetAll().Data)
				{
					Console.WriteLine(product.ProductName);
				}
			}
			else { Console.WriteLine(result.Message); }
			
		}

	
	}
}