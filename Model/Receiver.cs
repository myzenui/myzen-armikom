using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class Receiver : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int? CommunicationType { get; set; }
        public virtual int? SocketType { get; set; }
        public virtual string? Ip { get; set; }
        public virtual string? Port { get; set; }
        public virtual string? BaudRate { get; set; }
        public virtual string? DataBits { get; set; }
        public virtual string? Parity { get; set; }
        public virtual string? HandShake { get; set; }
        public virtual int? CommunicatorType { get; set; }
        public virtual string? ReceiverNo { get; set; }
        public virtual int? Line { get; set; }
        public virtual int? TimeoutDuration { get; set; }
        public virtual int? SignalCount { get; set; }
        public virtual string? Delimiter { get; set; }
        public virtual bool? Active { get; set; }
        public virtual DateTime? LastSignalDate { get; set; }

        [InverseProperty("Receivers")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [InverseProperty("Receivers")]
        public virtual DeviceRegex? DeviceRegex { get; set; }
        [InverseProperty("Receiver")]
        public virtual IList<EventRaw> EventRaws { get; set; } = new ObservableCollection<EventRaw>();
        [InverseProperty("Receiver")]
        public virtual IList<ReceiverLine> Lines { get; set; } = new ObservableCollection<ReceiverLine>();
        [InverseProperty("Receivers")]
        public virtual IList<ReceiverType> ReceiverTypes { get; set; } = new ObservableCollection<ReceiverType>();
        [InverseProperty("Receiver")]
        public virtual IList<PassiveSignal> PassiveSignals { get; set; } = new ObservableCollection<PassiveSignal>();
        [InverseProperty("Receiver")]
        public virtual IList<SignalEvent> SignalEvents { get; set; } = new ObservableCollection<SignalEvent>();
    }
}
