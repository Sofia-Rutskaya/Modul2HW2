using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Provider
{
    public class Device
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public int Id { get; set; }
    }
}
