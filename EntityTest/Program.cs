﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is like the BinController

            //GetAllBins

            using (BusinessLogic bl = new BusinessLogic())
            {
                List<Bin> binList = bl.GetAllBins();

                foreach (Bin bin in binList)
                {
                    Console.WriteLine("Trash Id= " + bin.BinId + " Address= " + bin.CityAddress + " " + bin.StreetAddress + " " + bin.StreetNumber);
                }
                Console.WriteLine("================");


                Bin singleBin = bl.GetBin(1);
                Console.WriteLine("Id = {0}, Old Capacity = {1}", singleBin.BinId, singleBin.CurrentCapacity);
                singleBin.CurrentCapacity += 10;
                bl.UpdateBin(singleBin);
                Console.WriteLine("Id = {0}, New Capacity = {1}", singleBin.BinId, singleBin.CurrentCapacity);
            }

        }
    }
}
