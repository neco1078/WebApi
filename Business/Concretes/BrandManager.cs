using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandServices
{
   private readonly IBrandDAL  _brandDal;

    public BrandManager(IBrandDAL brandDal)
    {
        _brandDal = brandDal;
    }

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {

        ///business rules
        
        //mapping-->automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
       brand.CreateDate = DateTime.Now;

        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();
        createBrandResponse.Name = brand.Name;
        createBrandResponse.Id = 5;
        createBrandResponse.CreatedDate =brand.CreateDate;
        return createBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        throw new NotImplementedException();
    }
}
