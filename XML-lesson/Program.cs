using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_lesson
{
    class Program
    {
        static void Main(string[] args)
        {


            XmlDocument document = new XmlDocument();
            document.Load("Cars.xml");

            var rootElement = document.LastChild;

            XmlElement newCarElement = document.CreateElement("car");
            rootElement.AppendChild(newCarElement);

            document.Save("Cars.xml");

            foreach (XmlElement element in rootElement)
            {

                Car car = new Car();
                car.Id = Guid.Parse(element.ChildNodes[0].InnerText);
                car.Mark = element.ChildNodes[1].InnerText;
                car.MadeDate = DateTime.Parse(element.ChildNodes[2].InnerText);
                car.Rating = int.Parse(element.ChildNodes[3].Attributes["value"].InnerText);
            }


        }
    }
}
