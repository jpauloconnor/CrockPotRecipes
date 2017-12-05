using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrockPotRecipes.Data
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        public string RecipeName { get; set; }


    }
}
