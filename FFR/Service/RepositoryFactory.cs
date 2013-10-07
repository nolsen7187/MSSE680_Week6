using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Service
{
    public class RepositoryFactory
    {
        public static IDataRepository Create(string sRepositoryType)
        {
            IDataRepository objRepo;
            switch (sRepositoryType)
            {
                case "Customer":
                    objRepo = new DataRepository<Customer>();
                    break;
                default:
                    objRepo = null;
                    break;
            }
            return objRepo;
        }
    }



}
