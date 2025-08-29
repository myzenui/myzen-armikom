using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class DealerAccountType : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual decimal? Price { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("DealerAccountTypes")]
        public virtual AccountType? AccountType { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("AccountTypes")]
        public virtual Dealer? Dealer { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("DealerAccountTypes")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
    }
}
