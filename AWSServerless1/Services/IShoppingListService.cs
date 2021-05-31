using System.Collections.Generic;

namespace AWSServerless1.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemsToShoppingList(ShoppingListModel shoppingList);

        void RemoveItem(string itemName);
    }
}