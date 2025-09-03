using RainExtention.Domain.Entities;
using RainExtention.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainExtention.Application.Service
{
    /// <summary>
    /// سرویس مدیریت مشتریان — بررسی، ایجاد و دریافت اطلاعات مشتری بر اساس کد
    /// </summary>
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// بررسی وجود مشتری بر اساس کد مشتری
        /// </summary>
        /// <param name="customerCode">کد یکتا مشتری (مثلاً CUST123)</param>
        /// <returns>اطلاعات مشتری یا null اگر وجود نداشته باشد</returns>
        public async Task<CustomerDto?> CheckCustomerByCodeIdAsync(string customerCode)
        {
            if (string.IsNullOrWhiteSpace(customerCode))
                return null;

            return await _repository.CheckCustomerByCode(customerCode);
        }


        // در Application.Service
        //public async Task<Guid> GetOrCreateCustomerAsync(string customerCode)
        //{
        //    var existing = await _repository.CheckCustomerByCode(customerCode);
        //    if (existing != null) return existing.CustomerId;

        //    // ✅ فقط یک درخواست می‌دهیم: "لطفاً مشتری رو ایجاد کن"
        //    return await _repository.CreateCustomerAsync(new CustomerCommandModel { ... });
        //}

    }
}