using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    public abstract class ClsTourCompany
    {
        public static string fileName = "screenshots.sln";
        private static FrmTour _TourForm = new FrmTour();

        public static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();

        public static Dictionary<string, ClsTour> TourList
        {
            get { return ClsTourCompany._TourList; }
            //      set { ClsTourCompany._TourList = value; }
        }

        public static ClsTour NewTour()
        {
            return new ClsTour();
        }

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }

        public static void Retrieve()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)lcFormatter.Deserialize(lcFileStream);
            }
        }
    }
}

