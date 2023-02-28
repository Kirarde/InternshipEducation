using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürün(ler) listelendi";
        public static string MaintenanceTime = "İş saatleri dışında olduğunuz için işleminiz tamamlanmamıştır";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde başka bir ürün var";
        public static string ProductCategoryOverflow="Kategori sayısı limiti aştığı için ürün eklenemez";
        public static string AuthorizationDenied;
        public static string UserNotFound;
        public static string PasswordError;
        public static string UserRegistered;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
    }
}
