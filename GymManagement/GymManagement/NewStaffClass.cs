using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement
{
    class NewStaffClass
    {
        public string vnev { get; set; }
        public string knev { get; set; }
        public string nem { get; set; }
        public string szuldat { get; set; }
        public string mobil { get; set; }
        public string email { get; set; }
        public string joindate { get; set; }
        public string state { get; set; }
        public string city { get; set; }

        public NewStaffClass(string vnev, string knev, string nem, string szuldat, string mobil, string email, string joindate, string state, string city)
        {
            this.vnev = vnev;
            this.knev = knev;
            this.nem = nem;
            this.szuldat = szuldat;
            this.mobil = mobil;
            this.email = email;
            this.joindate = joindate;
            this.state = state;
            this.city = city;
        }
    }
}
