
using System.Net.Http;
using System.Threading.Tasks;

namespace parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;

        readonly string url;

        private string GetFullUrl(string BaseUrl, string Prefix )
        {
            if (Prefix != null)
                return $"{BaseUrl}/{Prefix}";
            else
                return $"{BaseUrl}";

        }

        public HtmlLoader(IParserSettings settings)
        {

            client = new HttpClient();

            url = GetFullUrl(settings.BaseUrl, settings.Prefix);
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }

    }
}
