using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
	public class Program
	{
		static void Main(string[] args)
		{
			EfProductDal product=new EfProductDal();
			
            foreach (var item in product.GetAll())
            {
                Console.WriteLine(item);
            }
        }

	}
}