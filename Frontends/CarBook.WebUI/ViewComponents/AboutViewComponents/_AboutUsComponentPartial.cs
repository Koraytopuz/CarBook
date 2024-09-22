using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7169/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values =JsonConvert.DeserializeObject<List<string, object>>(jsonData);
            }
            return View();
        }
    }
}
