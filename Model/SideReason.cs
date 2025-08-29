using DevExpress.Persistent.Base;
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

        [InverseProperty("Reasons")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Reasons")]
        public virtual ActiveCategory? ActiveCategory { get; set; }
    }
}
