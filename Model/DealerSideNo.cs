using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class DealerSideNo : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual int? SideNo { get; set; }
        public virtual int? Used { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("SideNumbers")]
        public virtual Dealer? Dealer { get; set; }
    }
}
