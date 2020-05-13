using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App1.Models;

namespace App1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Name = "WALMART" ,  Distance= 0.1 , NumberOfPeople= 80 , ImageUrl="walmart.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine=10 , CheckOutLine=50 , Address="pichae daikho peechae, pichae to daikho, peechae to daikho yaar, aek baar to peechae daikho bhai, chahtae kya ho bhai ap" , Latitutude=100 , Longititude =123 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "NO FRILLS" ,  Distance= 0.2 , NumberOfPeople= 30 , ImageUrl="nofrills.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine=2  , CheckOutLine=50 , Address="apkaesamnae" , Latitutude=123 , Longititude =123 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "COSTCO" ,  Distance= 0.3 , NumberOfPeople= 50 , ImageUrl="costco.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine=5  , CheckOutLine=50 , Address="apkae samnae" , Latitutude=123 , Longititude =435 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "METRO" ,  Distance= 0.5 , NumberOfPeople= 100 , ImageUrl="metro.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine= 8 , CheckOutLine=50 , Address="apkae samnae" , Latitutude=342 , Longititude =457 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "FRESHCO" ,  Distance= 0.7 , NumberOfPeople= 180 , ImageUrl="freshco.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine= 3 , CheckOutLine=50 , Address="apkae samnae" , Latitutude=432 , Longititude =342 },
                new Item { Id = Guid.NewGuid().ToString(), Name = "SOBEYS" ,  Distance= 1 , NumberOfPeople= 20 , ImageUrl="sobeys.png" , Description="This is a walmart store"  , Frenchise="brampton", PostalCode="00001" , OutSideLine= 3 , CheckOutLine=50 , Address="apkae samnae" , Latitutude=002 , Longititude =124 },
               
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}