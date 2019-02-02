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
    
    public partial class Meeting
    {
        public Meeting()
        {
            this.MeetingStatusHistories = new HashSet<MeetingStatusHistory>();
        }
    
        public int MeetingId { get; set; }
        public int OrganizerId { get; set; }
        public int VisitorId { get; set; }
        public System.DateTime Date { get; set; }
        public string Purpose { get; set; }
        public Nullable<int> OTP { get; set; }
    
        public virtual Organizer Organizer { get; set; }
        public virtual Visitor Visitor { get; set; }
        public virtual ICollection<MeetingStatusHistory> MeetingStatusHistories { get; set; }
    }
}