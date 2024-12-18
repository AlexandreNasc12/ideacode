using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace ideacode.api.core
{
    public abstract class Service
    {
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