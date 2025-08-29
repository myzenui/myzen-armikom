using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideControl : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? RecordDate { get; set; }
        public virtual bool? Active { get; set; }
        public virtual int? TimeoutDuration { get; set; }

        [InverseProperty("Controls")]
        public virtual Side? Side { get; set; }
        [InverseProperty("SideControls")]
        public virtual Signal? Signal { get; set; }
        [InverseProperty("ControlForSignals")]
        public virtual Signal? ControlSignal { get; set; }
    }
}
