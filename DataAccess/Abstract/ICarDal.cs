﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int Id);
        List<Car> GetAll();
        void Add(Car car);
        void Update(int CarID);
        void Delete(Car car);
    }
}
