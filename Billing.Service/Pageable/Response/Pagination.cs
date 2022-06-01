using System;
using System.Collections.Generic;

namespace Billing.Service.Pageable
{
    // Helper
    public class PageRange
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }

    public class Pagination
    {
        // Props
        public int PageNumber { get; set; }
        public long PageElements { get; set; }
        public long TotalPages { get; set; }
        public long TotalElements { get; set; }


        public static PageRange Of(int? page, int? size)
        {
            if (page == null || size == null)
                return null;

            return new PageRange
            {
                Page = page.Value,
                Size = size.Value
            };
        }

        /// <summary>
        /// Calculates and add set the `TotalElements` and `TotalPages` property
        /// </summary>
        public static Pagination Calculate(PageRange range, long totalElementsFromQuery, long totalVisibleElements)
        {
            var instance = new Pagination
            {
                TotalElements = totalElementsFromQuery,
                PageElements = totalVisibleElements,
                PageNumber = range.Page
            };

            if (range.Size <= 0) range.Size = 1;

            if (totalElementsFromQuery == totalVisibleElements)
                instance.TotalPages = 1;
            else
                instance.TotalPages = decimal
                        .Divide(totalElementsFromQuery, range.Size)
                        .AbsPositive();

            return instance;
        }
    }

    public class Pagination<TModel> where TModel : class
    {
        // The queryable to be used 
        public List<TModel> Data { get; set; }

        // The queryable to be used 
        public Pagination Pageable { get; set; }
    }

    // Extension helper
    public static class DecimalExtensions
    {
        /// <summary>
        /// Get the absolute positive number, like: (3,2) -> (4)
        /// </summary>
        public static long AbsPositive(this decimal num)
        {
            var abs = (long)Math.Abs(num);
            return num > abs ? ++abs : abs;
        }
    }
}