using System;
using System.Collections.Generic;
using System.Text;

namespace MyBestProj.HomeWork
{
    public class PageInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; } 
        public int TotalItems { get; set; }
        public int TotalPages  // всего страниц
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }
}
