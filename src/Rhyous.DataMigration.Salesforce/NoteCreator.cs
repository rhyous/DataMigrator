using Rhyous.DataMigration.Salesforce.Interfaces;
using Rhyous.DataMigration.Salesforce.Models;
using Rhyous.StringLibrary;
using System.Text;

namespace Rhyous.DataMigration.Salesforce
{
    public class NoteCreator
    {
        private readonly ISerializer _Serializer;
        private readonly IHttpClientFactory _HttpClientFactory;
        private readonly ILogger _Logger;

        public NoteCreator(ISerializer serializer,
                           IHttpClientFactory httpClientFactory,
                           ILogger logger)
        {
            _Serializer = serializer;
            _HttpClientFactory = httpClientFactory;
            _Logger = logger;
        }

        public async Task<Note> CreateAsync(Note note, string instanceUrl, string accessToken)
        {
            // Post Note to Account to Salesforce
            var client = _HttpClientFactory.GetHttpClient(instanceUrl);
            var json = _Serializer.Serialize(note);
            var content = new StringContent(json, Encoding.UTF8, Constants.JsonContentType);
            var postUrl = StringConcat.WithSeparator('/', instanceUrl, Constants.SObjectSubPath, nameof(Note));
            var request = new HttpRequestMessage(HttpMethod.Post, postUrl);
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(Constants.Bearer, accessToken);
            request.Content = content;
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                _Logger.Log($"Failed to create Note. {json}");
                return null;
            }
            var createdJson = response.Content.ReadAsStringAsync();
            // Update Note from response
            return note;
        }

    }
}
