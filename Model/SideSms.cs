using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideSms : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? SmsText { get; set; }
        public virtual string? Phone { get; set; }
        public virtual DateTime? RecordDate { get; set; }

        [InverseProperty("SmsMessages")]
        public virtual Side? Side { get; set; }
        [InverseProperty("SmsMessages")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
    }
}
