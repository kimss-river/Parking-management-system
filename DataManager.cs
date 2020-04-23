using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    class DataManager
    {
        public static List<Car> Cars = new List<Car>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                Cars = (from item in carsXElement.Descendants("car")
                        select new Car()
                        {
                            ParkingSpot = int.Parse(item.Element("parkingSpot").Value),
                            CarNumber = item.Element("carNumber").Value,
                            DriverName = item.Element("driverName").Value,
                            PhoneNumber = item.Element("phoneNumber").Value,
                            ParkingTime = DateTime.Parse(item.Element("parkingTime").Value)

                        }).ToList<Car>();
            }
            catch (Exception)
            {
                Save();
            }
        }

        public static void Save()
        {
            string carsOutput = "";
            carsOutput += "<cars>\n";

            foreach (var item in Cars)
            {
                carsOutput += "<car>\n";
                carsOutput += "<parkingSpot>" + item.ParkingSpot + "</parkingSpot>\n";
                carsOutput += "<carNumber>" + item.CarNumber + "</carNumber>\n";
                carsOutput += "<driverName>" + item.DriverName + "</driverName>\n";
                carsOutput += "<phoneNumber>" + item.PhoneNumber + "</phoneNumber>\n";
                carsOutput += "<parkingTime>" + item.ParkingTime + "</parkingTime>\n";
                carsOutput += "</car>\n";
            }
            carsOutput += "</cars>";

            File.WriteAllText(@"./Cars.xml", carsOutput);
        }
    }
}
