using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
    public  class ItemListDto
    {

        public Guid ItemID { get; set; }        
        public Guid? ParentID { get; set; }
        public string?  ItemName { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CurrentDiscount { get; set; }
        public string? Barcode { get; set; }
        public string? StockName { get; set; }
        public Guid  StockID  { get; set; }
        public decimal StockQuantity { get; set; }
        public string? DepartmentCode { get; set; }
        public string? DepartmentName { get; set; }
    }
}
