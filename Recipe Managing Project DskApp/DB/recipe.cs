using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Managing_Project_DskApp.DB
{
    internal class recipe
    {
        public struct Name
        {
            public string name;
            public string complexity;
            public Name(string _Name, string _Complexity)
            {
                name = _Name;
                complexity = _Complexity;
            }

        }
        public struct Restrictions
        {
            public bool meat;
            public bool seafood;
            //This will take in a string then convert to boolean
            public Restrictions(string _Meat, string _Seafood)
            {
                meat = Convert.ToBoolean(_Meat);
                seafood = Convert.ToBoolean(_Seafood);

            }

        }
        public struct Ingredient
        {
            public string name;
            public int amount;
            public string unit;
            public Ingredient(string _Name, string _Amount, string _Unit)
            {
                name = _Name;
                amount = Convert.ToInt32(_Amount);
                unit = _Unit;
            }
        }
        public struct Recipe
        {
            public Name Name;
            public Restrictions Restrictions;
            public List<Ingredient> Ingredients;
            public Recipe(Name _Name, Restrictions _Restrictions, List<Ingredient> _Ingredients)
            {
                Name = _Name;
                Restrictions = _Restrictions;
                Ingredients = _Ingredients;
            }

        }
    }
}
