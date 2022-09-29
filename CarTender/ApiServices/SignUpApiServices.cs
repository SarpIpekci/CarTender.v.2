using CarTender.Models.DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarTender.ApiServices
{
    public class SignUpApiServices
    {
        HttpClient _client;

        public SignUpApiServices(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> AddSignUpUser(AddSignUpDTO dto)
        {
            var str = new StringContent(JsonConvert.SerializeObject(dto));
            str.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _client.PostAsync("SignUp/Register", str);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            return null;
        }
    }
}
