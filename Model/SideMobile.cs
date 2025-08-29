using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideMobile : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual bool? Active { get; set; }

        [InverseProperty("Mobiles")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Mobiles")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
    }
}
