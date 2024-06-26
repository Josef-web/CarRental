﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, Context>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (Context context = new Context())
        {
            var result = from c in context.Cars
                join b in context.Brands
                    on c.BrandId equals b.BrandId
                join co in context.Colors
                    on c.ColorId equals co.ColorId
                select new CarDetailDto
                    { 
                        CarId = c.CarId, 
                        CarName = c.CarName, 
                        BrandName = b.BrandName, 
                        ColorName = co.ColorName,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear 
                    };
            return result.ToList();
        }
    }
}