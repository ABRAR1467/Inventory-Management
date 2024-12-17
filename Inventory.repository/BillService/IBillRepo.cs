using Inventory.repository.Paging;
using Inventory.ViewModel.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.BillService
{
    public interface IBillRepo
    {
        Task<PaginatedList<BillListViewModel>> GetAll(int PageSize, int PageNumber);
    }
}
