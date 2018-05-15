using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityTest
{
    internal class BusinessLogic : IDisposable
    {
        private WasteManagerEntities db;

        public BusinessLogic()
        {
            this.db = new WasteManagerEntities();
        }

        //TODO - Implement Methods of GET/SET/UPDATE/DELETE things from the database

        public List<Bin> GetAllBins()
        {
            return this.db.Bins.ToList();
        }

        public Bin GetBin(int id)
        {
            return this.db.Bins.Where(x => x.BinId == id).SingleOrDefault();
        }

        public Bin AddNewBin(Bin newBin)
        {
            this.db.Bins.Add(newBin);
            this.db.SaveChanges();
            //TODO - check if newBin got an id from db 
            return newBin;
        }

        public void UpdateBin(Bin updatedBin)
        {
            Bin oldBin = this.db.Bins.Where(x => x.BinId == updatedBin.BinId).SingleOrDefault();
            if (oldBin != null)
            {
                oldBin.CurrentCapacity = updatedBin.CurrentCapacity;
                //you can update more properties here.... (in the same way)
            }
            this.db.SaveChanges();
        }

        public void DeleteBin(int id)
        {
            Bin binToRemove = this.db.Bins.Where(x => x.BinId == id).SingleOrDefault();
            this.db.Bins.Remove(binToRemove);
            this.db.SaveChanges();
        }


        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}