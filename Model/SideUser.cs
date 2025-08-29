using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideUser : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual int? UserNo { get; set; }
        public virtual string? Watchword { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Users")]
        public virtual Side? Side { get; set; }
    }
}
