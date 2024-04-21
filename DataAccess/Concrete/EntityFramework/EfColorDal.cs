using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Color = Entities.Concrete.Color;

namespace DataAccess.Concrete.EntityFramework;

public class EfColorDal:EfEntityRepositoryBase<Color,Context>,IColorDal
{
    
}