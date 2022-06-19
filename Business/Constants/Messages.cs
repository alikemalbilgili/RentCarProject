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
        public static string UnkownError = "Unkown error.";
        public static string CarAdded = "Car was added";
        public static string CarDeleted = "Car was deleted";
        public static string CarUpdated = "Car was updated";
        public static string CarNameInvalid = "Car name is invalid";
        public static string MaintenanceTime = "Sorry,maintenance time";
        public static string CarsListed = "Cars were listed";
        public static string ColorAdded = "Color was added";
        public static string ColorDeleted = "Color was deleted";
        public static string ColorUpdated = "Color was updated";
        public static string BrandAdded = "Brand was added";
        public static string BrandDeleted = "Brand was deleted";
        public static string BrandUpdated = "Brand was updated";
        public static string RentalAdded;
        public static string RentalDeleted;
        public static string RentalUpdated;
        public static string RentalListed;
        public static string UserAdded;
        public static string UserDeleted;
        public static string UsersListed;
        public static string UserUpdated;
        public static string CustomerAdded;
        public static string CustomerDeleted;
        public static string CustomersLİsted;
        public static string CustomerUpdated;
        public static string ReturnRentalError;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;
        public static string AuthorizationDenied;
        public static string UserRegistered;
    }
}
    