using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class stop
    {
        public string id { get; set; }
        public string stop_name { get; set; }
        public stop(string id, string stop_name) {
            this.id = id;
            this.stop_name = stop_name;
        }
    }
}
