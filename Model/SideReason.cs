using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideReason : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Comment { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Reasons")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Reasons")]
        public virtual ActiveCategory? ActiveCategory { get; set; }
    }
}
