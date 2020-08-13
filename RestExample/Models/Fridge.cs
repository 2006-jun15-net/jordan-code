using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestExample.Models
{

    public class Fridge 
    {
        public static List<FoodItem> s_contents = new List<FoodItem>
        {
            new FoodItem { Id = 1, Name = "expired cheese", ExpirationDate = new DateTime(2020, 6, 14) },
            new FoodItem { Id = 2, Name = "steak", ExpirationDate = new DateTime(2020, 7, 28) },
            new FoodItem { Id = 3, Name = "salmon", ExpirationDate = new DateTime(2020, 7, 28) }
        };

        public bool IsClean { get; set; }

        public List<FoodItem> Contents
        {
            get
            {
                return s_contents;
            }
            
        }


        public ICollection<FoodItem> GetAllContents()
        {
            return s_contents;
        }

        public ICollection<FoodItem> Clean()
        {
            var removed = s_contents.Where(i => i.ExpirationDate < DateTime.Now).ToList();
            s_contents = s_contents.Except(removed).ToList();
            return removed;
        }
    }
}
