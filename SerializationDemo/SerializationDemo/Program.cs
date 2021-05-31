using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary Serializable
             // Binary
      /*      Person personObj1 = new Person {

                Age = 20,
                name = "Das",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };
            Person personObj2 = new Person
            {

                Age = 20,
                name = "Talreja",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };
            Person personObj3 = new Person
            {

                Age = 20,
                name = "Chaube",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };

            List<Person> listObj = new List<Person>();
            listObj.Add(personObj1);
            listObj.Add(personObj2);
            listObj.Add(personObj3);

            // write
           FileStream filestreamObj = new FileStream(@"E:\DEMO CYBAGE\Vrushali Bhise\C# Demos\Text folder\PersonInfo.bin",
                FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binaryObj = new BinaryFormatter();
            binaryObj.Serialize(filestreamObj, listObj);
            filestreamObj.Close();
            Console.WriteLine("Data written in the file");  
        
            // read
            FileStream filestreamObj1 = new FileStream(@"E:\DEMO CYBAGE\Vrushali Bhise\C# Demos\Text folder\PersonInfo.bin",
              FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter binaryObj1 = new BinaryFormatter();
            listObj = (List<Person>)binaryObj.Deserialize(filestreamObj1);
            filestreamObj1.Close();
            Console.WriteLine();
            foreach(object element in listObj)
            {
                Console.WriteLine(element);
            }  */
            #endregion

            #region Xml Serializable
            
            XmlSerializer xmlObj = new XmlSerializer(typeof(List<Person>));
            Person personObj1 = new Person
            {

                Age = 20,
                name = "Sritam",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };
            Person personObj2 = new Person
            {

                Age = 20,
                name = "Vinay",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };
            Person personObj3 = new Person
            {

                Age = 20,
                name = "Subhada",
                DOB = DateTime.Now,
                AdditionalInfo = "none"
            };

            List<Person> listObj = new List<Person>();
            listObj.Add(personObj1);
            listObj.Add(personObj2);
            listObj.Add(personObj3);

            // write
            FileStream filestreamObj = new FileStream(@"E:\DEMO CYBAGE\Vrushali Bhise\C# Demos\Text folder\PersonInfo.xml",
              FileMode.OpenOrCreate, FileAccess.Write);
            xmlObj.Serialize(filestreamObj, listObj);
            filestreamObj.Close();
            Console.WriteLine("Data is written in the list");


            // read
            FileStream filestreamObj1 = new FileStream(@"E:\DEMO CYBAGE\Vrushali Bhise\C# Demos\Text folder\PersonInfo.xml",
             FileMode.OpenOrCreate, FileAccess.Read);
            List<Person> listObj1 = (List<Person>)xmlObj.Deserialize(filestreamObj1);
            filestreamObj1.Close();
            Console.WriteLine();
            foreach (object element in listObj)
            {
                Console.WriteLine(element);
            } 
            
            #endregion
        }
    }
}
