using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class RentalManager:IRentalService
{
    private readonly IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }

    public IResult Add(Rental rental)
    {
        // check if car delivered
        var rentedCar = _rentalDal.Get(r => r.CarId == rental.CarId && rental.ReturnDate == null);
        var carExists = _rentalDal.Get(r => r.CarId == rental.CarId);
        
        if (rentedCar!=null)
        {
            return new ErrorResult(Messages.RentalUnavaliableCar);
        }
        else if(carExists==null)
        {
            return new ErrorResult(Messages.RentalInvalid);
        }
        
        _rentalDal.Add(rental);
        return new SuccessResult(Messages.RentalAdded);
    }

    public IResult Update(Rental rental)
    {
        _rentalDal.Update(rental);
        return new SuccessResult(Messages.RentalUpdated);
    }

    public IResult Delete(Rental rental)
    {
        _rentalDal.Delete(rental);
        return new SuccessResult(Messages.RentalDeleted);
    }

    public IDataResult<List<Rental>> GetAll()
    {
        if (DateTime.Now.Hour==20)
        {
            return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalsListed);
    }

    public IDataResult<Rental> GetById(int rentalId)
    {
        return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == rentalId), Messages.RentalGetById);
    }
}