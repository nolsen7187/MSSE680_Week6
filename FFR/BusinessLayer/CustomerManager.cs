using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Service;

namespace BusinessLayer
{
    public class CustomerManager
    {
        // add a contact to the table
        public void Insert(Customer oContact)
        {
            var customertRepo = Service.RepositoryFactory.Create("Customer");
            customertRepo.Create(oContact);
        }

        
    }
}
