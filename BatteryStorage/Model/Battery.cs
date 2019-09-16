using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryStorage.Model
{
    class Battery
    {

        public bool IsSelected { get; set; }
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public double Voltage { get; set; }
        public int Capacity { get; set; }
        public double Resistance { get; set; }
        public int LevelOfCharge { get; set; }
    }
}
