using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideAlarm : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Side { get; set; }
        public virtual string? SignalCode { get; set; }
        public virtual string? Active { get; set; }
    }
}
