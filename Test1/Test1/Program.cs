using System;
using System.Xml;

namespace Test1
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
          
            String URLString = "https://www.ilmateenistus.ee/ilma_andmed/xml/forecast.php?lang=eng";
            var weatherlist = new List<Weather>();
            using (XmlTextReader xmlReader = new XmlTextReader(URLString))
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlReader);
                var parentNode = xmlDocument.SelectNodes("//forecasts//forecast//day//place");
                var dayNode = xmlDocument.SelectNodes("//forecasts//forecast//night//place");
                foreach (XmlNode node in parentNode)
                {
                    Weather weather;
                    weather = new Weather();
                    weather.name = node["name"].InnerText;
                    weather.phenomenon = node["phenomenon"].InnerText;
                    weather.tempmax = node["tempmax"].InnerText;
                    
                    

                        weatherlist.Add(weather);
                        Console.WriteLine(weather.name); 
                        Console.WriteLine(weather.phenomenon);
                        
                    Console.WriteLine(weather.tempmax);
                    }
                Console.WriteLine();
                foreach (XmlNode node2 in dayNode)
                {
                    Weather weather;
                    weather = new Weather();
                    weather.name = node2["name"].InnerText;
                    weather.phenomenon = node2["phenomenon"].InnerText;
                    weather.tempmin = node2["tempmin"].InnerText;



                    weatherlist.Add(weather);
                    Console.WriteLine(weather.name);
                    Console.WriteLine(weather.phenomenon);
                    Console.WriteLine(weather.tempmin);
                    
                }
            }


                Console.ReadKey();
            }

        }
    
}