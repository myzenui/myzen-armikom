using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class ReceiverLine : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual int? Line { get; set; }
        public virtual string? Phone { get; set; }
        public virtual string? Prefix { get; set; }

        [InverseProperty("Lines")]
        public virtual Receiver? Receiver { get; set; }
    }
}
