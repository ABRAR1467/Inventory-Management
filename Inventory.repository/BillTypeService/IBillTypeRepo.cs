using Inventory.repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.BillTypeService
{
    public interface  IBillTypeRepo
    {
        Task<PaginatedList<BillTypeListViewModel>> GetAll(int PageSize, int PageNumber);
        void Add(CreateBillTypeViewModel model);
        void Delete(int id);
        BillTypeViewModel GetById(int id);
        void Update(BillTypeViewModel model);
    }
}
