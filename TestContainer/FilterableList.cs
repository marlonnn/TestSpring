using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer
{
    public class FilterableList<T>
    {
        private List<T> list;
        private string name;
        public List<T> Contents
        {
            get { return this.list; }
            set { list = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<T> ApplyFilter(string filterExpression)
        {
            return new List<T>();
        }

    }
}
