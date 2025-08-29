using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SignalEvent : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? EventCode { get; set; }
        public virtual string? Zone { get; set; }
        public virtual DateTime? SignalDateTime { get; set; }
        public virtual int? ReceiverNo { get; set; }
        public virtual int? LineNo { get; set; }
        public virtual int? ActionTime { get; set; }
        public virtual int? ResponsTime { get; set; }
        public virtual string? Action { get; set; }
        public virtual bool? RealSignal { get; set; }
        public virtual string? Description { get; set; }
        public virtual string? Sound { get; set; }
        public virtual Guid? Id1 { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Events")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Events")]
        public virtual Signal? Signal { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SignalEvents")]
        public virtual Receiver? Receiver { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SignalEvents")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SignalEvents")]
        public virtual EventRaw? EventRaw { get; set; }
        [InverseProperty("Event")]
        public virtual IList<AlarmEvent> AlarmEvents { get; set; } = new ObservableCollection<AlarmEvent>();
        [InverseProperty("Event")]
        public virtual IList<WaitingEvent> WaitingEvents { get; set; } = new ObservableCollection<WaitingEvent>();
    }
}
