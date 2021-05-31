using Microsoft.AspNetCore.Mvc;
using AWSServerless1.Services;
//using Amazon.DynamoDBv2.DataModel;
//using Amazon.DynamoDBv2;
using System.Threading.Tasks;

namespace AWSServerless1.Controllers
{
    [Route("v1/shoppingList")]
    //[ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;
        ////private readonly AmazonDynamoDBClient _client;
       // private readonly DynamoDBContext _context;

        public ShoppingListController()
        {
            //_client = new AmazonDynamoDBClient();
            //_context = new DynamoDBContext(_client);
        }

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();

            //var reader = new Reader
            //{
            //    Id = Guid.NewGuid(),
            //    Name = entity.Name,
            //    EmailAddress = entity.EmailAddress,
            //    AddedOn = DateTime.Now,
            //    Username = entity.Username
            //};

            //await _context.SaveAsync<Reader>(reader);
            //var result = await _context.LoadAsync<>();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromhoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);
            return Ok();
        }
    }
}