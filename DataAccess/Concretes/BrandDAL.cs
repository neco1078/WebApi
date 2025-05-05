using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{

    public class BrandDAL : IBrandDAL
    {
        List<Brand> _brands;
        public BrandDAL()
        {
            _brands = new List<Brand>();
            _brands.Add(new Brand { Id = 1, Name = "BMW",CreateDate=DateTime.Now });
            _brands.Add(new Brand { Id = 2, Name = "AUDI", CreateDate = DateTime.Now });
            _brands.Add(new Brand { Id = 3, Name = "MERCEDES", CreateDate = DateTime.Now });
            _brands.Add(new Brand { Id = 4, Name = "FIAT", CreateDate = DateTime.Now });
        }
        public void Add(Brand brand)
        {
           _brands.Add(brand);
        }
        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
    {
    }
}
