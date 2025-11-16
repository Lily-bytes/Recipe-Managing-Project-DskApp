using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using static Recipe_Managing_Project_DskApp.DB.recipe;
using Recipe_Managing_Project_DskApp.DB;

// See https://aka.ms/new-console-template for more information



public class example
{
    //if you run this, the only way you can tell if its working is from the xml file.
    public void runExample()
    {
        // forced pass of variables that are used by all the files
        XmlDocument xmlDoc = new XmlDocument();
        fileRead read = new fileRead(xmlDoc);
        fileWrite write = new fileWrite(xmlDoc);

      //the default execution path is in debug 
      string path = System.Environment.CurrentDirectory.Replace("bin\\Debug", "\\DB\\dataFile.xml");
        read.read(path);
        List<recipe.Recipe> recipes = read.getRecipe();
        recipe.Name n = new  recipe.Name("Water", "easy");
        recipe.Restrictions r = new Restrictions("False","False");
        recipe.Ingredient i = new Ingredient("water","1","cup");
        List< recipe.Ingredient> il = new List<recipe.Ingredient>();
        il.Add(i);
        recipe.Recipe rep = new recipe.Recipe(n,r,il);

        write.write(path, rep);


    }
}