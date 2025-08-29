using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class PassiveSignal : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? EventCode { get; set; }
        public virtual string? SysPhone { get; set; }
        public virtual int? Part { get; set; }

        [InverseProperty("PassiveSignals")]
        public virtual Receiver? Receiver { get; set; }
        [InverseProperty("PassiveSignals")]
        public virtual Side? Side { get; set; }
        [InverseProperty("PassiveSignals")]
        public virtual Signal? Signal { get; set; }
        [InverseProperty("PassiveSignals")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
