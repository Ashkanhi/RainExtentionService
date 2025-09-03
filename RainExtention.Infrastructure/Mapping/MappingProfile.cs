using AutoMapper;
using RainExtention.Domain.Entities;
using RainExtention.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // مپ از CustomerView (داده از دیتابیس) به CustomerDto (خروجی API)
            CreateMap<CustomerView, CustomerDto>();
        }
    }
}
