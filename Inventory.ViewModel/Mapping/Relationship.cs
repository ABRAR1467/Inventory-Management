using Inventory.models;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Mapping
{
    public static class Relationship
    {
        public static IEnumerable<CustomerTypeListViewModel> ModeltoVM(this IEnumerable<Inventory.models.CustomerType> customerType)
        {
            List<CustomerTypeListViewModel> list = new List<CustomerTypeListViewModel>();
            foreach (var ct in customerType)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    CustomerTypeId = ct.CustomerTypeId,
                    CustomerTypeName = ct.CustomerTypeName,
                    Description = ct.Description

                });
            }
            return list;
        }
        public static IEnumerable<CustomerListViewModel> ModeltoVM(this IEnumerable<Inventory.models.Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var ct in customers)
            {
                list.Add(new CustomerListViewModel()
                {
                    CustomerId = ct.CustomerId,
                    CustomerName = ct.CustomerName,
                    City = ct.City,
                    ContactPerson = ct.ContactPerson,
                    CustomerTypeId = ct.CustomerTypeId,
                    ZipCode = ct.ZipCode,
                    Address = ct.Address,
                    Email = ct.Email,
                    Phone = ct.Phone,
                    State = ct.State
                });
            }
            return list;
        }
        public static IEnumerable<BillTypeListViewModel> ModeltoVM(this IEnumerable<Inventory.models.BillType> billTypes)
        {
            List<BillTypeListViewModel> list = new List<BillTypeListViewModel>();
            foreach (var ct in billTypes)
            {
                list.Add(new BillTypeListViewModel()
                {
                    BillTypeId = ct.BillTypeId,
                    BillTypeName = ct.BillTypeName,
                    Description = ct.Description

                });
            }
            return list;
        }
        public static IEnumerable<BillListViewModel> ModeltoVM(this IEnumerable<Inventory.models.Bill> bills)
        {
            List<BillListViewModel> list = new List<BillListViewModel>();
            foreach (var ct in bills)
            {
                list.Add(new BillListViewModel()
                {
                    BillId = ct.BillId,
                    BillDate = ct.BillDate,
                    BillTypeId = ct.BillTypeId,
                    BillDueDate = ct.BillDueDate,
                    BillName = ct.BillName,
                    GoodsReceivedNotedId = ct.GoodsReceivedNotedId,
                    VendorDoNumber = ct.VendorDoNumber,
                    VendorInvoiceNumber = ct.VendorInvoiceNumber

                });
            }
            return list;
        }
        public static IEnumerable<ProductTypeListViewModel> ModeltoVM(this IEnumerable<Inventory.models.ProductType> productTypes)
        {
            List<ProductTypeListViewModel> list = new List<ProductTypeListViewModel>();
            foreach (var ct in productTypes)
            {
                list.Add(new ProductTypeListViewModel()
                {
                    ProductTypeId = ct.ProductTypeId,
                    ProductTypeName = ct.ProductTypeName,
                    Description = ct.Description
                });
            }
            return list;
        }
    }
}
