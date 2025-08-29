using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class MobileMessage : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Message { get; set; }
        public virtual DateTime? RecordDate { get; set; }

        [InverseProperty("MobileMessages")]
        public virtual Side? Side { get; set; }
    }
}
