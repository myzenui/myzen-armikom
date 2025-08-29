using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Side : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual int? SideNo { get; set; }
        public virtual int? PartNo { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Address { get; set; }
        public virtual string? Phone1 { get; set; }
        public virtual string? Phone2 { get; set; }
        public virtual bool? Active { get; set; }
        public virtual DateTime? LastSignalDate { get; set; }
        public virtual DateTime? InstallDate { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual bool? IsOpen { get; set; }
        public virtual string? LockUser { get; set; }
        public virtual string? SysPhone { get; set; }
        public virtual string? MobilePhone { get; set; }
        public virtual Guid? SiteType { get; set; }
        public virtual string? Comment { get; set; }
        public virtual bool? Approved { get; set; }
        public virtual string? SafePassword { get; set; }
        public virtual string? IdentityNo { get; set; }
        public virtual DateTime? RecordDateTime { get; set; }
        public virtual string? SerialNumber { get; set; }
        public virtual int? TimeoutDuration { get; set; }
        public virtual string? PoliceStationNo { get; set; }
        public virtual string? Latitude { get; set; }
        public virtual string? Longitude { get; set; }
        public virtual Guid? Id1 { get; set; }
        public virtual bool? Gprs { get; set; }
        public virtual decimal? GprsTimeoutMinutes { get; set; }
        public virtual string? DocumentId { get; set; }

        [InverseProperty("Sides")]
        public virtual Customer? Customer { get; set; }
        [InverseProperty("Sides")]
        public virtual Dealer? Dealer { get; set; }
        [InverseProperty("Sides")]
        public virtual Brand? Brand { get; set; }
        [InverseProperty("Sides")]
        public virtual Model? Model { get; set; }
        [InverseProperty("Sides")]
        public virtual Protocol? Protocol { get; set; }
        [InverseProperty("Sides")]
        public virtual City? City { get; set; }
        [InverseProperty("Sides")]
        public virtual District? District { get; set; }
        [InverseProperty("Sides")]
        public virtual Region? Region { get; set; }
        [InverseProperty("InstalledSides")]
        public virtual Dealer? Installer { get; set; }
        [InverseProperty("Sides")]
        public virtual AccountType? AccountType { get; set; }
        [InverseProperty("Sides")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [InverseProperty("Sides")]
        public virtual SideType? SideType { get; set; }
        [InverseProperty("Side")]
        public virtual IList<ClosingDelay> ClosingDelays { get; set; } = new ObservableCollection<ClosingDelay>();
        [InverseProperty("Side")]
        public virtual IList<MobileMessage> MobileMessages { get; set; } = new ObservableCollection<MobileMessage>();
        [InverseProperty("Side")]
        public virtual IList<SideAgreement> Agreements { get; set; } = new ObservableCollection<SideAgreement>();
        [InverseProperty("Side")]
        public virtual IList<SideCall> Calls { get; set; } = new ObservableCollection<SideCall>();
        [InverseProperty("Side")]
        public virtual IList<SideContact> Contacts { get; set; } = new ObservableCollection<SideContact>();
        [InverseProperty("Side")]
        public virtual IList<SideDocument> Documents { get; set; } = new ObservableCollection<SideDocument>();
        [InverseProperty("Side")]
        public virtual IList<SideHoliday> Holidays { get; set; } = new ObservableCollection<SideHoliday>();
        [InverseProperty("Side")]
        public virtual IList<SideMail> Mails { get; set; } = new ObservableCollection<SideMail>();
        [InverseProperty("Side")]
        public virtual IList<SideMobile> Mobiles { get; set; } = new ObservableCollection<SideMobile>();
        [InverseProperty("Side")]
        public virtual IList<SideProduct> Products { get; set; } = new ObservableCollection<SideProduct>();
        [InverseProperty("Side")]
        public virtual IList<SideReason> Reasons { get; set; } = new ObservableCollection<SideReason>();
        [InverseProperty("Side")]
        public virtual IList<SideSms> SmsMessages { get; set; } = new ObservableCollection<SideSms>();
        [InverseProperty("Side")]
        public virtual IList<SideUser> Users { get; set; } = new ObservableCollection<SideUser>();
        [InverseProperty("Side")]
        public virtual IList<SideZone> Zones { get; set; } = new ObservableCollection<SideZone>();
        [InverseProperty("Side")]
        public virtual IList<PassiveSignal> PassiveSignals { get; set; } = new ObservableCollection<PassiveSignal>();
        [InverseProperty("Side")]
        public virtual IList<SideControl> Controls { get; set; } = new ObservableCollection<SideControl>();
        [InverseProperty("Side")]
        public virtual IList<SideNote> Notes { get; set; } = new ObservableCollection<SideNote>();
        [InverseProperty("Side")]
        public virtual IList<SignalBloke> Blokes { get; set; } = new ObservableCollection<SignalBloke>();
        [InverseProperty("Side")]
        public virtual IList<SignalEvent> Events { get; set; } = new ObservableCollection<SignalEvent>();
        [InverseProperty("Side")]
        public virtual IList<SideService> Services { get; set; } = new ObservableCollection<SideService>();
        [InverseProperty("Side")]
        public virtual IList<TechnicalWork> TechnicalWorks { get; set; } = new ObservableCollection<TechnicalWork>();
        [InverseProperty("Side")]
        public virtual IList<TimeTable> TimeTables { get; set; } = new ObservableCollection<TimeTable>();
    }
}
