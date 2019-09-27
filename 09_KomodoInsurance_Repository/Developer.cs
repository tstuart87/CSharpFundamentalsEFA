using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance_Repository
{
    public class Developer
    {
        public int DevID { get; set; }
        public string LastName { get; set; }
        public bool HasAccessToPluralSight { get; set; }

        public Developer(int devID, string lastName, bool hasAccessToPluralSight)
        {
            DevID = devID;
            LastName = lastName;
            HasAccessToPluralSight = hasAccessToPluralSight;
        }

        public Developer()
        {

        }
    }
}
