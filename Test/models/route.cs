using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class route
    {
        public string id { get; set; }
        public string long_name { get; set; }
        public List<stop> stops { get; set; }
        public int stopsCount
        {
            get
            {
                return stops.Count;
            }
        }

        public route(string id, string long_name)
        {
            this.id = id;
            this.long_name = long_name;
        }
       

    }
}
