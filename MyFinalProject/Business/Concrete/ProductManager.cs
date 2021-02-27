using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //Burada result dönerse if den sonraki satırlara geçmez.
            //if (product.ProductName.Length<3)
            //{
            //    //magic string
            //    return new ErrorResult(Messages.ProductNameInValid);
            //}

            //ValidationTool.Validate(new ProductValidator(), product);

            IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName), CheckIfProductCountOfCategoryCorrect(product.CategoryId), CheckIfCategoryLimitExceded());

            if (result!=null)
            {
                return result;
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 9)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            //Ürünlerin iş kodları (Yetkisi varmı gibi kontroller burada yapılır.)
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);             
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=> p.ProductId==productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetail());
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            if (CheckIfProductCountOfCategoryCorrect(product.CategoryId).Success)
            {
                if (CheckIfProductNameExists(product.ProductName).Success)
                {
                    _productDal.Update(product);
                    return new SuccessResult(Messages.ProductAdded);
                }
                
            }

            return new ErrorResult();
        }

        private IResult CheckIfProductCountOfCategoryCorrect(int category)
        {
            //Gelen ürünün kadegorisinde 10'da fazla ise ekleme yapılmasın.
            if (_productDal.GetAll(p => p.CategoryId == category).Count >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryCorrect);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNameExists(string productName)
        {
            //Aynı isimde ürün var ise ekleme işlemini yapma
            var result = _productDal.GetAll(p => p.ProductName == productName).Count>0;
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }

        
        private IResult CheckIfCategoryLimitExceded()
        {
            //Eğer mevcut kategori sayısı 15 i geçtiyse sisteme yeni ürün eklenemez.
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
