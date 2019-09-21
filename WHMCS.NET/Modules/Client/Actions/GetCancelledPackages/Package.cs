using System;

namespace WHMCS.NET.Modules.Client.Actions.GetCancelledPackages
{
    public class Package
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RelId { get; set; }
        public string Reason { get; set; }
        public string Type { get; set; }
        public string Created_At { get; set; }
        public string Updated_At { get; set; }
    }
}