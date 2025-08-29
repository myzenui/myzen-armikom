using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class MonitoringCenter : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Phone1 { get; set; }
        public virtual string? Phone2 { get; set; }
        public virtual string? Address { get; set; }
        public virtual string? Email { get; set; }
        public virtual string? Logo { get; set; }
        public virtual string? SoundPath { get; set; }
        public virtual string? DefaultSound { get; set; }
        public virtual string? Prefix { get; set; }
        public virtual int? SideNoEnd { get; set; }
        public virtual int? SideNoStart { get; set; }

        [InverseProperty("MonitoringCenters")]
        public virtual City? City { get; set; }
        [InverseProperty("MonitoringCenters")]
        public virtual District? District { get; set; }
        [InverseProperty("MonitoringCenters")]
        public virtual Country? Country { get; set; }
        [InverseProperty("MonitoringCenter")]
        public virtual IList<AccountItem> AccountItems { get; set; } = new ObservableCollection<AccountItem>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<AccountType> AccountTypes { get; set; } = new ObservableCollection<AccountType>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<MailSetting> MailSettings { get; set; } = new ObservableCollection<MailSetting>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<Receiver> Receivers { get; set; } = new ObservableCollection<Receiver>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<Dealer> Dealers { get; set; } = new ObservableCollection<Dealer>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<DealerAccountType> DealerAccountTypes { get; set; } = new ObservableCollection<DealerAccountType>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<ClosingDelay> ClosingDelays { get; set; } = new ObservableCollection<ClosingDelay>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<PassiveSignal> PassiveSignals { get; set; } = new ObservableCollection<PassiveSignal>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<SignalBloke> SignalBlokes { get; set; } = new ObservableCollection<SignalBloke>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<SignalEvent> SignalEvents { get; set; } = new ObservableCollection<SignalEvent>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<SignalExplanations> SignalExplanations { get; set; } = new ObservableCollection<SignalExplanations>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<SmsSetting> SmsSettings { get; set; } = new ObservableCollection<SmsSetting>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<TechnicalWork> TechnicalWorks { get; set; } = new ObservableCollection<TechnicalWork>();
        [InverseProperty("MonitoringCenter")]
        public virtual IList<WaitingEvent> WaitingEvents { get; set; } = new ObservableCollection<WaitingEvent>();
    }
}
