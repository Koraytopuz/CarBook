using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.StatisticsRepositoies
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            //select top(1) BlogId,COUNT(*) as 'Sayi' from  Comments group by BlogID order by Sayi desc
            var values = _context.Comments.GroupBy(x => x.BlogID).
               Select(y => new
               {
                   BlogID = y.Key,
                   Count = y.Count()

               }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string blogName = _context.Blogs.Where(x => x.BlogID == values.BlogID).Select(y => y.Title).FirstOrDefault();
            return blogName;
        }

        public string GetBrandNameByMaxCar()
        {
           var values = _context.Cars.GroupBy(x => x.BrandID).
                Select(y => new
                {
                    BrandID = y.Key,
                    Count=y.Count()
                    
                }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();
            string brandName=_context.Brands.Where(x=>x.BrandId==values.BrandID).Select(y=>y.Name).FirstOrDefault();
            return brandName;

        }

        public int GetAuthorCount()
        {
            var value=_context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            // Select Avg(Amount) from CarPricings where PricingID=(Select PricingID from Pricings where Name='Günlük')
            int id=_context.Pricings.Where(y=>y.Name=="Günlük").Select(z=>z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w=>w.PricingID==id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            // Select Avg(Amount) from CarPricings where PricingID=(Select PricingID from Pricings where Name='Aylık')
            int id = _context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            // Select Avg(Amount) from CarPricings where PricingID=(Select PricingID from Pricings where Name='Haftalık')
            int id = _context.Pricings.Where(y => y.Name == "Haftalık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value=_context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value=_context.Brands.Count();  
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            int pricindID = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricindID).Max(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricindID = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricindID).Min(x => x.Amount);
            int carId = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value=_context.Cars.Where(x=>x.Fuel=="Elektrikli").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value=_context.Cars.Where(x=>x.Fuel=="Benzin"|| x.Fuel=="Dizel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen1000()
        {
            var value=_context.Cars.Where(x=>x.Km <=1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik");
            return value.Count();   
        }

        public int GetLocationCount()
        {
            var value= _context.Locations.Count();
            return value;
        }
    }
}
