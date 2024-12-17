using Inventory.repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.BillService
{
    public class BillRepo : IBillRepo
    {
        private ApplicationDbContext _context;

        public BillRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public  async Task<PaginatedList<BillListViewModel>> GetAll(int PageSize, int PageNumber)
        {
            var bills = _context.Bills;
            var vm = bills.ModeltoVM().AsQueryable();
            return await PaginatedList<BillListViewModel>.CreateAsync(vm, PageNumber, PageSize);
        }
    }
}
