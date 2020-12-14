using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement
{
    class EquipmentClass
    {
        public string equipment { get; set; }
        public string description { get; set; }
        public string muscle { get; set; }
        public string date { get; set; }
        public string cost { get; set; }

        public EquipmentClass(string equipment, string description, string muscle, string date, string cost)
        {
            this.equipment = equipment;
            this.description = description;
            this.muscle = muscle;
            this.date = date;
            this.cost = cost;
        }


    }
}
