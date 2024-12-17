using Inventory.repository.Paging;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.CustomerService
{
    public class CustomerRepo : ICustomerRepo
    {
        private ApplicationDbContext _context;
        public CustomerRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<CustomerListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var customerLists = _context.Customers;
            var vm = customerLists.ModeltoVM().AsQueryable();
            return await PaginatedList<CustomerListViewModel>.CreateAsync(vm, pageNumber, pageSize);
        }
    }
}
