using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestContainer;
using TestContainer.Dao;
using TestContainer.LookUpMethod;
using TestContainer.Services;

namespace TestContainer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Form1());

                IApplicationContext context = new XmlApplicationContext(
                     "~/Config/services.xml",
                     "~/Config/daos.xml");
                var PetStore = context.GetObject("PetStore");
                var AccountDao = context.GetObject("AccountDao");
                var ItemDao = context.GetObject("ItemDao");
                var petstore = SpringHelper.GetObject<PetStoreService>("PetStore");
                var petstore1 = SpringHelper.GetObject<PetStoreService>("PetStore1");
                var accountDao = SpringHelper.GetObject<HibernateAccountDao>("AccountDao");
                var itemDao = SpringHelper.GetObject<HibernateItemDao>("ItemDao");
                var innerService = SpringHelper.GetObject<PetStoreService.InnerService>("InnerService");

                var myFilteredIntList = SpringHelper.GetObject<FilterableList<int>>("filterList");

                var v1 = SpringHelper.GetObject<MyClass1>("myClass1");
                var v2 = SpringHelper.GetObject<MyClass1>("myClass1");
                var h1 = v1.GetHashCode();
                var h2 = v2.GetHashCode();

                var v3 = v1.CreatSingleShotHelper();
                var v4 = v1.CreatSingleShotHelper();


                var v = SpringHelper.GetObject<FactoryObject.Person>("person1");

                var v5 = SpringHelper.GetObject<string>("personname");
                var v6 = SpringHelper.GetObject<object>("personeye");
                var v7 = SpringHelper.GetObject<string>("persongender");
                var v8 = SpringHelper.GetObject<string>("personsay");
                var v9 = SpringHelper.GetObject<string>("personsay2");

                var v10 = SpringHelper.GetObject<int>("age1");
                //var v6 = v5.TargetProperty;

                //var v7 = SpringHelper.GetObject<FactoryObject.XmlObjectFactoryTests.MyTestObject>("cultureAware");

                //var v8 = SpringHelper.GetObject<FactoryObject.XmlObjectFactoryTests.MyTestObject>("instancePropertyCultureAware");
            }
            catch (Exception ee)
            {
            }

        }
    }
}
