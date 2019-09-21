namespace WHMCS.NET.Modules
{
    public class Module : IModule
    {
        protected WHMCSClient Client;

        public void Init(WHMCSClient client)
        {
            Client = client;
        }
    }
}