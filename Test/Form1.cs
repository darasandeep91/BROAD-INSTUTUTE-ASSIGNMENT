using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> ans = new Dictionary<string, List<string>>();
        List<route> routes = new List<route>();

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox3.DataSource = ans[listBox2.SelectedItem.ToString()].Distinct().ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {

                foreach (route item in routes)
                {
                    foreach (stop sitem in item.stops)
                    {
                        if (sitem.stop_name == comboBox1.Text.ToString() || sitem.stop_name == comboBox2.Text.ToString())
                        {
                            result.Add(item.long_name);
                        }
                    }
                }
                listBox4.DataSource = result.Distinct().ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            routes = helpers._objInstance.getAllRoutes();
            foreach (route item in routes)
            {
                item.stops = helpers._objInstance.getStopByRouteId(item.id);
            }
            listBox1.DataSource = routes.Select(r => r.long_name).ToList();
            var minStops = routes.Find(r => r.stopsCount == routes.Min(x => x.stopsCount));
            var maxStops = routes.Find(r => r.stopsCount == routes.Max(x => x.stopsCount));

            label2.Text = $" Station with minimum number of Stops is: {minStops.long_name}, with  { minStops.stopsCount} stops";
            label3.Text = $"Station with maximun number of Stops is: {maxStops.long_name}, with  { maxStops.stopsCount} stops";

            for (int i = 0; i < routes.Count; i++)
            {
                for (int j = i + 1; j < routes.Count; j++)
                {
                    var obj = helpers._objInstance.findCommonStops(routes[i], routes[j]);

                    if (obj.Count != 0)
                    {
                        foreach (string item in obj)
                        {
                            if (ans.Keys.Contains(item))
                            {
                                ans[item].AddRange(new string[] { routes[i].long_name, routes[j].long_name });

                            }
                            else
                            {
                                ans[item] = new List<string> { routes[i].long_name, routes[j].long_name };
                            }
                        }
                    }

                }
            }
            listBox2.DataSource = ans.Keys.ToList();



            var result = routes.SelectMany(r => r.stops.Select(s => s.stop_name)).ToList();
            comboBox1.DataSource = result;
            comboBox2.BindingContext = new BindingContext();
            comboBox2.DataSource = result;
        }
    }
}
