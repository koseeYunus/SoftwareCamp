using InterfaceAndAbstractExp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExp.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
