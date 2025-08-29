using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ClosingDelay : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? ClosingDate { get; set; }
        public virtual string? Note { get; set; }

        [InverseProperty("ClosingDelays")]
        public virtual Side? Side { get; set; }
        [InverseProperty("ClosingDelays")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
