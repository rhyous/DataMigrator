﻿using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.StringLibrary;
using System.Text;

namespace Rhyous.DataMigration.Salesforce
{

    public class AccountCreator : IAccountCreator
    {
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;
        private readonly ILogger _Logger;

        public AccountCreator(ISerializer serializer,
                              IHttpClientFactory httpClientFactory,
                              ILogger logger)
        {
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
            _Logger = logger;
        }

        public async Task<Account> CreateAsync(Account account, string instanceUrl, string accessToken)
        {
            // Post account to Salesforce
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var json = _Serializer.Serialize(account);
            var content = new StringContent(json, Encoding.UTF8, Constants.JsonContentType);
            var postUrl = StringConcat.WithSeparator('/', instanceUrl, Constants.SObjectSubPath, nameof(Account));
            var request = new HttpRequestMessage(HttpMethod.Post, postUrl);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Constants.Bearer, accessToken);
            request.Content = content;
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                _Logger.Log($"Failed to create account. {json}");
                return null;
            }
            var createdJson = response.Content.ReadAsStringAsync();
            // Update account from response
            return account;
        }
    }
}
