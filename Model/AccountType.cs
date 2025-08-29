using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class AccountType : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Code { get; set; }
        public virtual int? CallType { get; set; }
        public virtual bool? Sms { get; set; }
        public virtual bool? Ivr { get; set; }
        public virtual decimal? Price { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("AccountTypes")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [InverseProperty("AccountType")]
        public virtual IList<DealerAccountType> DealerAccountTypes { get; set; } = new ObservableCollection<DealerAccountType>();
        [InverseProperty("AccountType")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
