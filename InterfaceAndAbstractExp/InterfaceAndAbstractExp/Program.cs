using InterfaceAndAbstractExp.Abstract;
using InterfaceAndAbstractExp.Adapters;
using InterfaceAndAbstractExp.Concrete;
using InterfaceAndAbstractExp.Entities;
using System;

namespace InterfaceAndAbstractExp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCostemerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { Id = 1, FirstName = "Yunus", LastName = "Köse", DateOfBirth = new DateTime(1996, 5, 29), NationalityId = "12312312312", Score = 1 });
            
        }
    }
}
