using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface ItemsRepository
    {
        public Task<Item> GetItemAsync(Guid id);
        public Task<IEnumerable<Item>> GetItemsAsync();

        public  Task  CreateItemAsync(Item item);

        public Task UpdateItemAsync(Item item);

        public  Task DeleteItemAsync(Guid id);
    }
}