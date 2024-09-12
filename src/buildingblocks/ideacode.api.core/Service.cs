using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace ideacode.api.core
{
    public abstract class HttpService
    {
        protected readonly HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected StringContent ObterConteudo(object dado)
        {
            return new StringContent(
                JsonConvert.SerializeObject(dado),
                Encoding.UTF8,
                "application/json");
        }
        
        protected async Task<T> DeserializarObjetoResponse<T>(HttpResponseMessage responseMessage)
        {
            var message = await responseMessage.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(message);
        }
    }
}