using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class District : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Name { get; set; }

        [InverseProperty("Districts")]
        public virtual City? City { get; set; }
        [InverseProperty("District")]
        public virtual IList<Customer> Customers { get; set; } = new ObservableCollection<Customer>();
        [InverseProperty("District")]
        public virtual IList<MonitoringCenter> MonitoringCenters { get; set; } = new ObservableCollection<MonitoringCenter>();
        [InverseProperty("District")]
        public virtual IList<Dealer> Dealers { get; set; } = new ObservableCollection<Dealer>();
        [InverseProperty("District")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
