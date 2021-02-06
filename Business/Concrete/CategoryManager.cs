using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this._categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();
           
        }

        public Category GetByID(int categoryID)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryID);
        }
    }
}
