﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext> ,ICategoryDal
    {
        
        
    }
}
