using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();
            #region Car
            var responseMessage = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarCount");
            {
                int v1 = random.Next(0, 101);

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.v = values.carCount;
                ViewBag.v1 = v1;
            }
            #endregion
            #region Location
            var responseMessage2 = await client.GetAsync("https://localhost:7169/api/Statistics/GetLocationCount");
            {
                int locationCountRandom = random.Next(0, 101);

                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.locationCount = values2.locationCount;
                ViewBag.locationCountRandom = locationCountRandom;
            }
            #endregion
            #region Brand
            var responseMessage3 = await client.GetAsync("https://localhost:7169/api/Statistics/GetBrandCount");
            {
                int brandCountRandom = random.Next(0, 101);

                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.brandCount = values3.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion
            #region avgPriceForDaily
            var responseMessage4 = await client.GetAsync("https://localhost:7169/api/Statistics/GetAvgRentPriceForDaily");
            {
                int avgPriceForDailyRandom = random.Next(0, 101);

                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.avgPriceForDaily = values4.avgPriceForDaily.ToString("0.00");
                ViewBag.avgPriceForDailyRandom = avgPriceForDailyRandom;
            }
            #endregion
            return View();
        }
    }
}
