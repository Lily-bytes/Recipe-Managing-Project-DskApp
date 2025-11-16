using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Recipe_Managing_Project_DskApp.DB.recipe;

namespace Recipe_Managing_Project_DskApp.DB
{
    internal class fileWrite
    {
      
         
        XmlDocument xmlDoc;
        
        public fileWrite(XmlDocument doc) {
            xmlDoc = doc;

}
        public void write(string path, Recipe recipe)
        {
           
            xmlDoc.Load(path);
            var input = xmlDoc.ChildNodes[1] .CreateNavigator();

            var x=  input.AppendChild();
       
            x.WriteStartElement("recipe");
            x.WriteStartElement("name");
            x.WriteAttributeString("complexity", recipe.Name.complexity);
            x.WriteName(recipe.Name.name.Replace(" ","-"));
            x.WriteFullEndElement();
            x.WriteStartElement("restrictions");
            x.WriteAttributeString ("meat", recipe.Restrictions.meat.ToString());
            x.WriteAttributeString("seafood", recipe.Restrictions.seafood.ToString());
            x.WriteEndElement();
            for (int i = 0; i < recipe.Ingredients.Count; i++) {
                x.WriteStartElement("ingredient");
                x.WriteAttributeString("name", recipe.Ingredients[i].name);
                x.WriteAttributeString("amount", recipe.Ingredients[i].amount.ToString());
                x.WriteAttributeString("unit", recipe.Ingredients[i].unit);
                x.WriteEndElement();

            }

            x.Close();
            xmlDoc.Save(path);

        }
       
    }
}
