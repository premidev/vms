﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class VMSDbEntities : DbContext
    {
        public VMSDbEntities()
            : base("name=VMSDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingStatu> MeetingStatus { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<MeetingStatusHistory> MeetingStatusHistories { get; set; }
    
        public virtual int spCreateMeeting(Nullable<int> organizerId, string visitorEmail, string contactNumber, Nullable<System.DateTime> scheduledDate, string purpose)
        {
            var organizerIdParameter = organizerId.HasValue ?
                new ObjectParameter("OrganizerId", organizerId) :
                new ObjectParameter("OrganizerId", typeof(int));
    
            var visitorEmailParameter = visitorEmail != null ?
                new ObjectParameter("VisitorEmail", visitorEmail) :
                new ObjectParameter("VisitorEmail", typeof(string));
    
            var contactNumberParameter = contactNumber != null ?
                new ObjectParameter("ContactNumber", contactNumber) :
                new ObjectParameter("ContactNumber", typeof(string));
    
            var scheduledDateParameter = scheduledDate.HasValue ?
                new ObjectParameter("ScheduledDate", scheduledDate) :
                new ObjectParameter("ScheduledDate", typeof(System.DateTime));
    
            var purposeParameter = purpose != null ?
                new ObjectParameter("Purpose", purpose) :
                new ObjectParameter("Purpose", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCreateMeeting", organizerIdParameter, visitorEmailParameter, contactNumberParameter, scheduledDateParameter, purposeParameter);
        }
    
        public virtual int spUpdateMeeting(Nullable<int> meetingID, Nullable<int> statusId, string email, Nullable<int> oTP)
        {
            var meetingIDParameter = meetingID.HasValue ?
                new ObjectParameter("MeetingID", meetingID) :
                new ObjectParameter("MeetingID", typeof(int));
    
            var statusIdParameter = statusId.HasValue ?
                new ObjectParameter("statusId", statusId) :
                new ObjectParameter("statusId", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var oTPParameter = oTP.HasValue ?
                new ObjectParameter("OTP", oTP) :
                new ObjectParameter("OTP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateMeeting", meetingIDParameter, statusIdParameter, emailParameter, oTPParameter);
        }
    }
}
