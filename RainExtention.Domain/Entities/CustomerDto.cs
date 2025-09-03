using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
       public  class CustomerDto
    {

            public Guid CustomerId { get; set; }        
            public Guid? PartyId { get; set; }   
            public string? CustomerCode { get; set; }
            public decimal? TotalPoint { get; set; }
            public decimal? CurrentPoint { get; set; }
            public decimal? TotalCredit { get; set; }
            public decimal? CurrentCredit { get; set; }
            public decimal? RemainCredit { get; set; }
            public int? StatusId { get; set; }
            public string? LoginName { get; set; }
            public string? Password { get; set; }
            public int? StoreId { get; set; }
            public DateTime? CreationDate { get; set; }
            public Guid? CreationUser { get; set; }
            public DateTime? ModifyDate { get; set; }
            public Guid? ModifyUser { get; set; }
            public Guid? ReagentId { get; set; }            
            public Guid? CorporateId { get; set; }            
            public Guid? AgentId { get; set; }            
            public Guid? SalePersonId { get; set; }            
            public string? Token { get; set; }            
            public string? CustomerName { get; set; }
            public byte[]? CustomerImage { get; set; }            
            public string? FirstName { get; set; }            
            public string? LastName { get; set; }
            public bool? IsIndividual { get; set; }

            public DateOnly? Birthday { get; set; }
            
            public string? Status { get; set; }            
            public int? LanguageId { get; set; }
            public string? NationalId { get; set; }
            public string? IdentifierNo { get; set; }
            public string? FatherName { get; set; }            
            public string? IssuedCity { get; set; }
            public bool? IsTaxPayer { get; set; }            
            public string? BusinessCode { get; set; }            
            public string? AreaCode { get; set; }            
            public string? Telephone { get; set; }            
            public string? Mobile { get; set; }            
            public string? Address { get; set; }            
            public string? PostalCode { get; set; }            
            public string? EmailAddress { get; set; }            
            public string? StoreName { get; set; }
            public bool? IsEmployee { get; set; }
            public bool? IsSupplier { get; set; }
            public bool? IsVisitor { get; set; }            
            public Guid? EmployeeId { get; set; }            
            public Guid? SupplierId { get; set; }            
            public Guid? VisitorId { get; set; }            
            public Guid? ThirdPartyId { get; set; }            
            public string AgentName { get; set; } = null!;            
            public Guid? DetailAccountId { get; set; }            
            public string? ImageUrl { get; set; }
        

    }
}
