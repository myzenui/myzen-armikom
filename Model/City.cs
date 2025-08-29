using DevExpress.Persistent.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zen.Model
{

    [DefaultClassOptions]
    public class City : BaseEntity
    {
        public virtual Guid? Id { get; set; }
        public virtual string? Code { get; set; }
        public virtual string? Name { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [InverseProperty("Cities")]
        public virtual Country? Country { get; set; }
        [InverseProperty("City")]
        public virtual IList<District> Districts { get; set; } = new ObservableCollection<District>();
        [InverseProperty("City")]
        public virtual IList<Customer> Customers { get; set; } = new ObservableCollection<Customer>();
        [InverseProperty("City")]
        public virtual IList<MonitoringCenter> MonitoringCenters { get; set; } = new ObservableCollection<MonitoringCenter>();
        [InverseProperty("City")]
        public virtual IList<Dealer> Dealers { get; set; } = new ObservableCollection<Dealer>();
        [InverseProperty("City")]
        public virtual IList<Side> Sides { get; set; } = new ObservableCollection<Side>();
    }
}
