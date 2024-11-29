﻿using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistence.Context;
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
            throw new NotImplementedException();
        }

        public string GetBrandNameByMaxCar()
        {
            throw new NotImplementedException();
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
            int id = _context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
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
            throw new NotImplementedException();
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            throw new NotImplementedException();
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value=_context.Cars.Where(x=>x.Fuel=="Elektrik").Count();
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
