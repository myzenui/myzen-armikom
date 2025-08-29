using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class WaitingEvent : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? DelayTime { get; set; }

        [InverseProperty("WaitingEvents")]
        public virtual SignalEvent? Event { get; set; }
        [InverseProperty("WaitingEvents")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
