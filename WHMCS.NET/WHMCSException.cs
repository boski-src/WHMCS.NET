using System;

namespace WHMCS.NET
{
    public class WHMCSException : Exception
    {
        public WHMCSException(string message) : base(message)
        {
        }
    }
}