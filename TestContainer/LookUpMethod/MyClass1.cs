using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer.LookUpMethod
{
    public class MyClass1
    {
        public virtual SingleShotHelper CreatSingleShotHelper()
        {
            return new SingleShotHelper();
        }

    }
}
