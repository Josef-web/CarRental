using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int brandId);
    List<Car> GetCarsByColorId(int colorId);

    List<Car> GetByDailyPrice(decimal min, decimal max);
    List<CarDetailDto> GetCarDetails();
}