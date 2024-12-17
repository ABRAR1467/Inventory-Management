using Inventory.repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private ApplicationDbContext _context;
        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<BillTypeListViewModel>> GetAll(int PageSize, int PageNumber)
        {
            var billTypes = _context.BillTypes;
            var vm = billTypes.ModeltoVM().AsQueryable();
            return await PaginatedList<BillTypeListViewModel>.CreateAsync(vm, PageNumber, PageSize);
        }
        public void Add(CreateBillTypeViewModel model)
        {
            var billType = model.VMToModel();
            _context.BillTypes.Add(billType);
            _context.SaveChanges();
        }
        public void Update(BillTypeViewModel vm)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == vm.BillTypeId).FirstOrDefault();
            if (model != null)
            {
                model.BillTypeName = vm.BillTypeName;
                model.Description = vm.Description;

                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == id).FirstOrDefault();
            if (model != null)
            {
                _context.BillTypes.Remove(model);
                _context.SaveChanges();
            }
        }
        public BillTypeViewModel GetById(int id)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == id).FirstOrDefault();
            var vm = new BillTypeViewModel(model);
            return vm;
        }
    }
}
