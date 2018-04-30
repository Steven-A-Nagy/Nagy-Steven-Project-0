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
        public List<Restaurant> SerializedFromFile()
        {
            string deser = System.IO.File.ReadAllText(ConfigurationManager.AppSettings.GetValues("JSONpath")[0]);
            return DeserializeRestaurants(deser);
        }

        public string SerializeRestaurants(List<Restaurant> sr)
        {
            string response = JsonConvert.SerializeObject(sr);
            return response;
        }

        public List<Restaurant> DeserializeRestaurants(string serializedJSON)
        {
            List<Restaurant> returnList = JsonConvert.DeserializeObject<List<Restaurant>>(serializedJSON);
            return returnList;
        }

    }
}
