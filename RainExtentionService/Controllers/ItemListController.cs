using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Interface;
using RainExtention.Domain.Entities;

namespace RainExtentionService.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
        public class ItemListController : ControllerBase
        {
            private readonly IItemListService _itemListService;

            public ItemListController(IItemListService itemListService)
            {
                _itemListService = itemListService;
            }

            /// <summary>
            /// دریافت لیست آیتم‌ها
            /// </summary>
            /// <returns>لیست آیتم‌ها</returns>
            [HttpGet]
            public async Task<ActionResult<IEnumerable<ItemListDto>>> GetItemList()
            {
                var items = await _itemListService.GetItemListAsync();
                return Ok(items);
            }

        [HttpPost("GetItemsByIds")]
        public async Task<ActionResult<IEnumerable<ItemListDto>>> GetItemsByIds([FromBody] List<Guid> itemIds)
        {
            if (itemIds == null || !itemIds.Any())
                return BadRequest("لیست شناسه‌ها نمی‌تواند خالی یا null باشد.");

            var items = await _itemListService.GetItemsByIdsAsync(itemIds);
            return Ok(items);
        }


    }
    }

