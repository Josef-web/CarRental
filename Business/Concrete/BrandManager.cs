﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager:IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public List<Brand> GetAll()
    {
        return _brandDal.GetAll();
    }

    public Brand GetById(int brandId)
    {
        return _brandDal.Get(c => c.BrandId == brandId);
    }
}