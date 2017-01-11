using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer
{
    public class TestGenericObjectFactory
    {
        public static TestGenericObject<V, W> StaticCreateInstance<V, W>()
        {
            return new TestGenericObject<V, W>();
        }

        public TestGenericObject<V, W> CreateInstance<V, W>()
        {
            return new TestGenericObject<V, W>();
        }
    }
}
