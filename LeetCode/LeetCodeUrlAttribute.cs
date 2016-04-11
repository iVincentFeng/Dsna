using System;

namespace Dsna.LeetCode
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class LeetCodeUrlAttribute : Attribute
    {
        public LeetCodeUrlAttribute(string url, bool isFollowUp)
        {
            this.Url = url;
            this.IsFollowUp = IsFollowUp;
        }

        public string Url
        {
            get;
            private set;
        }

        public bool IsFollowUp
        {
            get;
            private set;
        }
    }
}
