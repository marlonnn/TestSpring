using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer
{
    public class TestGenericObject<T, U>
    {
        public TestGenericObject()
        {

        }

        private IList<T> someGenericList = new List<T>();

        private IDictionary<string, U> someStringKeyedDic = new Dictionary<string, U>();

        public IList<T> SomeGenericList
        {
            get { return this.someGenericList; }
            set { this.someGenericList = value; }
        }

        public IDictionary<string, U> SomeStringKeyedDic
        {
            get { return this.someStringKeyedDic; }
            set { this.someStringKeyedDic = value; }
        }
    }
}
