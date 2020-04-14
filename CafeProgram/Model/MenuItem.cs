using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram.Model
{
    public class MenuItem
    {
        public string MealName { get; set; }
        
        public string MealDescription { get; set; }
        
        public int MealNumber { get; set; }

        public List<MealIngredients> MealIngredients { get; set; }

        public decimal MealPrice { get; set; }
    }
}
