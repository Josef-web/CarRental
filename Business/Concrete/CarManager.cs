using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager:ICarService
{
    private readonly ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }


    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
        return _carDal.GetAll(c => c.BrandId == brandId);
    }

    public List<Car> GetCarsByColorId(int colorId)
    {
        return _carDal.GetAll(c => c.ColorId == colorId);
    }

    public List<Car> GetByDailyPrice(decimal min, decimal max)
    {
        return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        return _carDal.GetCarDetails();
    }
}