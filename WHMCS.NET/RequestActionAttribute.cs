using System;

namespace WHMCS.NET
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RequestActionAttribute : Attribute
    {
        public ApiActions Name { get; set; }

        public RequestActionAttribute(ApiActions name)
        {
            Name = name;
        }
    }
}