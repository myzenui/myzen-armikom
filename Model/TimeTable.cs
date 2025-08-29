using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class TimeTable : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual int? Day { get; set; }
        public virtual double? OpeningTime { get; set; }
        public virtual int? OpeningEarly { get; set; }
        public virtual int? OpeningLate { get; set; }
        public virtual double? ClosingTime { get; set; }
        public virtual int? ClosingEarly { get; set; }
        public virtual int? ClosingLate { get; set; }
        public virtual Guid? Id1 { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("TimeTables")]
        public virtual Side? Side { get; set; }
    }
}
