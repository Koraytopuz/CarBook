using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Application.ViewModels;
using CarBook.Domain.Entites;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repository.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 2).ToList();
            return values;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([3],[5],[6])) as PivotTable;";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        {
                            BrandName = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal> {
                                Convert.ToDecimal(reader["3"]),
                                Convert.ToDecimal(reader["5"]),
                                Convert.ToDecimal(reader["6"])
                            }
                        };
                        values.Add(carPricingViewModel);
                    }
                }
                _context.Database.CloseConnection();
                return values;
            }
        }
    }
}
        //public List<CarPricing> GetCarPricingWithTimePeriod()
        //{
        //    List<CarPricing> values = new List<CarPricing>();
        //    using (var command = _context.Database.GetDbConnection().CreateCommand())
        //    {
        //        command.CommandText = "Select* From (Select Model,PricingID,Amount from CarPricings Inner join Cars on Cars.CarID=CarPricings.CarID Inner join Brands on Brands.BrandId=Cars.BrandID) as SourceTable Pivot (Sum(Amount) for PricingID in([2],[3],[5])) as PivotTable;";
        //        command.CommandType = System.Data.CommandType.Text;
        //        _context.Database.OpenConnection();
        //        using (var reader = command.ExecuteReader()) {
        //            while (reader.Read()) {
        //                CarPricing carPricing = new CarPricing();
        //                Enumerable.Range(1, 3).ToList().ForEach(x => {
        //                if (DBNull.Value.Equals(reader[x])) {
        //                    carPricing.PricingID = x;
        //                }
        //                else {
        //                    carPricing.Amount = x;

        //                });
        //                values.Add(carPricing);
        //            }
        //        }
        //        _context.Database.CloseConnection();
        //        return values;
        //    }
        //}

            //var values = from x in _context.CarPricings
            //             group x by x.PricingID into g
            //             select new
            //             {
            //                 CarID= g.Key,
            //                 DailyPrice = g.Where(y => y.CarPricingID == 3).Sum(z => z.Amount),
            //                 WeeklyPrice = g.Where(y => y.CarPricingID == 5).Sum(z => z.Amount),
            //                 MonthlyPrice = g.Where(y => y.CarPricingID == 6).Sum(z => z.Amount)
            //             };
            //return values;