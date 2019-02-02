using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class JokeProcessor
    {
        public static async Task<JokeModel> LoadJoke()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("http://api.icndb.com/jokes/random"))
            {
                if (response.IsSuccessStatusCode)
                {
                    JokeModelValue result = await response.Content.ReadAsAsync<JokeModelValue>();
                    return result.Value;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
