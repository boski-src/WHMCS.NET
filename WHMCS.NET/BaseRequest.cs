using System;
using System.Collections.Generic;
using System.Reflection;

namespace WHMCS.NET
{
    public class BaseRequest
    {
        public Dictionary<string, string> Build(WHMCSConfig config, BaseRequest request)
        {
            var attribute = GetType().GetCustomAttribute<RequestActionAttribute>();

            if (attribute is null)
            {
                throw new Exception("Invalid request.");
            }

            var dictionary = new Dictionary<string, string>();
            if (config.AuthType == AuthTypes.Login)
            {
                dictionary.Add("username", config.LoginCredentials.Username);
                dictionary.Add("password", config.LoginCredentials.Password);
            }

            if (config.AuthType == AuthTypes.API)
            {
                dictionary.Add("identifier", config.ApiCredentials.Identifier);
                dictionary.Add("secret", config.ApiCredentials.Secret);
            }

            dictionary.Add("action", attribute.Name.ToString());
            dictionary.Add("responsetype", "json");

            foreach (var key in request.GetType().GetProperties())
            {
                var value = key.GetValue(request);
                if (value is null) continue;

                dictionary.Add(key.Name.ToLower(), value.ToString());
            }

            return dictionary;
        }
    }
}