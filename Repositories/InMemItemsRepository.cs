using Catalog.Entities;

namespace Catalog.Repositories
{
   /* public class InMemItemsRepository : ItemsRepository
    {
        private readonly List<Item> itmes = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, createDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, createDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Rronze Shield", Price = 18, createDate = DateTimeOffset.UtcNow }

        };

        public IEnumerable<Item> GetItemsAsync()
        {
        
            return itmes;
           
        }

        public Item GetItemAsync(Guid id)
        {
            return itmes.Where(it => it.Id == id).SingleOrDefault();
        }

        public void CreateItemAsync(Item item)
        {
            itmes.Add(item);
        }

        public void UpdateItemAsync(Item item)
        {
            var index = itmes.FindIndex(it => it.Id == item.Id);

            itmes[index] = item;
        }

        public void DeleteItemAsync(Guid id)
        {
            var index = itmes.FindIndex(it => it.Id == id);

            itmes.RemoveAt(index) ;
        }

    }*/
}
