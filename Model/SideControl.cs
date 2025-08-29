using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
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

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Controls")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SideControls")]
        public virtual Signal? Signal { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("ControlForSignals")]
        public virtual Signal? ControlSignal { get; set; }
    }
}
