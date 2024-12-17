using Inventory.repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.ProductTypeService
{
    public interface IProductTypeRepo
    {
        Task<PaginatedList<ProductTypeListViewModel>> GetAll(int PageSize, int PageNumber);
    }
}
