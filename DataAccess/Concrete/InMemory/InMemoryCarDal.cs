using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal:ICarDal
{
    List<Car> _cars;

    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
            new Car{CarId = 1,DailyPrice = 1000,ModelYear = 2009,BrandId = 2,ColorId = 1,Description = "Açıklama"},
            new Car{CarId = 2,DailyPrice = 2000,ModelYear = 2018,BrandId = 1,ColorId = 2,Description = "Açıklama 33"},
            new Car{CarId = 3,DailyPrice = 3000,ModelYear = 2023,BrandId = 3,ColorId = 2,Description = "Açıklama 345"},
        };
    }
    
    public List<Car> GetAll()
    {
        return _cars;
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        carToUpdate.CarId = car.CarId;
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.Description = car.Description;
    }

    public void Delete(Car car)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        _cars.Remove(carToDelete);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAllByBrand(int brandId)
    {
        return _cars.Where(c => c.BrandId == brandId).ToList();
    }
}