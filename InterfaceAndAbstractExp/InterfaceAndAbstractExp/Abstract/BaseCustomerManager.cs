using InterfaceAndAbstractExp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndAbstractExp.Abstract
{
    public abstract class BaseCustomerManager : ICostumerService
    {
        public virtual void Save(Customer costumer)
        {
            Console.WriteLine("Save to db = "+costumer.FirstName+" "+costumer.LastName);
        }
    }
}
