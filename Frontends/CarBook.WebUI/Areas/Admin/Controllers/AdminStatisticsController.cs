using CarBook.Dto.AuthorDtos;
using CarBook.Dto.StatisticsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]

        public async Task<IActionResult> Index()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();
            #region Car
            var responseMessage = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarCount");
            {
                int v1=random.Next(0, 101);

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
            #region Author
            var responseMessage3 = await client.GetAsync("https://localhost:7169/api/Statistics/GetAuthorCount");
            {
                int authorCountRandom = random.Next(0, 101);

                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.authorCount = values3.authorCount;
                ViewBag.authorCountRandom = authorCountRandom;
            }
            #endregion
            #region Blog
            var responseMessage4 = await client.GetAsync("https://localhost:7169/api/Statistics/GetBlogCount");
            {
                int blogCountRandom = random.Next(0, 101);

                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.blogCount = values4.blogCount;
                ViewBag.blogCountRandom = blogCountRandom;
            }
            #endregion
            #region Brand
            var responseMessage5 = await client.GetAsync("https://localhost:7169/api/Statistics/GetBrandCount");
            {
                int brandCountRandom = random.Next(0, 101);

                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.brandCount = values5.brandCount;
                ViewBag.brandCountRandom = brandCountRandom;
            }
            #endregion
            #region avgPriceForDaily
            var responseMessage6 = await client.GetAsync("https://localhost:7169/api/Statistics/GetAvgRentPriceForDaily");
            {
                int avgPriceForDailyRandom = random.Next(0, 101);

                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.avgPriceForDaily = values6.avgPriceForDaily.ToString("0.00");
                ViewBag.avgPriceForDailyRandom = avgPriceForDailyRandom;
            }
            #endregion
            #region avgPriceForWeekly
            var responseMessage7 = await client.GetAsync("https://localhost:7169/api/Statistics/GetAvgRentPriceForWeekly");
            {
                int avgPriceForWeeklyRandom = random.Next(0, 101);

                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.AvgPriceForWeekly = values7.AvgPriceForWeekly.ToString("0.00");
                ViewBag.avgPriceForWeeklyRandom = avgPriceForWeeklyRandom;
            }
            #endregion
            #region avgPriceForMonthly
            var responseMessage8 = await client.GetAsync("https://localhost:7169/api/Statistics/GetAvgRentPriceForMonthly");
            {
                int avgPriceForMonthlyRandom = random.Next(0, 101);

                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.avgPriceForMonthly = values8.AvgPriceForWeekly.ToString("0.00");
                ViewBag.avgPriceForMonthlyRandom = avgPriceForMonthlyRandom;
            }
            #endregion
            #region carCountByTransmissionIsAuto
            var responseMessage9 = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarCountByTransmissionIsAuto");
            {
                int carCountByTransmissionIsAutoRandom = random.Next(0, 101);

                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.carCountByTransmissionIsAuto = values9.carCountByTransmissionIsAuto;
                ViewBag.carCountByTransmissionIsAutoRandom = carCountByTransmissionIsAutoRandom;
            }
            #endregion
            #region brandNameByMaxCar
            var responseMessage15 = await client.GetAsync("https://localhost:7169/api/Statistics/GetBrandNameByMaxCar");
            {
                int brandNameByMaxCarRandom = random.Next(0, 101);

                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.brandNameByMaxCar = values15.brandNameByMaxCar;
                ViewBag.brandNameByMaxCarRandom = brandNameByMaxCarRandom;
            }
            #endregion
            #region blogTitleByMaxBlogComment
            var responseMessage16 = await client.GetAsync("https://localhost:7169/api/Statistics/GetBlogTitleByMaxBlogComment");
            {
                int blogTitleByMaxBlogCommentRandom = random.Next(0, 101);

                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.blogTitleByMaxBlogComment = values16.blogTitleByMaxBlogComment;
                ViewBag.blogTitleByMaxBlogCommentRandom = blogTitleByMaxBlogCommentRandom;
            }
            #endregion
            #region carCountByKmSmallerThen1000
            var responseMessage10 = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarCountByKmSmallerThen1000");
            {
                int carCountByKmSmallerThen1000Random = random.Next(0, 101);

                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10= JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.carCountByKmSmallerThen1000 = values10.carCountByKmSmallerThen1000;
                ViewBag.carCountByKmSmallerThen1000Random = carCountByKmSmallerThen1000Random;
            }
            #endregion
            #region carCountByFuelGasolineOrDiesel
            var responseMessage11 = await client.GetAsync("https://localhost:7169/api/Statistics/GetcarCountByFuelGasolineOrDiesel");
            {
                int carCountByFuelGasolineOrDieselRandom = random.Next(0, 101);

                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.carCountByFuelGasolineOrDiesel = values11.carCountByFuelGasolineOrDiesel;
                ViewBag.carCountByFuelGasolineOrDieselRandom = carCountByFuelGasolineOrDieselRandom;
            }
            #endregion
            #region carCountByFuelElectric
            var responseMessage12 = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarCountByFuelElectric");
            {
                int carCountByFuelElectricRandom = random.Next(0, 101);

                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.carCountByFuelElectric = values12.carCountByFuelElectric;
                ViewBag.carCountByFuelElectricRandom = carCountByFuelElectricRandom;
            }
            #endregion
            #region getCarBrandAndModelByRentPriceDailyMax
            var responseMessage13 = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            {
                int getCarBrandAndModelByRentPriceDailyMaxRandom = random.Next(0, 101);

                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.getCarBrandAndModelByRentPriceDailyMax = values13.getCarBrandAndModelByRentPriceDailyMax;
                ViewBag.getCarBrandAndModelByRentPriceDailyMaxRandom = getCarBrandAndModelByRentPriceDailyMaxRandom;
            }
            #endregion
            #region getCarBrandAndModelByRentPriceDailyMin
            var responseMessage14 = await client.GetAsync("https://localhost:7169/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            {
                int getCarBrandAndModelByRentPriceDailyMinRandom = random.Next(0, 101);

                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.getCarBrandAndModelByRentPriceDailyMin = values14.getCarBrandAndModelByRentPriceDailyMin;
                ViewBag.getCarBrandAndModelByRentPriceDailyMinRandom = getCarBrandAndModelByRentPriceDailyMinRandom;
            }
            #endregion


            return View();
        }
    }
}
