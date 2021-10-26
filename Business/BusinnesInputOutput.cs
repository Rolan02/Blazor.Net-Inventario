using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using System.Linq;

namespace Business
{
    public class BusinnesInputOutput
    {
        public List<InputOuputEntity> InputOuputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }
        public void CreateOutput(InputOuputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oOutput);
                db.SaveChanges();
            }
        }
        public void UpdateWarehouse(InputOuputEntity oOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oOutput);
            }
        }
    }
}
