using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class AccountItem : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }
        public virtual bool? Monitoring { get; set; }
        public virtual decimal? Price { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("AccountItems")]
        public virtual MonitoringCenter? MonitoringCenter { get; set; }
        [InverseProperty("AccountItem")]
        public virtual IList<SideAgreement> Agreements { get; set; } = new ObservableCollection<SideAgreement>();
    }
}
