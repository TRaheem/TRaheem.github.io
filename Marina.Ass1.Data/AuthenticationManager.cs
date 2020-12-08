using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Ass1.Data
{
    public class AuthenticationManager
    {
        public static CustomerDTO Authenticate(string firstname, string lastname)
        {
            CustomerDTO dto = null;
            var db = new MarinaEntities();
            var auth = db.Customers.SingleOrDefault
                (c => c.FirstName == firstname && c.LastName == lastname);

            if (auth != null)
            {
                // if the authentication is null the user is not a customer
                dto = new CustomerDTO
                {
                    ID = auth.ID,
                    FullName = $"{auth.FirstName} {auth.LastName}",
                };
            }
            return dto;
        }

        public static Customer Find(int customerId)
        {
            var db = new MarinaEntities();
            var auth = db.Customers.SingleOrDefault(c => c.ID == customerId);
            return auth;
        }

        public static void Add(Customer auth)
        {
            var db = new MarinaEntities();
            db.Customers.Add(auth);
            db.SaveChanges();
        }

        //public static void Remove(Slip auth)
        //{
        //    var db = new MarinaEntities();
        //    db.Slips.Remove(auth);
        //    db.SaveChanges();
        //}

        public static void Update(Customer auth)
        {
            var db = new MarinaEntities();
            var authFromContext = db.Customers.SingleOrDefault(c => c.ID == auth.ID);
          
            authFromContext.FirstName = auth.FirstName;
            authFromContext.LastName = auth.LastName;
            authFromContext.City = auth.City;
            authFromContext.Phone = auth.Phone;
            db.SaveChanges();
        }

        public static void Add(Lease authlease)
        {
            var db = new MarinaEntities();
            db.Leases.Add(authlease);
            db.SaveChanges();
        }

        //public static void Update(Lease auth)
        //{
        //    var db = new MarinaEntities();
        //    var authFromContext = db.Leases.SingleOrDefault(c => c.ID == auth.ID);
        //    authFromContext.CustomerID = auth.CustomerID;
        //    authFromContext.SlipID = auth.SlipID;
        //    db.SaveChanges();
        //}
    }
}
