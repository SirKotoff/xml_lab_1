using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace xml_lab_1
{
    class Program
    {

       public static void CreateFile()
        {
            Console.WriteLine("[Введите имя xml файла для создания]");
            string file = Console.ReadLine();
            string path = $"{file}.xml";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Console.WriteLine("XML Файл создан");
            }

            string path1 = $"file.txt";
            using (FileStream fsfile = new FileStream(path1, FileMode.OpenOrCreate))
            {
                Console.WriteLine("TXT Файл создан");
            }


            ///

            XDocument xd = new XDocument();
            XElement XS = new XElement("root");

            string[] content = new string[6];
            using (StreamReader sr = new StreamReader(path1))
            {
              

                for (int i = 0; i < 6; i++)
                {
                    content[i] = sr.ReadLine();

                    XElement xss = new XElement($"line{i}", content[i]);
                    XS.Add(xss);
                }
            }


            xd.Add(XS);
            xd.Save(path);





        }




      

        static void Main(string[] args)
        {

            CreateFile();


            Console.ReadKey();
         

        }



        
    }
}
