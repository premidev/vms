//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMS_Service.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeetingStatu
    {
        public MeetingStatu()
        {
            this.MeetingStatusHistories = new HashSet<MeetingStatusHistory>();
        }
    
        public int MeetingStatusId { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<MeetingStatusHistory> MeetingStatusHistories { get; set; }
    }
}
