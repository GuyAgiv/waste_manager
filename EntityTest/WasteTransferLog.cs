//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class WasteTransferLog
    {
        public int WasteCollectionId { get; set; }
        public int TruckId { get; set; }
        public int BinId { get; set; }
        public double TransferedCapacity { get; set; }
    
        public virtual Bin Bin { get; set; }
        public virtual Truck Truck { get; set; }
    }
}
