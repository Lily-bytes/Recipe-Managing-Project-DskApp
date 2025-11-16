using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp.DB
{
    internal class fileRead
    {
        XmlDocument xmlDoc;
        public List<Recipe> recipe;

        public fileRead(XmlDocument doc)
        {
            xmlDoc = doc;
           
        }

        public void read(string path)
        {
            xmlDoc.Load(path);
            var element = xmlDoc.DocumentElement;
            var root = element.ChildNodes;
            recipe = new List<Recipe>();
            List<Ingredient> ingredients = new List<Ingredient>();
            Name name = new Name();
            Restrictions restrictions = new Restrictions();
            for (int i = 0; i < root.Count; i++)
            {
                foreach(XmlNode node in root[i].ChildNodes) {
  
                    if (node.Name == "name")
                    {
                        name = new Name(node.InnerText, node.Attributes[0].InnerText);
                    }
                    else if (node.Name == "restrictions")
                    {
                        restrictions = new Restrictions(node.Attributes[0].InnerText, node.Attributes[1].InnerText);
                    }
                    else if (node.Name == "ingredient")
                    {
                        ingredients.Add(new Ingredient(node.Attributes[0].InnerText, node.Attributes[1].InnerText, node.Attributes[2].InnerText));

                    }

                }
            
                recipe.Add(new Recipe(name, restrictions, ingredients));
                name = new Name();
                restrictions = new Restrictions();
                ingredients = new List<Ingredient>();
            }
        }
            
        
    
        public List<Recipe> getRecipe()
        {
            return recipe;
        }
    }

}
