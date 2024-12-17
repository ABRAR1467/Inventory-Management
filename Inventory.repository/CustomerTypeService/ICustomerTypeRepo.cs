using Inventory.repository.Paging;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.CustomerType
{
    public interface ICustomerTypeRepo
    {
        Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int PageSize,int PageNumber);
    }
}
