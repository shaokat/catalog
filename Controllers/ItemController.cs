using Catalog.Dtos;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemsRepository repositoryy;

        public ItemController(ItemsRepository repositoryy)
        {
            this.repositoryy = repositoryy;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemDto>> getItemsAsync()
        {
            var items = (await repositoryy.GetItemsAsync()).Select(item => item.AsDto());
            return items;
        }


        [HttpGet("{id}")]


        public async Task<ActionResult<ItemDto>> getItemAsync(Guid id)
        {
            var item = await repositoryy.GetItemAsync(id);
            if (item is null)
                return NotFound();
            return Ok(item.AsDto());
        }
        
        [HttpPost]
        public async Task<ActionResult<ItemDto>> CreateItem(CreateItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                createDate = DateTimeOffset.UtcNow

            };
            await repositoryy.CreateItemAsync(item);

            return CreatedAtAction(nameof(getItemAsync), new { id = item.Id }, item.AsDto());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ItemDto>> UpdteItemAsync(Guid id, UpdateItemDto itemDto)
        {
            var existingItem = await repositoryy.GetItemAsync(id);
            if (existingItem is null)
                return NotFound();

            Item updatedItem = existingItem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price,
            };
            await repositoryy.UpdateItemAsync(updatedItem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task <ActionResult> DeleteItemAsync(Guid id)
        {
            var existingItem = await repositoryy.GetItemAsync(id);
            if (existingItem is null)
                return NotFound();
           await repositoryy.DeleteItemAsync(id);
            return NoContent();
        }
    }
      

    
}
