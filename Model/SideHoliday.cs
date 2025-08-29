using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideHoliday : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual bool? Recursive { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Holidays")]
        public virtual Side? Side { get; set; }
    }
}
