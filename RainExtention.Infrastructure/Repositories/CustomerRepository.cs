using Microsoft.EntityFrameworkCore;
using RainExtention.Domain.Entities;
using RainExtention.Domain.Interface;
using RainExtention.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions; 

namespace RainExtention.Infrastructure.Repositories
{
     public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
   

        public async Task<CustomerDto?> CheckCustomerByCode(string customerCode)
        {
            return await _context.CustomerViews
                .Where(c =>
                    c.CustomerCode == customerCode
                        &&
                     c.LanguageId  == 314
                    )
                .ProjectTo<CustomerDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(); // اگر نباشه null برمی‌گردونه
        }

        public async Task<Guid> GetOrCreateCustomerForInvoiceAsync(
            string customerCode,
            string? firstName,
            string? lastName)
        {
            var existingCustomer = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerCode == customerCode);

            if (existingCustomer != null)
                return existingCustomer.CustomerId;

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required to create a new customer.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required to create a new customer.", nameof(lastName));

            // --- ایجاد موجودیت‌ها ---
            var newCustomerId = Guid.NewGuid();
            var newPartyId = Guid.NewGuid();
            var newThirdPartyId = Guid.NewGuid();
            var newDetailAccountId = Guid.NewGuid();
            var newPersonId = Guid.NewGuid();
            var currentDate = DateTime.Now;

            var newCustomer = new Infrastructure.Entities.Customer
            {
                CustomerId = newCustomerId,
                CustomerCode = customerCode,
                CreationDate = currentDate,
                ModifyDate = currentDate,
                StatusId = 243
            };

            var newParty = new Infrastructure.Entities.Party
            {
                PartyId = newPartyId,
                TypeId = 367
            };

            var newThirdParty = new Infrastructure.Entities.ThirdParty
            {
                ThirdPartyId = newThirdPartyId,
                Name = $"{firstName.Trim()} {lastName.Trim()}",
                MaxCredit = 0
            };

            var newDetailAccount = new Infrastructure.Entities.DetailAccount
            {
                DetailAccountId = newDetailAccountId,
                Name = $"{firstName.Trim()} {lastName.Trim()}",
                TypeId = 3,
                StatusId = 243
            };

            var newPerson = new Infrastructure.Entities.Person
            {
                PersonId = newPersonId,
                PartyId = newPartyId,
                SalutionId = 431,
                ThirdPartyId = newThirdPartyId,
                DetailAccountId = newDetailAccountId,
                IsTaxPayer = false
            };

            var newPersonNameTranslation = new Infrastructure.Entities.PersonNameTranslation
            {
                PersonId = newPersonId,
                FirstName = firstName.Trim(),
                LastName = lastName.Trim(),
                LanguageId = 314
            };

            _context.Customers.Add(newCustomer);
            _context.Parties.Add(newParty);
            _context.ThirdParties.Add(newThirdParty);
            _context.DetailAccounts.Add(newDetailAccount);
            _context.People.Add(newPerson);
            _context.PersonNameTranslations.Add(newPersonNameTranslation);

            await _context.SaveChangesAsync();

            return newCustomerId;
        }

    }
}
