using InterfaceAndAbstractExp.Abstract;
using InterfaceAndAbstractExp.Adapters;
using InterfaceAndAbstractExp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExp.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();

            return mernisServiceAdapter.CheckIfRealPerson(customer);
        }
    }
}
