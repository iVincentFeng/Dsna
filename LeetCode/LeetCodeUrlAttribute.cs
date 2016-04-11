using System;

namespace Dsna.LeetCode
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class LeetCodeUrlAttribute : Attribute
    {
        public LeetCodeUrlAttribute(string url)
        {
            this.Url = url;
        }

        public string Url
        {
            get;
            private set;
        }
    }
}
