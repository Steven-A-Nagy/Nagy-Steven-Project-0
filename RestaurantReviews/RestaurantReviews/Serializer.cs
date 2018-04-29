using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace RestaurantReviews
{
    public class Serializer
    {
        public void SerializedToFile(string input)
        {
            System.IO.File.WriteAllText(ConfigurationManager.AppSettings.GetValues("JSONpath")[0], input);
        }
        public List<RestaurantClass> SerializedFromFile()
        {
            string deser = System.IO.File.ReadAllText(ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            return DeserializeRestaurants(deser);
        }

        public string SerializeRestaurants(List<RestaurantClass> sr)
        {
            string response = JsonConvert.SerializeObject(sr);
            return response;
        }

        public List<RestaurantClass> DeserializeRestaurants(string serializedJSON)
        {
            List<RestaurantClass> returnList = JsonConvert.DeserializeObject<List<RestaurantClass>>(serializedJSON);
            return returnList;
        }

    }
}
