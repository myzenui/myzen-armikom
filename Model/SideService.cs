using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class SideService : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual bool? Active { get; set; }
        public virtual DateTime? RecordDate { get; set; }
        public virtual string? Statement { get; set; }
        public virtual DateTime? ProcessDate { get; set; }

        [InverseProperty("Services")]
        public virtual Side? Side { get; set; }
        [InverseProperty("Services")]
        public virtual ServiceType? ServiceType { get; set; }
        [InverseProperty("Services")]
        public virtual Dealer? ServiceCompany { get; set; }
        [InverseProperty("Services")]
        public virtual TechnicalPerson? ServicePerson { get; set; }
        [InverseProperty("SideService")]
        public virtual IList<ServiceDetail> Details { get; set; } = new ObservableCollection<ServiceDetail>();
    }
}
