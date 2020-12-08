using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Ass1.Data
{
    public class SlipManager
    {
        public IList GetAllDocks()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.Select(dck => new
            {
                Id = dck.ID,
                name = dck.Name,
                waterservice = dck.WaterService,
                electricityservice = dck.ElectricalService
            }).ToList();
            return docks;

        }

        public IList GetUnleasedSlip()
        {
            var db = new MarinaEntities();
            var slips = db.Slips.Select(slp => new
            { id = slp.ID, width = slp.Width, lenght = slp.Length, dkId = slp.DockID }).ToList();
            return slips;
        }

        public static List<Slip> GetLeaseAll()
        {
            var db = new MarinaEntities();
            var slips = db.Slips.ToList();
            return slips;
        }

        public static Slip Find(int dkId)
        {
            var db = new MarinaEntities();
            var slp = db.Slips.SingleOrDefault(s => s.DockID == dkId);
            return slp;
        }
    }
}

