using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Domain.Entities
{
    public class CustomerCommandModel
    {
        public string ?CustomerCode { get; set; }        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Mobile { get; set; }
        public string? StatusId { get; set; }        
        public Guid PartyId { get; set; }
    

    }
}
