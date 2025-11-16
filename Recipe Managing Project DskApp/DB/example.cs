using System.Numerics;
using System.Xml;
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
      // this writes the same entry 
        write.write(path,read.getRecipe());


    }
}