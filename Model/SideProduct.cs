using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideProduct : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? SerialNo { get; set; }
        public virtual DateTime? RecordDateTime { get; set; }
        public virtual string? Name1 { get; set; }
        public virtual string? Name2 { get; set; }

        [InverseProperty("Products")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Sides")]
        public virtual Product? Product { get; set; }
    }
}
