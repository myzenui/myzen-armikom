using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class AlarmEvent : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? Date { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("AlarmEvents")]
        public virtual SignalEvent? Event { get; set; }
    }
}
