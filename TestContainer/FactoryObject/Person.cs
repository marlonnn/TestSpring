using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContainer.FactoryObject
{
    public class Person
    {
        public string name { get; set; } //属性
        public static object eye { get; set; }//静态属性

        public string gender;//域

        public static string say(string word1, string word2, string word3)
        {
            return string.Format("说：{0}-{1}-{2}", word1, word2, word3);
        }

        public string say2(string word1, string word2, string word3)
        {
            return string.Format("说：{0}-{1}-{2}", word1, word2, word3);
        }
    }
}
