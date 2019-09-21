using System.Threading.Tasks;

namespace WHMCS.NET.Modules.Auth
{
    public class AuthModule : Module
    {
        public async Task<ValidateLoginResponse> ValidateLogin(string email, string password)
        {
            var request = new ValidateLoginRequest {
                Email = email,
                Password2 = password
            };

            return await Client.Execute<ValidateLoginRequest, ValidateLoginResponse>(request);
        }
    }
}