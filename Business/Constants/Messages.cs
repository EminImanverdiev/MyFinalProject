using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Mehsul elave edildi";
		public static string ProductNameInvalid = "Mehsul adi elcatan deyil";
		public static string MaintenanceTime = "Sistem Bakimdadir!";
		public static string ProductsListed = "Mehsullar Listelendi";
		public static string ProductCountOfCategoryError = "Bir kategoriyada max 10 mehsul ola biler";
        public static string ProductNameAlreadyExists = "Bu Mehsuldan artiq var";

		public static string CategoryLimitExceded = "Kategorya limitini kecdizniz";
		public static string? AuthorizationDenied="Icazeniz yoxdur/...";
		internal static string UserRegistered;
		internal static User UserNotFound;
		internal static User PasswordError;
		internal static string SuccessfulLogin;
		internal static string UserAlreadyExists;
		internal static string AccessTokenCreated;
	} }
