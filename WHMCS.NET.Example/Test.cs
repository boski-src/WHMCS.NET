using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WHMCS.NET.Modules.Client;

namespace WHMCS.NET.Example
{
    public class Test
    {
        public async Task Run()
        {
            var apiCredentials = new APICredentials(
                "ID",
                "SECRET"
            );

//            var loginCredentials = new LoginCredentials(
//                "USERNAME",
//                "PASSWORD"
//            );

            var config = new WHMCSConfig("https://www.domain.com/panel/includes/api.php", apiCredentials);
            var client = new WHMCSClient(config);

            var response = await client.GetModule<ClientModule>().Browse();
            Console.WriteLine(JsonConvert.SerializeObject(response));
        }
    }
}