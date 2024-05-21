using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace UrlShortenerClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            string baseUrl = "http://localhost:8080/url";

            Console.WriteLine("Insira um URL para encurtar:");
            string longUrl = Console.ReadLine();

            string shortUrl = await ShortenURL(baseUrl, longUrl);
            Console.WriteLine("URL encurtada: " + shortUrl);

            Console.WriteLine("Pressione qualquer tecla para acessar o encurtador...");
            Console.ReadKey();

            await AccessShortURL(baseUrl, shortUrl);
        }

        static async Task<string> ShortenURL(string baseUrl, string longUrl)
        {
            var requestContent = new StringContent($"{{\"longUrl\": \"{longUrl}\"}}", System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync($"{baseUrl}/shorten", requestContent);
            response.EnsureSuccessStatusCode();
            string shortUrl = await response.Content.ReadAsStringAsync();
            return shortUrl.Trim('"');  
        }

        static async Task AccessShortURL(string baseUrl, string shortUrl)
        {
            HttpResponseMessage response = await client.GetAsync($"{baseUrl}/{shortUrl}");
            if (response.StatusCode == System.Net.HttpStatusCode.Found)
            {
                Uri redirectUri = response.Headers.Location;
                Console.WriteLine("Redirecionando...: " + redirectUri);
                Console.WriteLine("Pressione qualquer tecla para abrir no browser...");
                Console.ReadKey();
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = redirectUri.ToString(),
                    UseShellExecute = true
                });
            }
            else
            {
                Console.WriteLine("Falha em acessar a url encurtada.");
            }
        }
    }
}
