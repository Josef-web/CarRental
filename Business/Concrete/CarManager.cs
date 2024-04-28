using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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


    public IDataResult<List<Car>> GetAll()
    {
        if (DateTime.Now.Hour==1)
        {
            return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId),Messages.CarsFilteredByBrandId);
    }

    public IDataResult<List<Car>> GetCarsByColorId(int colorId)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId),Messages.CarsFilteredByColorId);
    }

    public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max),Messages.CarsFilteredByPrice);
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        if (DateTime.Now.Hour==20)
        {
            return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
    }

    public IDataResult<Car> GetById(int carId)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c=>c.CarId == carId),Messages.CarGetById);
    }

    public IResult Add(Car car)
    {
        if (car.CarName.Length <= 2)
        {
            return new ErrorResult(Messages.CarNameInvalid);
        }

        else if (car.DailyPrice <= 0)
        {
            return new ErrorResult(Messages.CarDailyPriceInvalid);
        }
        
        _carDal.Add(car);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
         return new SuccessResult(Messages.CarUpdated);
         
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
        
    }
}