using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SignalBloke : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? SignalCode { get; set; }
        public virtual DateTime? RecordDate { get; set; }
        public virtual DateTime? EndDate { get; set; }

        [InverseProperty("Blokes")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Blokes")]
        public virtual Signal? Signal { get; set; }
        [InverseProperty("SignalBlokes")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
