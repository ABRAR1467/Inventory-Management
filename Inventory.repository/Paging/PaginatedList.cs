using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.repository.Paging
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; } // Current page number
        public int TotalPages { get; private set; } // Total number of pages

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize); // Calculate total pages

            this.AddRange(items); // Add the current page's items
        }

        public bool HasPreviousPage => PageIndex > 1; // Check if there is a previous page
        public bool HasNextPage => PageIndex < TotalPages; // Check if there is a next page

        // Static helper to create a paginated list asynchronously
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = source.Count(); // Total count of records
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList(); // Get paginated records
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}
