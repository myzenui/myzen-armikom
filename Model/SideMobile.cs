using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
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

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Mobiles")]
        public virtual Side? Side { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Mobiles")]
        public virtual AlarmCategory? AlarmCategory { get; set; }
    }
}
