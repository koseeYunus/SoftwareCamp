using InterfaceAndAbstractExp.Abstract;
using InterfaceAndAbstractExp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExp.Concrete
{
    public class StarbucksCostemerManager: BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCostemerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override void Save(Customer costumer)
        {
            if (_customerCheckService.CheckIfRealPerson(costumer))
            {
                base.Save(costumer);
            }
            else
            {
                Console.WriteLine("Kayıt gerçekleştirilemedi. TC kimlik numaranızda hata olabilir.");
            }
        }

    
    }
}
