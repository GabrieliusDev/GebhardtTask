using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebhardtTask.Models
{
    public class Route
    {
        public List<int> Stops { get; set; }

        public Route(List<int> stops) 
        {
            Stops = stops;
        }
    }
}
