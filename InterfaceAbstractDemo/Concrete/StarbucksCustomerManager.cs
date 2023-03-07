using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckPerson _customerCheckPerson;

        public StarbucksCustomerManager(ICustomerCheckPerson customerCheckPerson)
        {
            _customerCheckPerson = customerCheckPerson;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckPerson.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

      
    }
}
