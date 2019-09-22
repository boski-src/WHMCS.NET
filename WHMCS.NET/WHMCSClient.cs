using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WHMCS.NET.Modules;
using WHMCS.NET.Modules.Auth;
using WHMCS.NET.Modules.Billing;
using WHMCS.NET.Modules.Client;
using WHMCS.NET.Modules.Order;

namespace WHMCS.NET
{
    public class WHMCSClient
    {
        private readonly Dictionary<Type, object> _modules = new Dictionary<Type, object>();
        public readonly WHMCSConfig LoadedConfig;
        private readonly HttpClient _httpClient;

        public WHMCSClient(WHMCSConfig config, HttpClient httpClient = null)
        {
            LoadedConfig = config;
            _httpClient = httpClient ?? new HttpClient();
            RegisterDefaultModules();
        }

        public void RegisterDefaultModules()
        {
            RegisterModule<AuthModule>();
            RegisterModule<ClientModule>();
            RegisterModule<OrderModule>();
            RegisterModule<BillingModule>();
        }

        public void RegisterModule<TModule>() where TModule : class, IModule, new()
        {
            if (_modules.ContainsKey(typeof(TModule)))
                return;

            var module = new TModule();
            module.Init(this);

            _modules.Add(typeof(TModule), module);
        }

        public void UnRegisterModule<TModule>() where TModule : class, IModule, new()
        {
            if (!_modules.ContainsKey(typeof(TModule)))
                return;

            _modules.Remove(typeof(TModule));
        }

        public TModule GetModule<TModule>() where TModule : class, IModule, new()
        {
            if (!_modules.ContainsKey(typeof(TModule)))
                throw new Exception("Module not found.");

            return (TModule) _modules[typeof(TModule)];
        }

        public async Task<TResponse> Execute<TRequest, TResponse>(TRequest request)
            where TRequest : BaseRequest where TResponse : BaseResponse
        {
            var build = request.Build(LoadedConfig, request);

            var content = new FormUrlEncodedContent(build);
            var response = await _httpClient.PostAsync(LoadedConfig.Url, content);

            var responseContent = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<TResponse>(responseContent);

            responseObject.IsSucceed = responseObject.Result == "success";
            responseObject.IsFailed = responseObject.Result == "error";

            if (LoadedConfig.ThrowErrors && responseObject.IsFailed)
                throw new WHMCSException(responseObject.Message);

            return responseObject;
        }
    }
}