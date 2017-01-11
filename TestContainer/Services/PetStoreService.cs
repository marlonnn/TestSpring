using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestContainer.Dao;

namespace TestContainer.Services
{
    public class PetStoreService
    {
        private HibernateAccountDao AccountDao;
        private HibernateItemDao ItemDao;


        //public PetStoreService(HibernateAccountDao accountDao, HibernateItemDao itemDao)
        //{

        //}
        private string myProp;

        private DateTime date;
        public class InnerService
        {

        }

        public static PetStoreService CreateInstance()
        {
            return new PetStoreService();
        }
    }
}
