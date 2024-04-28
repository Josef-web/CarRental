namespace Business.Constants;

public static class Messages
{
    public static string MaintenanceTime = "System under maintenance.";
    
    #region CarMessages
    public static string CarAdded = "Car added successfully.";
    public static string CarUpdated = "Car updated successfully.";
    public static string CarDeleted = "Car deleted successfully.";
    public static string CarsListed = "Cars are listed successfully.";
    public static string CarGetById = "Car brought by id.";
    public static string CarsFilteredByBrandId = "Cars filtered by brandId.";
    public static string CarsFilteredByColorId = "Cars filtered by colorId.";
    public static string CarsFilteredByPrice  = "Cars filtered by price.";
    public static string CarNameInvalid = "Car name must have at least 2 letters.";
    public static string CarDailyPriceInvalid  = "Car price must be greater than 0.";
    #endregion
    
    #region BrandMessages
    public static string BrandAdded = "Brand added successfully.";
    public static string BrandUpdated = "Brand updated successfully.";
    public static string BrandDeleted = "Brand deleted successfully.";
    public static string BrandsListed = "Brands are listed successfully.";
    public static string BrandGetById = "Brand brought by id.";
    #endregion
    
    #region ColorMessages
    public static string ColorAdded = "Color added successfully.";
    public static string ColorUpdated = "Color updated successfully.";
    public static string ColorDeleted = "Color deleted successfully.";
    public static string ColorsListed = "Colors are listed successfully.";
    public static string ColorGetById = "Color brought by id.";
    #endregion

    #region UserMessages
    public static string UserAdded = "User added successfully.";
    public static string UserUpdated = "User updated successfully.";
    public static string UserDeleted = "User deleted successfully.";
    public static string UsersListed = "Users are listed successfully.";
    public static string UserGetById = "User brought by id.";
    #endregion
    
    #region CustomerMessages
    public static string CustomerAdded = "Customer added successfully.";
    public static string CustomerUpdated = "Customer updated successfully.";
    public static string CustomerDeleted = "Customer deleted successfully.";
    public static string CustomersListed = "Customers are listed successfully.";
    public static string CustomerGetById = "Customer brought by id.";
    #endregion
    
    #region RentalMessages
    public static string RentalAdded = "Car rental was successful.";
    public static string RentalUpdated = "Rental updated successfully.";
    public static string RentalDeleted = "Rental deleted successfully.";
    public static string RentalsListed = "Rentals are listed successfully.";
    public static string RentalGetById = "Rental brought by id.";
    public static string RentalInvalid = "Rental could not be realized.";
    public static string RentalUnavaliableCar = "You cannot rent this car, it is still in use.";
    #endregion
    
}