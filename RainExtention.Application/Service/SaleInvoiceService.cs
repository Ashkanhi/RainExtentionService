using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainExtention.Domain.Interface;
using RainExtention.Domain.Entities;
using RainExtention.Application.Models;
using System.Text.Json;
using System.IO;
using System;
using RainExtention.Application.Service;
using System.IO;
using System;



namespace RainExtention.Application.Service
{
    public class SaleInvoiceService
    {
        private readonly ISaleInvoiceRepository _repository;
        private readonly ICustomerRepository _customerRepository;
  

        public SaleInvoiceService(  ISaleInvoiceRepository repository, ICustomerRepository customerRepository )
        {
            _repository = repository;          
            _customerRepository = customerRepository;
        }

        public async Task<SaleInvoiceDto?> GetInvoiceByIdAsync(Guid invoiceId)
        {
            return await _repository.GetByIdAsync(invoiceId);
        }


        public async Task<AddSaleInvoiceResponse> AddAsync(SaleInvoiceDto invoice)
        {
            // 🔹 مرحله 1: بررسی وجود کد مشتری
            // اگر CustomerCode نباشد، نمی‌توانیم مشخص کنیم مشتری کیست یا جدید بسازیم.
            // پس اگر خالی، فقط فاصله، یا null باشد، خطا می‌دهیم.
            if (string.IsNullOrWhiteSpace(invoice.CustomerCode))
                throw new ArgumentException("کد مشتری (CustomerCode) الزامی است.");

            // 🔹 مرحله 2: اگر CustomerId هنوز مشخص نشده باشد (مثلاً کاربر نفرستاده باشد)
            // باید با استفاده از CustomerCode، مشتری رو چک یا ایجاد کنیم.
            if (invoice.CustomerId == null || invoice.CustomerId == Guid.Empty)
            {
                // 2.1: بررسی می‌کنیم آیا مشتری با این CustomerCode قبلاً در سیستم وجود دارد؟
                var existingCustomer = await _customerRepository.CheckCustomerByCode(invoice.CustomerCode);

                // اگر مشتری پیدا شد (مثلاً قبلاً ثبت شده)، فقط CustomerId رو از اون بگیر و در فاکتور بذار
                if (existingCustomer != null)
                {
                    invoice.CustomerId = existingCustomer.CustomerId;
                }
                else
                {
                    // ❌ اگر مشتری پیدا نشد، یعنی مشتری جدید است و باید ایجادش کنیم.

                    // قبل از ایجاد، چک می‌کنیم که نام و نام خانوادگی داده شده باشد
                    // چون برای ایجاد مشتری جدید، نام و نام خانوادگی الزامی است.
                    if (string.IsNullOrWhiteSpace(invoice.FirstName))
                        throw new ArgumentException("نام (FirstName) برای ایجاد مشتری جدید الزامی است.");

                    if (string.IsNullOrWhiteSpace(invoice.LastName))
                        throw new ArgumentException("نام خانوادگی (LastName) برای ایجاد مشتری جدید الزامی است.");

                    // حالا مشتری جدیدی با CustomerCode، FirstName و LastName ایجاد می‌کنیم
                    // و این متد یه CustomerId جدید (Guid) برمی‌گردونه
                    var newCustomerId = await _customerRepository.GetOrCreateCustomerForInvoiceAsync(
                        invoice.CustomerCode,
                        invoice.FirstName,
                        invoice.LastName);

                    // CustomerId جدید رو در فاکتور ذخیره می‌کنیم تا فاکتور به این مشتری متصل بشه
                    invoice.CustomerId = newCustomerId;
                }
            }


            var generateNow = DateTime.Now; 
            var generateDateOnly = DateOnly.FromDateTime(generateNow);
            var generateTimeOnly = TimeOnly.FromDateTime(generateNow);
            var generateinvoiceTypeID = 350;
            var generateBookerWorkstation = 1;
            var generateInvoiceId =Guid.NewGuid();
            invoice.InvoiceId = generateInvoiceId;

            invoice.InvoiceDate = generateNow;
            invoice.BusinessDate = generateDateOnly;
            invoice.InvoiceTime = generateTimeOnly;
            invoice.InvoiceTypeId = generateinvoiceTypeID;
            invoice.BookerWorkstationId = generateBookerWorkstation;

            var lastNumber = await _repository.GetLastInvoiceNumberAsync(invoice.BookerStoreId);            
            invoice.InvoiceNumber = GenerateNextInvoiceNumber(lastNumber, invoice.BookerStoreId, 1);
                   
            

            
        
 

            await _repository.AddAsync(invoice);




            // 🔹 مرحله 5: برگرداندن پاسخ به کاربر
            // یه پاسخ ساختاریافته برمی‌گردونیم که شامل شناسه و شماره فاکتور باشه
            return new AddSaleInvoiceResponse
            {
                InvoiceId = invoice.InvoiceId,           // شناسه فاکتور (Guid)
                InvoiceNumber = invoice.InvoiceNumber,   // شماره فاکتور (مثلاً 1-1-101)
                Message = "Invoice added successfully.", 
                InvoiceData = invoice // پیام موفقیت‌آمیز
            };
        }
        private string GenerateNextInvoiceNumber(string? lastNumber, int storeId, int workstationId)
        {
            const long defaultStart = 1; // اگر هیچ فاکتوری نبود
            long nextSerial = defaultStart;

            if (!string.IsNullOrEmpty(lastNumber))
            {
                var parts = lastNumber.Split('-');
                if (parts.Length == 4 && long.TryParse(parts[3], out long currentSerial))
                {
                    nextSerial = currentSerial + 1;
                }
                else
                {
                    nextSerial = defaultStart;
                }
            }
            else
            {
                nextSerial = defaultStart;
            }

            return $"{storeId}-{workstationId}-2-{nextSerial}";
        }

    }
}
