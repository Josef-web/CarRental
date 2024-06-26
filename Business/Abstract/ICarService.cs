﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
    IDataResult<List<Car>> GetAll();
    IDataResult<Car> GetById(int carId);
    IDataResult<List<Car>> GetCarsByBrandId(int brandId);
    IDataResult<List<Car>> GetCarsByColorId(int colorId);
    IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
    IDataResult<List<CarDetailDto>> GetCarDetails();
}