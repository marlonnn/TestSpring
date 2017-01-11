using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer
{
    public class SpringHelper
    {
        private static IApplicationContext context = GetContext();

        public static IApplicationContext GetContext()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            return ctx;
        }

        /// <summary>
        /// 根据配置名称得到实例
        /// </summary>
        /// <typeparam name="T">参数类型</typeparam>
        /// <param name="name">配置文件中的object id值</param>
        /// <returns></returns>
        public static T GetObject<T>(string name)
        {
            return context.GetObject<T>(name);
        }
    }
}
