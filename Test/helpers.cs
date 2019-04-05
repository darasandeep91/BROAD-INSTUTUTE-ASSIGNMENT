using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class helpers
    {
        
        private helpers() {

        }

        public static readonly helpers _objInstance = new helpers();

        public List<route> getAllRoutes()
        {

            List<route> result = new List<route>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetStringAsync(new Uri("https://api-v3.mbta.com/routes?sort=long_name&filter[type]=0,1")).Result;
                    var Tresult = JObject.Parse(response)["data"];

                    foreach (var item in Tresult)
                    {
                        var id = item["id"].ToString();
                        var long_name = item["attributes"]["long_name"].ToString();
                        route obj = new route(id, long_name);
                        result.Add(obj);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public List<stop> getStopByRouteId(string routeID)
        {

            List<stop> result = new List<stop>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetStringAsync(new Uri($"https://api-v3.mbta.com/stops?filter[route]={routeID}")).Result;
                    var Tresult = JObject.Parse(response)["data"];
                    foreach (var item in Tresult)
                    {
                        var id = item["id"].ToString();
                        var stop_name = item["attributes"]["name"].ToString();
                        stop obj = new stop(id, stop_name);
                        result.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }

        public List<string> findCommonStops(route route1, route route2)
        {
            return route1.stops.Select(x => x.stop_name).Intersect(route2.stops.Select(x => x.stop_name)).ToList();
        }
    }
}
