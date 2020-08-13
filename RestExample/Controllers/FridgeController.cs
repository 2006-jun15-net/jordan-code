using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestExample.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private static Fridge fridge = new Fridge();

        // GET: api/fridge
        [HttpGet]
        public void VerifyClean()
        {
            fridge.IsClean = true;

        }

        //PUT: api/fridge
        [HttpPut]
        public void Clean()
        {
            if (fridge.IsClean)
            {
                fridge.Clean();
            }

        }
   
        // GET: api/fridge/items
        [HttpGet("items")]
        public IEnumerable<FoodItem> GetItems()
        {
            return fridge.Contents;
        }

        // GET api/fridge/items/5
        [HttpGet("items/{id}")]
        public FoodItem GetItem(int id)
        {
            return fridge.Contents.Find(f => f.Id == id);
        }

        // POST api/fridge/items
        [HttpPost("items")]
        public void PostItem([FromBody] FoodItem value)
        {
            fridge.Contents.Add(value);
        }

        // PUT api/fridge/items/5
        [HttpPut("items/{id}")]
        public void PutItem(int id, [FromBody] FoodItem value)
        {
            var tempItem = fridge.Contents.Find(i => i.Id == id);
            int index = fridge.Contents.IndexOf(value);
            tempItem.Name = value.Name;
            tempItem.ExpirationDate = value.ExpirationDate;
            fridge.Contents.Remove(value);
            fridge.Contents.Insert(index,tempItem);

        }

        // DELETE api/fridge/items/5
        [HttpDelete("items/{id}")]
        public void DeleteItem(int id)
        {
            fridge.Contents.Remove(fridge.Contents.Find(i => i.Id == id));
        }
    }
}

